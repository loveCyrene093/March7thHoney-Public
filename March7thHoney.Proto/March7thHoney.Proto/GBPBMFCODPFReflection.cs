using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GBPBMFCODPFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GBPBMFCODPFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHQlBCTUZDT0RQRi5wcm90byI3CgtHQlBCTUZDT0RQRhITCgtPTUVDSkdH" + "TEFHRBgHIAMoDRITCgtEQVBJTlBNTUZMQhgIIAMoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GBPBMFCODPF), GBPBMFCODPF.Parser, new string[2] { "OMECJGGLAGD", "DAPINPMMFLB" }, null, null, null, null)
		}));
	}
}
