using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeMailAttachmentCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeMailAttachmentCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1UYWtlTWFpbEF0dGFjaG1lbnRDc1JlcS5wcm90byJLChdUYWtlTWFpbEF0" + "dGFjaG1lbnRDc1JlcRIaChJvcHRpb25hbF9yZXdhcmRfaWQYDSABKA0SFAoM" + "bWFpbF9pZF9saXN0GA8gAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeMailAttachmentCsReq), TakeMailAttachmentCsReq.Parser, new string[2] { "OptionalRewardId", "MailIdList" }, null, null, null, null)
		}));
	}
}
