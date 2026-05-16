using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OEOJCBLAMGPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OEOJCBLAMGPReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFPRU9KQ0JMQU1HUC5wcm90bxogTGltYW9OZXdzT2ZmaWNlU3VydmV5U3Rh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dGUucHJvdG8iaQoLT0VPSkNCTEFNR1ASEwoLSUVCRklJUEJBREoYBCADKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "EwoLT1BGRUtBS0ZOSk0YBiADKA0SMAoLQU5BSExISkREREMYDSADKA4yGy5M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "aW1hb05ld3NPZmZpY2VTdXJ2ZXlTdGF0ZUIWqgITTWFyY2g3dGhIb25leS5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { LimaoNewsOfficeSurveyStateReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OEOJCBLAMGP), OEOJCBLAMGP.Parser, new string[3] { "IEBFIIPBADJ", "OPFEKAKFNJM", "ANAHLHJDDDC" }, null, null, null, null)
		}));
	}
}
