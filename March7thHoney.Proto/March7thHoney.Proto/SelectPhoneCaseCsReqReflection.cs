using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SelectPhoneCaseCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SelectPhoneCaseCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTZWxlY3RQaG9uZUNhc2VDc1JlcS5wcm90byItChRTZWxlY3RQaG9uZUNh" + "c2VDc1JlcRIVCg1waG9uZV9jYXNlX2lkGAggASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SelectPhoneCaseCsReq), SelectPhoneCaseCsReq.Parser, new string[1] { "PhoneCaseId" }, null, null, null, null)
		}));
	}
}
