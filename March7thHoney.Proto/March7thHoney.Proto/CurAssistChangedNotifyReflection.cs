using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CurAssistChangedNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CurAssistChangedNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxDdXJBc3Npc3RDaGFuZ2VkTm90aWZ5LnByb3RvGhZQbGF5ZXJBc3Npc3RJ" + "bmZvLnByb3RvIkAKFkN1ckFzc2lzdENoYW5nZWROb3RpZnkSJgoLSUxQS1BC" + "T0tNRU4YDSABKAsyES5QbGF5ZXJBc3Npc3RJbmZvQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { PlayerAssistInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CurAssistChangedNotify), CurAssistChangedNotify.Parser, new string[1] { "ILPKPBOKMEN" }, null, null, null, null)
		}));
	}
}
