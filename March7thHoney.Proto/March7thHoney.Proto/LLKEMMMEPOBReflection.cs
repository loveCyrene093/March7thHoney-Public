using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LLKEMMMEPOBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LLKEMMMEPOBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMTEtFTU1NRVBPQi5wcm90byI3CgtMTEtFTU1NRVBPQhITCgtFSExJRkhQ" + "SUxQRxgKIAEoDRITCgtGSUhNSEpIR0hPRxgLIAEoA0IWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LLKEMMMEPOB), LLKEMMMEPOB.Parser, new string[2] { "EHLIFHPILPG", "FIHMHJHGHOG" }, null, null, null, null)
		}));
	}
}
