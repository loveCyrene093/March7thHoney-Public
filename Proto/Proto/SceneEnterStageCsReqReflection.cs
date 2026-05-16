using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneEnterStageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneEnterStageCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTY2VuZUVudGVyU3RhZ2VDc1JlcS5wcm90bxoSUmViYXR0bGVUeXBlLnBy" + "b3RvImEKFFNjZW5lRW50ZXJTdGFnZUNzUmVxEhAKCGV2ZW50X2lkGAQgASgN" + "EiIKC01HQUJNQ0JPSE1LGAYgASgOMg0uUmViYXR0bGVUeXBlEhMKC0ZEQkdP" + "SkNLTEJIGAggASgIQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { RebattleTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneEnterStageCsReq), SceneEnterStageCsReq.Parser, new string[3] { "EventId", "MGABMCBOHMK", "FDBGOJCKLBH" }, null, null, null, null)
		}));
	}
}
