using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LCEEJNOPNIBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LCEEJNOPNIBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMQ0VFSk5PUE5JQi5wcm90byI3CgtMQ0VFSk5PUE5JQhITCgtJR0pLTENE" + "Q0xJShgFIAEoDRITCgtOTUxKSElHRktHQxgJIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LCEEJNOPNIB), LCEEJNOPNIB.Parser, new string[2] { "IGJKLCDCLIJ", "NMLJHIGFKGC" }, null, null, null, null)
		}));
	}
}
