using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CEDGNIIEIMCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CEDGNIIEIMCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDRURHTklJRUlNQy5wcm90byJ2CgtDRURHTklJRUlNQxITCgtQQ0dKRklG" + "TEtPTxgBIAEoDRITCgtKTktCS09DSkNLShgGIAEoCRITCgtGRkVBQ1BERkFK" + "SBgHIAEoCRITCgtHQk1CTUZGTktFSBgIIAEoDRITCgtDRU9GRE1DSkFQShgJ" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CEDGNIIEIMC), CEDGNIIEIMC.Parser, new string[5] { "PCGJFIFLKOO", "JNKBKOCJCKJ", "FFEACPDFAJH", "GBMBMFFNKEH", "CEOFDMCJAPJ" }, null, null, null, null)
		}));
	}
}
