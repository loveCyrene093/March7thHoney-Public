using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetSceneMapInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetSceneMapInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHZXRTY2VuZU1hcEluZm9Dc1JlcS5wcm90bxoVU2NlbmVJZGVudGlmaWVy" + "LnByb3RvIkMKFEdldFNjZW5lTWFwSW5mb0NzUmVxEisKEXNjZW5lX2lkZW50" + "aWZpZXJzGAIgAygLMhAuU2NlbmVJZGVudGlmaWVyQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { SceneIdentifierReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetSceneMapInfoCsReq), GetSceneMapInfoCsReq.Parser, new string[1] { "SceneIdentifiers" }, null, null, null, null)
		}));
	}
}
