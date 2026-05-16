using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetFriendRemarkNameScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetFriendRemarkNameScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5TZXRGcmllbmRSZW1hcmtOYW1lU2NSc3AucHJvdG8iTQoYU2V0RnJpZW5k" + "UmVtYXJrTmFtZVNjUnNwEgsKA3VpZBgCIAEoDRITCgtyZW1hcmtfbmFtZRgL" + "IAEoCRIPCgdyZXRjb2RlGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetFriendRemarkNameScRsp), SetFriendRemarkNameScRsp.Parser, new string[3] { "Uid", "RemarkName", "Retcode" }, null, null, null, null)
		}));
	}
}
