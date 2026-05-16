using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DiceCombatModifyAvatarDiceCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DiceCombatModifyAvatarDiceCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVEaWNlQ29tYmF0TW9kaWZ5QXZhdGFyRGljZUNzUmVxLnByb3RvIkkKH0Rp" + "Y2VDb21iYXRNb2RpZnlBdmF0YXJEaWNlQ3NSZXESEwoLS05PUE5DRkJQRUcY" + "CiABKA0SEQoJYXZhdGFyX2lkGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DiceCombatModifyAvatarDiceCsReq), DiceCombatModifyAvatarDiceCsReq.Parser, new string[2] { "KNOPNCFBPEG", "AvatarId" }, null, null, null, null)
		}));
	}
}
