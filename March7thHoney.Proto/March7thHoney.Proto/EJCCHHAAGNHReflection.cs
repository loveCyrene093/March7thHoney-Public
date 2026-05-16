using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EJCCHHAAGNHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EJCCHHAAGNHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFSkNDSEhBQUdOSC5wcm90bxoQTGluZXVwSW5mby5wcm90bxoPU2NlbmVJ" + "bmZvLnByb3RvIkUKC0VKQ0NISEFBR05IEhkKBXNjZW5lGAUgASgLMgouU2Nl" + "bmVJbmZvEhsKBmxpbmV1cBgLIAEoCzILLkxpbmV1cEluZm9CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[2]
		{
			LineupInfoReflection.Descriptor,
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EJCCHHAAGNH), EJCCHHAAGNH.Parser, new string[2] { "Scene", "Lineup" }, null, null, null, null)
		}));
	}
}
