using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ReviveRogueAvatarCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ReviveRogueAvatarCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxSZXZpdmVSb2d1ZUF2YXRhckNzUmVxLnByb3RvIlgKFlJldml2ZVJvZ3Vl" + "QXZhdGFyQ3NSZXESIQoZaW50ZXJhY3RlZF9wcm9wX2VudGl0eV9pZBgEIAEo" + "DRIbChNiYXNlX2F2YXRhcl9pZF9saXN0GAogAygNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ReviveRogueAvatarCsReq), ReviveRogueAvatarCsReq.Parser, new string[2] { "InteractedPropEntityId", "BaseAvatarIdList" }, null, null, null, null)
		}));
	}
}
