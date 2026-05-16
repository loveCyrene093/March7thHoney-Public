using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PBMHMEADLECReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PBMHMEADLECReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFQQk1ITUVBRExFQy5wcm90bxoRQURJUEFLQ0ZNT0YucHJvdG8aEUlFREVN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "RktCSEZMLnByb3RvGhFPSUxCRklLSE5QSy5wcm90byJ2CgtQQk1ITUVBRExF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "QxIhCgtJR0NKTkNLRU9ERxgCIAMoCzIMLklFREVNRktCSEZMEiEKC0hPUExE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "SkpNR0xNGAkgAygLMgwuQURJUEFLQ0ZNT0YSIQoLQktHQkVETUdKSkQYDiAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "KAsyDC5PSUxCRklLSE5QS0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[3]
		{
			ADIPAKCFMOFReflection.Descriptor,
			IEDEMFKBHFLReflection.Descriptor,
			OILBFIKHNPKReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PBMHMEADLEC), PBMHMEADLEC.Parser, new string[3] { "IGCJNCKEODG", "HOPLDJJMGLM", "BKGBEDMGJJD" }, null, null, null, null)
		}));
	}
}
