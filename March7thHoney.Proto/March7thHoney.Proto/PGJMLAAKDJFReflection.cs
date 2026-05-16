using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PGJMLAAKDJFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PGJMLAAKDJFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQR0pNTEFBS0RKRi5wcm90bxoPU2NlbmVJbmZvLnByb3RvIjkKC1BHSk1M" + "QUFLREpGEhkKBXNjZW5lGAkgASgLMgouU2NlbmVJbmZvEg8KB3JldGNvZGUY" + "CyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { SceneInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PGJMLAAKDJF), PGJMLAAKDJF.Parser, new string[2] { "Scene", "Retcode" }, null, null, null, null)
		}));
	}
}
