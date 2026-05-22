using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DPBEGBNICPGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DPBEGBNICPGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFEUEJFR0JOSUNQRy5wcm90bxoOUGlsZUl0ZW0ucHJvdG8iTQoLRFBCRUdC" + "TklDUEcSHgoLQ0ZFSFBIQUpJT0QYBSABKAsyCS5QaWxlSXRlbRIeCgtIS0lC" + "SlBGS0xMTxgOIAMoCzIJLlBpbGVJdGVtQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[1] { PileItemReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DPBEGBNICPG), DPBEGBNICPG.Parser, new string[2] { "CFEHPHAJIOD", "HKIBJPFKLLO" }, null, null, null, null)
		}));
	}
}
