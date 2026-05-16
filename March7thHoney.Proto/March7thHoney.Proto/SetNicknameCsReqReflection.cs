using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetNicknameCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetNicknameCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZTZXROaWNrbmFtZUNzUmVxLnByb3RvIjcKEFNldE5pY2tuYW1lQ3NSZXES" + "EAoIbmlja25hbWUYAyABKAkSEQoJaXNfbW9kaWZ5GAwgASgIQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetNicknameCsReq), SetNicknameCsReq.Parser, new string[2] { "Nickname", "IsModify" }, null, null, null, null)
		}));
	}
}
