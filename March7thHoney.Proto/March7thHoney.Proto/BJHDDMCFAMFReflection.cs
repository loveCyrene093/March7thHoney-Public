using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BJHDDMCFAMFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BJHDDMCFAMFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCSkhERE1DRkFNRi5wcm90bxoRSEFCSkhITFBMRkcucHJvdG8aEU9QTkNE" + "SEdORURGLnByb3RvIlMKC0JKSERETUNGQU1GEiEKC05QRENPSkNBSFBFGAUg" + "ASgLMgwuT1BOQ0RIR05FREYSIQoLTE9GT0RHTkpKRksYCiABKAsyDC5IQUJK" + "SEhMUExGR0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[2]
		{
			HABJHHLPLFGReflection.Descriptor,
			OPNCDHGNEDFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BJHDDMCFAMF), BJHDDMCFAMF.Parser, new string[2] { "NPDCOJCAHPE", "LOFODGNJJFK" }, null, null, null, null)
		}));
	}
}
