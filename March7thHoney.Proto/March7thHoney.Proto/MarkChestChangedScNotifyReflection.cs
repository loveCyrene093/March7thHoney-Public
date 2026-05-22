using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MarkChestChangedScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MarkChestChangedScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5NYXJrQ2hlc3RDaGFuZ2VkU2NOb3RpZnkucHJvdG8aF01hcmtDaGVzdEZ1" + "bmNJbmZvLnByb3RvIkwKGE1hcmtDaGVzdENoYW5nZWRTY05vdGlmeRIwChRt" + "YXJrX2NoZXN0X2Z1bmNfaW5mbxgGIAMoCzISLk1hcmtDaGVzdEZ1bmNJbmZv" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { MarkChestFuncInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MarkChestChangedScNotify), MarkChestChangedScNotify.Parser, new string[1] { "MarkChestFuncInfo" }, null, null, null, null)
		}));
	}
}
