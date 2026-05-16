using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MAKMDAIHDMNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MAKMDAIHDMNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNQUtNREFJSERNTi5wcm90byI3CgtNQUtNREFJSERNThITCgtPRkhDTkdI" + "SkZISRgFIAEoDRITCgtBQ1BCT0hDSEhLRxgPIAMoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MAKMDAIHDMN), MAKMDAIHDMN.Parser, new string[2] { "OFHCNGHJFHI", "ACPBOHCHHKG" }, null, null, null, null)
		}));
	}
}
