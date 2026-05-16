using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KAAEBONPKEPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KAAEBONPKEPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLQUFFQk9OUEtFUC5wcm90byJhCgtLQUFFQk9OUEtFUBITCgtKQ0NPT0FF" + "UEdFRBgGIAEoDRITCgtFTktCRkdCQkhLUBgHIAEoCBITCgtOSEdIRUJKQ0ND" + "TxgNIAEoDRITCgtDT09PRkZLSURNQxgOIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KAAEBONPKEP), KAAEBONPKEP.Parser, new string[4] { "JCCOOAEPGED", "ENKBFGBBHKP", "NHGHEBJCCCO", "COOOFFKIDMC" }, null, null, null, null)
		}));
	}
}
