using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleEventPropertyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleEventPropertyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlCYXR0bGVFdmVudFByb3BlcnR5LnByb3RvGg9TcEJhckluZm8ucHJvdG8i" + "MQoTQmF0dGxlRXZlbnRQcm9wZXJ0eRIaCgZzcF9iYXIYAiABKAsyCi5TcEJh" + "ckluZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { SpBarInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BattleEventProperty), BattleEventProperty.Parser, new string[1] { "SpBar" }, null, null, null, null)
		}));
	}
}
