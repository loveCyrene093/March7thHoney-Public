using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HLPMDOPHNOGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HLPMDOPHNOGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFITFBNRE9QSE5PRy5wcm90byIxCgtITFBNRE9QSE5PRxIPCgdyZXRjb2Rl" + "GAMgASgNEhEKCXVuaXF1ZV9pZBgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HLPMDOPHNOG), HLPMDOPHNOG.Parser, new string[2] { "Retcode", "UniqueId" }, null, null, null, null)
		}));
	}
}
