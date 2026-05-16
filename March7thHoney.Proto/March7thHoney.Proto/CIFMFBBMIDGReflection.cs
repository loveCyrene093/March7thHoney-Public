using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CIFMFBBMIDGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CIFMFBBMIDGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDSUZNRkJCTUlERy5wcm90bxoRSExQTURKRUtEQ04ucHJvdG8iMAoLQ0lG" + "TUZCQk1JREcSIQoLSFBMSUJPR01DTkoYDCADKAsyDC5ITFBNREpFS0RDTkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { HLPMDJEKDCNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CIFMFBBMIDG), CIFMFBBMIDG.Parser, new string[1] { "HPLIBOGMCNJ" }, null, null, null, null)
		}));
	}
}
