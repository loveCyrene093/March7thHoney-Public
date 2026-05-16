using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MPKGLGCLAIDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MPKGLGCLAIDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNUEtHTEdDTEFJRC5wcm90bxoRRkNMTkJITUFJR0MucHJvdG8aEUpMUEdJ" + "R1BDSUFHLnByb3RvIlMKC01QS0dMR0NMQUlEEiEKC1BBTUdITURKQUpBGAUg" + "ASgLMgwuSkxQR0lHUENJQUcSIQoLTEtKT0VPREFPTU0YCiADKAsyDC5GQ0xO" + "QkhNQUlHQ0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[2]
		{
			FCLNBHMAIGCReflection.Descriptor,
			JLPGIGPCIAGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MPKGLGCLAID), MPKGLGCLAID.Parser, new string[2] { "PAMGHMDJAJA", "LKJOEODAOMM" }, null, null, null, null)
		}));
	}
}
