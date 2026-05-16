using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CNMBIPOPOFHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CNMBIPOPOFHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDTk1CSVBPUE9GSC5wcm90byI3CgtDTk1CSVBPUE9GSBITCgtGUEZJSEhC" + "TkJBThgDIAEoDRITCgtHRE5QSkxMT0hFRRgNIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CNMBIPOPOFH), CNMBIPOPOFH.Parser, new string[2] { "FPFIHHBNBAN", "GDNPJLLOHEE" }, null, null, null, null)
		}));
	}
}
