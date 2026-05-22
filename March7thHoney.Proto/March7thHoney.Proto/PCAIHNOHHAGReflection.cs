using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PCAIHNOHHAGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PCAIHNOHHAGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQQ0FJSE5PSEhBRy5wcm90bxoRSkFNTEhPSEJJR0IucHJvdG8iaQoLUENB" + "SUhOT0hIQUcSEwoLRExGUERFSEROR0sYAiABKAgSIQoLRUNCQ09JREZQT04Y" + "BiABKAsyDC5KQU1MSE9IQklHQhIPCgdyZXRjb2RlGAkgASgNEhEKCWN1cl9p" + "bmRleBgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { JAMLHOHBIGBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PCAIHNOHHAG), PCAIHNOHHAG.Parser, new string[4] { "DLFPDEHDNGK", "ECBCOIDFPON", "Retcode", "CurIndex" }, null, null, null, null)
		}));
	}
}
