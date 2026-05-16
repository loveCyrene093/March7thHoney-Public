using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeMailAttachmentScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeMailAttachmentScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "Ch1UYWtlTWFpbEF0dGFjaG1lbnRTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJv";
		buffer[1] = "dG8aEUtFT0FJSEFDSEtHLnByb3RvIooBChdUYWtlTWFpbEF0dGFjaG1lbnRT";
		buffer[2] = "Y1JzcBIPCgdyZXRjb2RlGAEgASgNEiQKDmZhaWxfbWFpbF9saXN0GAYgAygL";
		buffer[3] = "MgwuS0VPQUlIQUNIS0cSHQoKYXR0YWNobWVudBgHIAEoCzIJLkl0ZW1MaXN0";
		buffer[4] = "EhkKEXN1Y2NfbWFpbF9pZF9saXN0GAogAygNQhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[5] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ItemListReflection.Descriptor,
			KEOAIHACHKGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeMailAttachmentScRsp), TakeMailAttachmentScRsp.Parser, new string[4] { "Retcode", "FailMailList", "Attachment", "SuccMailIdList" }, null, null, null, null)
		}));
	}
}
