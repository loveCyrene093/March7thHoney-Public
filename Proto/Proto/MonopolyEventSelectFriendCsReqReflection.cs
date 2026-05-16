using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyEventSelectFriendCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyEventSelectFriendCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRNb25vcG9seUV2ZW50U2VsZWN0RnJpZW5kQ3NSZXEucHJvdG8iSgoeTW9u" + "b3BvbHlFdmVudFNlbGVjdEZyaWVuZENzUmVxEhMKC0xJUEhEUExHTU5QGAQg" + "ASgNEhMKC0xESktFRVBOSkRDGAogASgIQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyEventSelectFriendCsReq), MonopolyEventSelectFriendCsReq.Parser, new string[2] { "LIPHDPLGMNP", "LDJKEEPNJDC" }, null, null, null, null)
		}));
	}
}
