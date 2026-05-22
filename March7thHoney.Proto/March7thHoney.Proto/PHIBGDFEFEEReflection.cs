using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PHIBGDFEFEEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PHIBGDFEFEEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQSElCR0RGRUZFRS5wcm90byI9CgtQSElCR0RGRUZFRRIVCg1zdG9wX2Vu" + "ZF90aW1lGAIgASgDEhcKD3N0b3BfYmVnaW5fdGltZRgKIAEoA0IWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PHIBGDFEFEE), PHIBGDFEFEE.Parser, new string[2] { "StopEndTime", "StopBeginTime" }, null, null, null, null)
		}));
	}
}
