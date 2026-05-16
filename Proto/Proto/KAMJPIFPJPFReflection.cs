using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KAMJPIFPJPFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KAMJPIFPJPFReflection()
	{
		InlineArray11<string> buffer = default(InlineArray11<string>);
		buffer[0] = "ChFLQU1KUElGUEpQRi5wcm90bxoRQ0NIQk5KRUdKR0gucHJvdG8aEUVES0ZK";
		buffer[1] = "S0tDSUlELnByb3RvGhFLUEpGT0JPS0tOTy5wcm90bxoRTVBESElGS0dEQ0wu";
		buffer[2] = "cHJvdG8aEU9MTUhKSUhDTUJCLnByb3RvIrYCCgtLQU1KUElGUEpQRhITCgtO";
		buffer[3] = "TkFES0VKSE1ERRgBIAMoDRIhCgtFRUJMTElBQUFMThgCIAMoCzIMLkNDSEJO";
		buffer[4] = "SkVHSkdIEhMKC01FS01NQ0VCS1BPGAMgAygNEiEKC0NPRlBNRkhFT0dQGAQg";
		buffer[5] = "AygLMgwuT0xNSEpJSENNQkISEwoLS0RPR0JETlBJTVAYBSADKA0SIQoLTE5D";
		buffer[6] = "TExCRUlPT0YYByADKAsyDC5FREtGSktLQ0lJRBIhCgtPR0dQS1BQSEFPTxgI";
		buffer[7] = "IAMoCzIMLktQSkZPQk9LS05PEhMKC1BHT09ERUdDQkZPGAkgASgNEiEKC0JP";
		buffer[8] = "TElKSUVGR0dEGAogAygLMgwuTVBESElGS0dEQ0wSDwoHcmV0Y29kZRgMIAEo";
		buffer[9] = "DRITCgtCQU1LT05CT0FFSRgOIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[10] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[5]
		{
			CCHBNJEGJGHReflection.Descriptor,
			EDKFJKKCIIDReflection.Descriptor,
			KPJFOBOKKNOReflection.Descriptor,
			MPDHIFKGDCLReflection.Descriptor,
			OLMHJIHCMBBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KAMJPIFPJPF), KAMJPIFPJPF.Parser, new string[11]
			{
				"NNADKEJHMDE", "EEBLLIAAALN", "MEKMMCEBKPO", "COFPMFHEOGP", "KDOGBDNPIMP", "LNCLLBEIOOF", "OGGPKPPHAOO", "PGOODEGCBFO", "BOLIJIEFGGD", "Retcode",
				"BAMKONBOAEI"
			}, null, null, null, null)
		}));
	}
}
