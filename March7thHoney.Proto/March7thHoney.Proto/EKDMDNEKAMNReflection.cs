using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EKDMDNEKAMNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EKDMDNEKAMNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFS0RNRE5FS0FNTi5wcm90byIiCgtFS0RNRE5FS0FNThITCgtJSU1ORk1M" + "TENNTBgFIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EKDMDNEKAMN), EKDMDNEKAMN.Parser, new string[1] { "IIMNFMLLCML" }, null, null, null, null)
		}));
	}
}
