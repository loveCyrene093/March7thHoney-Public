using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HandleFriendCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HandleFriendCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdIYW5kbGVGcmllbmRDc1JlcS5wcm90byIzChFIYW5kbGVGcmllbmRDc1Jl" + "cRIRCglpc19hY2NlcHQYCCABKAgSCwoDdWlkGAwgASgNQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HandleFriendCsReq), HandleFriendCsReq.Parser, new string[2] { "IsAccept", "Uid" }, null, null, null, null)
		}));
	}
}
