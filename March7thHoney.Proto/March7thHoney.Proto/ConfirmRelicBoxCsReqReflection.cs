using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ConfirmRelicBoxCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ConfirmRelicBoxCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpDb25maXJtUmVsaWNCb3hDc1JlcS5wcm90byIrChRDb25maXJtUmVsaWNC" + "b3hDc1JlcRITCgtOTEdGQUFGSUlJRRgIIAEoCEIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ConfirmRelicBoxCsReq), ConfirmRelicBoxCsReq.Parser, new string[1] { "NLGFAAFIIIE" }, null, null, null, null)
		}));
	}
}
