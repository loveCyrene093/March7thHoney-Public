using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BCMMLADBEAMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BCMMLADBEAMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQ01NTEFEQkVBTS5wcm90bxoRR0dJTktFQkxPRUwucHJvdG8iMAoLQkNN" + "TUxBREJFQU0SIQoLTVBMSU5DQURPREsYDyADKAsyDC5HR0lOS0VCTE9FTEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { GGINKEBLOELReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BCMMLADBEAM), BCMMLADBEAM.Parser, new string[1] { "MPLINCADODK" }, null, null, null, null)
		}));
	}
}
