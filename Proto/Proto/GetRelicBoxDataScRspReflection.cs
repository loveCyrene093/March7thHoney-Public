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
		buffer[0] = "ChpHZXRSZWxpY0JveERhdGFTY1JzcC5wcm90bxoRR01PTkVISklLTUEucHJv";
		buffer[1] = "dG8aEUpISEJJT0pIRUdMLnByb3RvGhFOQklPRUtJTEhFTi5wcm90bxoRT01I";
		buffer[2] = "QU9CRktJS0UucHJvdG8aEVBHTEZBQ0hDR0NCLnByb3RvIvoBChRHZXRSZWxp";
		buffer[3] = "Y0JveERhdGFTY1JzcBIhCgtPSEVLREtKQ09GRBgCIAEoCzIMLlBHTEZBQ0hD";
		buffer[4] = "R0NCEiEKC0tLSEJBUEFCRkpDGAQgASgLMgwuR01PTkVISklLTUESDwoHcmV0";
		buffer[5] = "Y29kZRgFIAEoDRIhCgtJQUhJRUJDRlBDRBgGIAMoCzIMLk5CSU9FS0lMSEVO";
		buffer[6] = "EhMKC0dFSkFQQ0tPSElHGAcgASgNEiEKC0dQRUFGQUpHQ1BIGAwgASgLMgwu";
		buffer[7] = "T01IQU9CRktJS0USEwoLS0FJTUhPSkFBS1AYDiADKA0SGwoFc3RhdGUYDyAB";
		buffer[8] = "KA4yDC5KSEhCSU9KSEVHTEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[9] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[5]
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
