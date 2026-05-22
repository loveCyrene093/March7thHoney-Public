using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OGPPBIDINBIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OGPPBIDINBIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPR1BQQklESU5CSS5wcm90bxoRSUZDQkNCTEZBTE0ucHJvdG8iMAoLT0dQ" + "UEJJRElOQkkSIQoLT1BPR0VNQURMRUkYCSABKAsyDC5JRkNCQ0JMRkFMTUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { IFCBCBLFALMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OGPPBIDINBI), OGPPBIDINBI.Parser, new string[1] { "OPOGEMADLEI" }, null, null, null, null)
		}));
	}
}
