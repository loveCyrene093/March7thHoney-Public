using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PHGCFPNCDBEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PHGCFPNCDBEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQSEdDRlBOQ0RCRS5wcm90byIxCgtQSEdDRlBOQ0RCRRIPCgdyZXRjb2Rl" + "GAwgASgNEhEKCXVuaXF1ZV9pZBgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PHGCFPNCDBE), PHGCFPNCDBE.Parser, new string[2] { "Retcode", "UniqueId" }, null, null, null, null)
		}));
	}
}
