using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneReviveAfterRebattleCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneReviveAfterRebattleCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNTY2VuZVJldml2ZUFmdGVyUmViYXR0bGVDc1JlcS5wcm90bxoSUmViYXR0" + "bGVUeXBlLnByb3RvIkMKHVNjZW5lUmV2aXZlQWZ0ZXJSZWJhdHRsZUNzUmVx" + "EiIKC01HQUJNQ0JPSE1LGAkgASgOMg0uUmViYXR0bGVUeXBlQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { RebattleTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneReviveAfterRebattleCsReq), SceneReviveAfterRebattleCsReq.Parser, new string[1] { "MGABMCBOHMK" }, null, null, null, null)
		}));
	}
}
