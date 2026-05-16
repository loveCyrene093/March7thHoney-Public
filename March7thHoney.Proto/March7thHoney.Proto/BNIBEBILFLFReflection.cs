using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BNIBEBILFLFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BNIBEBILFLFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCTklCRUJJTEZMRi5wcm90byI3CgtCTklCRUJJTEZMRhITCgtHTkJMT0hN" + "UEFDTBgJIAEoDRITCgtzd2l0Y2hfbGlzdBgOIAMoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BNIBEBILFLF), BNIBEBILFLF.Parser, new string[2] { "GNBLOHMPACL", "SwitchList" }, null, null, null, null)
		}));
	}
}
