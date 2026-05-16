using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRelicBoxDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRelicBoxDataScRspReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 0) = "ChpHZXRSZWxpY0JveERhdGFTY1JzcC5wcm90bxoRR01PTkVISklLTUEucHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 1) = "dG8aEUpISEJJT0pIRUdMLnByb3RvGhFOQklPRUtJTEhFTi5wcm90bxoRT01I";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 2) = "QU9CRktJS0UucHJvdG8aEVBHTEZBQ0hDR0NCLnByb3RvIvoBChRHZXRSZWxp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 3) = "Y0JveERhdGFTY1JzcBIhCgtPSEVLREtKQ09GRBgCIAEoCzIMLlBHTEZBQ0hD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 4) = "R0NCEiEKC0tLSEJBUEFCRkpDGAQgASgLMgwuR01PTkVISklLTUESDwoHcmV0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 5) = "Y29kZRgFIAEoDRIhCgtJQUhJRUJDRlBDRBgGIAMoCzIMLk5CSU9FS0lMSEVO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 6) = "EhMKC0dFSkFQQ0tPSElHGAcgASgNEiEKC0dQRUFGQUpHQ1BIGAwgASgLMgwu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 7) = "T01IQU9CRktJS0USEwoLS0FJTUhPSkFBS1AYDiADKA0SGwoFc3RhdGUYDyAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 8) = "KA4yDC5KSEhCSU9KSEVHTEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 9) = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray10<string>, string>(in buffer, 10))), new FileDescriptor[5]
		{
			GMONEHJIKMAReflection.Descriptor,
			JHHBIOJHEGLReflection.Descriptor,
			NBIOEKILHENReflection.Descriptor,
			OMHAOBFKIKEReflection.Descriptor,
			PGLFACHCGCBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRelicBoxDataScRsp), GetRelicBoxDataScRsp.Parser, new string[8] { "OHEKDKJCOFD", "KKHBAPABFJC", "Retcode", "IAHIEBCFPCD", "GEJAPCKOHIG", "GPEAFAJGCPH", "KAIMHOJAAKP", "State" }, null, null, null, null)
		}));
	}
}
