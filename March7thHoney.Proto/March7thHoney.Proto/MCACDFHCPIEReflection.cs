using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MCACDFHCPIEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MCACDFHCPIEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNQ0FDREZIQ1BJRS5wcm90bxoRTE1JRkpCTEpGSFAucHJvdG8iMAoLTUNB" + "Q0RGSENQSUUSIQoLSEFIS0tFREtNQ0EYAiADKAsyDC5MTUlGSkJMSkZIUEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { LMIFJBLJFHPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MCACDFHCPIE), MCACDFHCPIE.Parser, new string[1] { "HAHKKEDKMCA" }, null, null, null, null)
		}));
	}
}
