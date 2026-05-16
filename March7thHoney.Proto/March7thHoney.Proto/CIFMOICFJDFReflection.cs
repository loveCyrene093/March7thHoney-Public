using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CIFMOICFJDFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CIFMOICFJDFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDSUZNT0lDRkpERi5wcm90byJMCgtDSUZNT0lDRkpERhITCgtQS0JMT01F" + "SUZNRBgGIAEoDRITCgtJQ0lOSE1JS0pMSBgHIAEoDRITCgtQTUJBUEtKTUJO" + "TRgJIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CIFMOICFJDF), CIFMOICFJDF.Parser, new string[3] { "PKBLOMEIFMD", "ICINHMIKJLH", "PMBAPKJMBNM" }, null, null, null, null)
		}));
	}
}
