using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ServerSimulateBattleFinishScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ServerSimulateBattleFinishScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihTZXJ2ZXJTaW11bGF0ZUJhdHRsZUZpbmlzaFNjTm90aWZ5LnByb3RvIiQK" + "IlNlcnZlclNpbXVsYXRlQmF0dGxlRmluaXNoU2NOb3RpZnlCFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ServerSimulateBattleFinishScNotify), ServerSimulateBattleFinishScNotify.Parser, null, null, null, null, null)
		}));
	}
}
