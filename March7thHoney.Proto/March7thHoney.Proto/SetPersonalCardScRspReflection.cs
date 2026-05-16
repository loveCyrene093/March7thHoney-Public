using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetPersonalCardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetPersonalCardScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTZXRQZXJzb25hbENhcmRTY1JzcC5wcm90byJJChRTZXRQZXJzb25hbENh" + "cmRTY1JzcBIgChhjdXJyZW50X3BlcnNvbmFsX2NhcmRfaWQYCiABKA0SDwoH" + "cmV0Y29kZRgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetPersonalCardScRsp), SetPersonalCardScRsp.Parser, new string[2] { "CurrentPersonalCardId", "Retcode" }, null, null, null, null)
		}));
	}
}
