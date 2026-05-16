using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterAdventureScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterAdventureScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlFbnRlckFkdmVudHVyZVNjUnNwLnByb3RvGg9TY2VuZUluZm8ucHJvdG8i" + "QQoTRW50ZXJBZHZlbnR1cmVTY1JzcBIZCgVzY2VuZRgGIAEoCzIKLlNjZW5l" + "SW5mbxIPCgdyZXRjb2RlGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[1] { SceneInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterAdventureScRsp), EnterAdventureScRsp.Parser, new string[2] { "Scene", "Retcode" }, null, null, null, null)
		}));
	}
}
