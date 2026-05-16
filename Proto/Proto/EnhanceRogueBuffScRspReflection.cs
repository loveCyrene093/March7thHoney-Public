using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnhanceRogueBuffScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnhanceRogueBuffScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChtFbmhhbmNlUm9ndWVCdWZmU2NSc3AucHJvdG8aEURBR0JDSklISkJNLnBy";
		buffer[1] = "b3RvGhFISkdGRElLRElITy5wcm90byKDAQoVRW5oYW5jZVJvZ3VlQnVmZlNj";
		buffer[2] = "UnNwEhMKC0RBSUtOS0FMS0NNGAYgASgIEiEKC0ZHTEpPS0lMS0hHGAwgASgL";
		buffer[3] = "MgwuREFHQkNKSUhKQk0SIQoLQUdGUEZPRFBPRkEYDSABKAsyDC5ISkdGRElL";
		buffer[4] = "RElITxIPCgdyZXRjb2RlGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[5] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			DAGBCJIHJBMReflection.Descriptor,
			HJGFDIKDIHOReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnhanceRogueBuffScRsp), EnhanceRogueBuffScRsp.Parser, new string[4] { "DAIKNKALKCM", "FGLJOKILKHG", "AGFPFODPOFA", "Retcode" }, null, null, null, null)
		}));
	}
}
