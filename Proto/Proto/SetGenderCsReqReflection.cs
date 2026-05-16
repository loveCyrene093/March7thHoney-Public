using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetGenderCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetGenderCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRTZXRHZW5kZXJDc1JlcS5wcm90bxoMR2VuZGVyLnByb3RvIikKDlNldEdl" + "bmRlckNzUmVxEhcKBmdlbmRlchgFIAEoDjIHLkdlbmRlckIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { GenderReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetGenderCsReq), SetGenderCsReq.Parser, new string[1] { "Gender" }, null, null, null, null)
		}));
	}
}
