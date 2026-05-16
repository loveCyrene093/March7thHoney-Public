using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GGPBFLBEAIFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GGPBFLBEAIFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHR1BCRkxCRUFJRi5wcm90bxoRQkhEREtJTEFKQ0oucHJvdG8iMAoLR0dQ" + "QkZMQkVBSUYSIQoLUE5GR0dCUEVDTkQYASADKAsyDC5CSERES0lMQUpDSkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { BHDDKILAJCJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GGPBFLBEAIF), GGPBFLBEAIF.Parser, new string[1] { "PNFGGBPECND" }, null, null, null, null)
		}));
	}
}
