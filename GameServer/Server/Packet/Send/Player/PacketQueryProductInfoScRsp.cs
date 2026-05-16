using System;
using System.Collections.Generic;
using System.Reflection;
using Google.Protobuf.Reflection;
using March7thHoney.Data;
using March7thHoney.Data.Custom;
using March7thHoney.Kcp;
using March7thHoney.Proto;
using March7thHoney.Util;
using Newtonsoft.Json.Linq;

namespace March7thHoney.GameServer.Server.Packet.Send.Player;

public class PacketQueryProductInfoScRsp : BasePacket
{
	public PacketQueryProductInfoScRsp()
		: base(5)
	{
		QueryProductInfoScRsp queryProductInfoScRsp = new QueryProductInfoScRsp
		{
			BAMOOGPNJEH = 5u,
			IFKKKLCFOBK = 5u,
			MonthCardOutDateTime = (ulong)(ConfigManager.Config.ServerOption.EnableMonthCard ? (March7thHoney.Util.Extensions.GetUnixSec() + 8640000) : 0)
		};
		foreach (Product item in BuildProducts(GameData.QueryProductInfoConfig, ConfigManager.Config.ServerOption.EnableMonthCard))
		{
			queryProductInfoScRsp.ProductList.Add(item);
		}
		SetData(queryProductInfoScRsp);
	}

	private static List<Product> BuildProducts(QueryProductInfoConfig config, bool enableMonthCard)
	{
		List<Product> list = new List<Product>();
		foreach (QueryProductInfoItem product in config.ProductList)
		{
			ProductGiftType productGiftType = ParseGiftType(product.GiftType);
			if (enableMonthCard || productGiftType != ProductGiftType.ProductGiftMonthCard)
			{
				list.Add(new Product
				{
					JCJGHCOEOOJ = product.JCJGHCOEOOJ,
					MEMNCJLKAEE = product.MEMNCJLKAEE,
					EEFHEBKHKAB = product.EEFHEBKHKAB,
					BeginTime = product.BeginTime,
					EndTime = product.EndTime,
					GiftType = productGiftType,
					PriceTier = (product.PriceTier ?? ""),
					ProductId = (product.ProductId ?? ""),
					DoubleReward = product.DoubleReward
				});
			}
		}
		return list;
	}

	private static ProductGiftType ParseGiftType(object raw)
	{
		if (raw == null)
		{
			return ProductGiftType.ProductGiftNone;
		}
		if (raw is long num)
		{
			return (ProductGiftType)num;
		}
		if (raw is int)
		{
			return (ProductGiftType)(int)raw;
		}
		if (raw is JValue jValue)
		{
			if (jValue.Type == JTokenType.Integer)
			{
				return (ProductGiftType)jValue.Value<long>();
			}
			string value = jValue.Value<string>();
			if (!string.IsNullOrWhiteSpace(value))
			{
				return ParseGiftTypeFromString(value);
			}
			return ProductGiftType.ProductGiftNone;
		}
		return ParseGiftTypeFromString(raw.ToString() ?? "");
	}

	private static ProductGiftType ParseGiftTypeFromString(string value)
	{
		if (long.TryParse(value, out var result))
		{
			return (ProductGiftType)result;
		}
		if (Enum.TryParse<ProductGiftType>(value, ignoreCase: true, out var result2))
		{
			return result2;
		}
		FieldInfo[] fields = typeof(ProductGiftType).GetFields(BindingFlags.Static | BindingFlags.Public);
		foreach (FieldInfo fieldInfo in fields)
		{
			OriginalNameAttribute customAttribute = fieldInfo.GetCustomAttribute<OriginalNameAttribute>();
			if (customAttribute != null && string.Equals(customAttribute.Name, value, StringComparison.OrdinalIgnoreCase))
			{
				return (ProductGiftType)fieldInfo.GetValue(null);
			}
		}
		return ProductGiftType.ProductGiftNone;
	}
}
