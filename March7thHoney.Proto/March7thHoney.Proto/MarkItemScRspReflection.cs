using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MarkItemScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MarkItemScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNNYXJrSXRlbVNjUnNwLnByb3RvIkYKDU1hcmtJdGVtU2NSc3ASDwoHaXRl" + "bV9pZBgBIAEoDRIPCgdyZXRjb2RlGAQgASgNEhMKC0VLTENGQklQR0dPGAkg" + "ASgIQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MarkItemScRsp), MarkItemScRsp.Parser, new string[3] { "ItemId", "Retcode", "EKLCFBIPGGO" }, null, null, null, null)
		}));
	}
}
