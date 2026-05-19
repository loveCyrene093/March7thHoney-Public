using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using March7thHoney.Configuration;
using March7thHoney.Database.Account;
using March7thHoney.Database.Quests;
using March7thHoney.Internationalization;
using March7thHoney.Util;
using SqlSugar;

namespace March7thHoney.Database;

public class DatabaseHelper
{
	public static Logger logger = new Logger("Database");

	public static SqlSugarScope? sqlSugarScope;

	public static DatabaseHelper? Instance;

	public static readonly ConcurrentDictionary<int, List<BaseDatabaseDataHelper>> UidInstanceMap = new ConcurrentDictionary<int, List<BaseDatabaseDataHelper>>();

	public static readonly List<int> ToSaveUidList = new List<int>();

	public static long LastSaveTick = DateTime.UtcNow.Ticks;

	public static Thread? SaveThread;

	public static bool LoadAccount;

	public static bool LoadAllData;

	public DatabaseHelper()
	{
		Instance = this;
	}

	public void Initialize()
	{
		logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", I18NManager.Translate("Word.Database")));
		ConfigContainer config = ConfigManager.Config;
		string databaseType = config.Database.DatabaseType;
		DbType dbType;
		string connectionString;
		if (!(databaseType == "sqlite"))
		{
			if (!(databaseType == "mysql"))
			{
				return;
			}
			dbType = DbType.MySql;
			connectionString = $"server={config.Database.MySqlHost};Port={config.Database.MySqlPort};Database={config.Database.MySqlDatabase};Uid={config.Database.MySqlUser};Pwd={config.Database.MySqlPassword};";
		}
		else
		{
			dbType = DbType.Sqlite;
			FileInfo fileInfo = new FileInfo(config.Path.DatabasePath + "/" + config.Database.DatabaseName);
			if (!fileInfo.Exists && fileInfo.Directory != null)
			{
				fileInfo.Directory.Create();
			}
			connectionString = "Data Source=" + fileInfo.FullName + ";";
		}
		sqlSugarScope = new SqlSugarScope(new ConnectionConfig
		{
			ConnectionString = connectionString,
			DbType = dbType,
			IsAutoCloseConnection = true,
			ConfigureExternalServices = new ConfigureExternalServices
			{
				SerializeService = new CustomSerializeService()
			}
		});
		databaseType = config.Database.DatabaseType;
		if (!(databaseType == "sqlite"))
		{
			if (databaseType == "mysql")
			{
				InitializeMysql();
			}
			else
			{
				logger.Error("Unsupported database type");
			}
		}
		else
		{
			InitializeSqlite();
		}
		Type baseType = typeof(BaseDatabaseDataHelper);
		Assembly assembly = typeof(BaseDatabaseDataHelper).Assembly;
		IEnumerable<Type> types = from t in assembly.GetTypes()
			where t.IsSubclassOf(baseType)
			select t;
		List<AccountData> source = (from x in sqlSugarScope.Queryable<AccountData>()
			select (x)).ToList();
		foreach (BaseDatabaseDataHelper item in ((IEnumerable<AccountData>)source).Select((Func<AccountData, BaseDatabaseDataHelper>)((AccountData instance) => instance)))
		{
			if (!UidInstanceMap.TryGetValue(item.Uid, out List<BaseDatabaseDataHelper> value))
			{
				value = new List<BaseDatabaseDataHelper>();
				UidInstanceMap[item.Uid] = value;
			}
			value.Add(item);
		}
		LoadAccount = true;
		ParallelLoopResult parallelLoopResult = Parallel.ForEach(source, delegate(AccountData account)
		{
			Parallel.ForEach(types, delegate(Type t)
			{
				if (!(t == typeof(AccountData)))
				{
					typeof(DatabaseHelper).GetMethod("InitializeTable")?.MakeGenericMethod(t).Invoke(null, new object[1] { account.Uid });
				}
			});
		});
		while (!parallelLoopResult.IsCompleted)
		{
		}
		LastSaveTick = DateTime.UtcNow.Ticks;
		SaveThread = new Thread((ThreadStart)delegate
		{
			while (true)
			{
				CalcSaveDatabase();
			}
		});
		SaveThread.Start();
		LoadAllData = true;
	}

	public static void InitializeTable<T>(int uid) where T : BaseDatabaseDataHelper, new()
	{
		foreach (BaseDatabaseDataHelper item in ((IEnumerable<T>)((from x in (from x in sqlSugarScope?.Queryable<T>()
				select (x)).Select<T>()
			where x.Uid == uid
			select x).ToList())).Select((Func<T, BaseDatabaseDataHelper>)((T instance) => instance)))
		{
			if (!UidInstanceMap.TryGetValue(item.Uid, out List<BaseDatabaseDataHelper> value))
			{
				value = new List<BaseDatabaseDataHelper>();
				UidInstanceMap[item.Uid] = value;
			}
			value.Add(item);
		}
	}

	public void UpgradeDatabase()
	{
		logger.Info("Upgrading database...");
		foreach (MissionData item in GetAllInstance<MissionData>())
		{
			item.MoveFromOld();
		}
	}

	public void MoveFromSqlite()
	{
		logger.Info("Moving from sqlite...");
		ConfigContainer config = ConfigManager.Config;
		FileInfo fileInfo = new FileInfo(config.Path.DatabasePath + "/" + config.Database.DatabaseName);
		SqlSugarScope sqlSugarScope = new SqlSugarScope(new ConnectionConfig
		{
			ConnectionString = "Data Source=" + fileInfo.FullName + ";",
			DbType = DbType.Sqlite,
			IsAutoCloseConnection = true,
			ConfigureExternalServices = new ConfigureExternalServices
			{
				SerializeService = new CustomSerializeService()
			}
		});
		Type baseType = typeof(BaseDatabaseDataHelper);
		foreach (Type item in from t in typeof(BaseDatabaseDataHelper).Assembly.GetTypes()
			where t.IsSubclassOf(baseType)
			select t)
		{
			typeof(DatabaseHelper).GetMethod("MoveSqliteTable")?.MakeGenericMethod(item).Invoke(null, new object[1] { sqlSugarScope });
		}
		Environment.Exit(0);
	}

	public static void MoveSqliteTable<T>(SqlSugarScope scope) where T : class, new()
	{
		try
		{
			foreach (T item in scope.Queryable<T>().ToList())
			{
				sqlSugarScope?.Insertable(item).ExecuteCommand();
			}
		}
		catch (Exception e)
		{
			Logger.GetByClassName().Error("An error occurred while moving the table", e);
		}
	}

	public static void InitializeSqlite()
	{
		Type baseType = typeof(BaseDatabaseDataHelper);
		foreach (Type item in from t in typeof(BaseDatabaseDataHelper).Assembly.GetTypes()
			where t.IsSubclassOf(baseType)
			select t)
		{
			typeof(DatabaseHelper).GetMethod("InitializeSqliteTable")?.MakeGenericMethod(item).Invoke(null, null);
		}
	}

	public static void InitializeMysql()
	{
		sqlSugarScope?.DbMaintenance.CreateDatabase();
		InitializeSqlite();
	}

	public static void InitializeSqliteTable<T>() where T : class, new()
	{
		try
		{
			sqlSugarScope?.CodeFirst.InitTables<T>();
		}
		catch
		{
		}
	}

	public T? GetInstance<T>(int uid) where T : class, new()
	{
		try
		{
			if (UidInstanceMap.TryGetValue(uid, out List<BaseDatabaseDataHelper> value))
			{
				return (from instance in value.OfType<T>()
					select (instance)).FirstOrDefault();
			}
			value = new List<BaseDatabaseDataHelper>();
			UidInstanceMap[uid] = value;
			return (from instance in value.OfType<T>()
				select (instance)).FirstOrDefault();
		}
		catch (Exception e)
		{
			logger.Error("Unsupported type", e);
			return null;
		}
	}

	public T GetInstanceOrCreateNew<T>(int uid) where T : BaseDatabaseDataHelper, new()
	{
		T instance = GetInstance<T>(uid);
		if (instance != null)
		{
			return instance;
		}
		List<T> list = (from x in sqlSugarScope?.Queryable<T>()
			where x.Uid == uid
			select x).ToList();
		if (list != null && list.Count > 0)
		{
			instance = list[0];
			if (!UidInstanceMap.TryGetValue(uid, out List<BaseDatabaseDataHelper> value))
			{
				value = new List<BaseDatabaseDataHelper>();
				UidInstanceMap[uid] = value;
			}
			value.Add(instance);
			return instance;
		}
		instance = new T
		{
			Uid = uid
		};
		SaveInstance(instance);
		return instance;
	}

	public static List<T>? GetAllInstance<T>() where T : class, new()
	{
		try
		{
			return (from x in sqlSugarScope?.Queryable<T>()
				select (x)).ToList();
		}
		catch (Exception e)
		{
			logger.Error("Unsupported type", e);
			return null;
		}
	}

	public static List<T>? GetAllInstanceFromMap<T>() where T : class, new()
	{
		try
		{
			return (from instance in UidInstanceMap.Values.SelectMany((List<BaseDatabaseDataHelper> x) => x).ToList().OfType<T>()
				select (instance)).ToList();
		}
		catch (Exception e)
		{
			logger.Error("Unsupported type", e);
			return null;
		}
	}

	public static void SaveInstance<T>(T instance) where T : class, new()
	{
		sqlSugarScope?.Insertable(instance).ExecuteCommand();
		BaseDatabaseDataHelper baseDatabaseDataHelper = instance as BaseDatabaseDataHelper;
		if (!UidInstanceMap.TryGetValue(baseDatabaseDataHelper.Uid, out List<BaseDatabaseDataHelper> value))
		{
			value = new List<BaseDatabaseDataHelper>();
			UidInstanceMap[baseDatabaseDataHelper.Uid] = value;
		}
		value.Add(baseDatabaseDataHelper);
	}

	public void CalcSaveDatabase()
	{
		if (LastSaveTick + 3000000000u <= DateTime.UtcNow.Ticks)
		{
			SaveDatabase();
		}
	}

	public void SaveDatabase()
	{
		try
		{
			DateTime now = DateTime.Now;
			foreach (int item in ToSaveUidList.ToList())
			{
				List<BaseDatabaseDataHelper> list = UidInstanceMap[item];
				Type baseType = typeof(BaseDatabaseDataHelper);
				foreach (Type type in from t in typeof(BaseDatabaseDataHelper).Assembly.GetTypes()
					where t.IsSubclassOf(baseType)
					select t)
				{
					BaseDatabaseDataHelper baseDatabaseDataHelper = list.Find((BaseDatabaseDataHelper x) => x.GetType() == type);
					if (baseDatabaseDataHelper != null)
					{
						typeof(DatabaseHelper).GetMethod("SaveDatabaseType")?.MakeGenericMethod(type).Invoke(null, new object[1] { baseDatabaseDataHelper });
					}
				}
			}
			double totalSeconds = (DateTime.Now - now).TotalSeconds;
			logger.Info(I18NManager.Translate("Server.ServerInfo.SaveDatabase", Math.Round(totalSeconds, 2).ToString(CultureInfo.InvariantCulture)));
			ToSaveUidList.Clear();
		}
		catch (Exception e)
		{
			logger.Error("An error occurred while saving the database", e);
		}
		LastSaveTick = DateTime.UtcNow.Ticks;
	}

	public static void SaveDatabaseType<T>(T instance) where T : class, new()
	{
		try
		{
			sqlSugarScope?.Updateable(instance).ExecuteCommand();
		}
		catch (Exception e)
		{
			logger.Error("An error occurred while saving the database", e);
		}
	}

	public void DeleteInstance<T>(T instance) where T : class, new()
	{
		sqlSugarScope?.Deleteable(instance).ExecuteCommand();
		UidInstanceMap[(instance as BaseDatabaseDataHelper).Uid].Remove(instance as BaseDatabaseDataHelper);
		ToSaveUidList.Remove((instance as BaseDatabaseDataHelper).Uid);
	}
}
