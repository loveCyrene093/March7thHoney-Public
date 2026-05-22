using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LineupAvatarDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LineupAvatarDataReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZMaW5ldXBBdmF0YXJEYXRhLnByb3RvGhBBdmF0YXJUeXBlLnByb3RvIkwK" + "EExpbmV1cEF2YXRhckRhdGESCgoCaHAYAiABKA0SCgoCaWQYBiABKA0SIAoL" + "YXZhdGFyX3R5cGUYCSABKA4yCy5BdmF0YXJUeXBlQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LineupAvatarData), LineupAvatarData.Parser, new string[3] { "Hp", "Id", "AvatarType" }, null, null, null, null)
		}));
	}
}
