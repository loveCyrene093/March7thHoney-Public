using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AGJNFOCANCMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AGJNFOCANCMReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFBR0pORk9DQU5DTS5wcm90bxoRQUdFRFBJQkpQR0wucHJvdG8aEUJHS05F";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "RUhDR0VCLnByb3RvGhFIQ0lHT05HSkhFSi5wcm90byJ2CgtBR0pORk9DQU5D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "TRIhCgtCRE9GRkZIUEdMThgBIAMoCzIMLkFHRURQSUJKUEdMEiEKC0dDTUVP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "RENOR0lMGAIgAygLMgwuSENJR09OR0pIRUoSIQoLRkpERkZKSUVBS08YAyAD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "KAsyDC5CR0tORUVIQ0dFQkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[3]
		{
			AGEDPIBJPGLReflection.Descriptor,
			BGKNEEHCGEBReflection.Descriptor,
			HCIGONGJHEJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AGJNFOCANCM), AGJNFOCANCM.Parser, new string[3] { "BDOFFFHPGLN", "GCMEODCNGIL", "FJDFFJIEAKO" }, null, null, null, null)
		}));
	}
}
