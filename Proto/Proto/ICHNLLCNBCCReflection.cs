using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ICHNLLCNBCCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ICHNLLCNBCCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJQ0hOTExDTkJDQy5wcm90bxoRTlBMRURIRk1GRE0ucHJvdG8iWgoLSUNI" + "TkxMQ05CQ0MSIQoLQUZFSkFDTUxPTEgYASADKAsyDC5OUExFREhGTUZETRIT" + "CgtHSkdBR0ZFSkFCQxgCIAEoDRITCgtESExHQ0VHT05JQhgDIAEoA0IWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { NPLEDHFMFDMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ICHNLLCNBCC), ICHNLLCNBCC.Parser, new string[3] { "AFEJACMLOLH", "GJGAGFEJABC", "DHLGCEGONIB" }, null, null, null, null)
		}));
	}
}
