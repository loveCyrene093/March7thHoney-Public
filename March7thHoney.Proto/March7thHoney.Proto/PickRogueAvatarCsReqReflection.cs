using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PickRogueAvatarCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PickRogueAvatarCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpQaWNrUm9ndWVBdmF0YXJDc1JlcS5wcm90byJLChRQaWNrUm9ndWVBdmF0" + "YXJDc1JlcRIbChNiYXNlX2F2YXRhcl9pZF9saXN0GAMgAygNEhYKDnByb3Bf" + "ZW50aXR5X2lkGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PickRogueAvatarCsReq), PickRogueAvatarCsReq.Parser, new string[2] { "BaseAvatarIdList", "PropEntityId" }, null, null, null, null)
		}));
	}
}
