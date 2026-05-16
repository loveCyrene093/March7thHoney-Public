using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EFBDKEHLCDFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EFBDKEHLCDFReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFFRkJES0VITENERi5wcm90bxoRQ0lQQkJQSEdFS0oucHJvdG8aEUNLSERO";
		buffer[1] = "SkdNRUpDLnByb3RvGhFLQUNPT0ZJS0hPRy5wcm90byKLAQoLRUZCREtFSExD";
		buffer[2] = "REYSIQoLREVQTExKUEtLR0QYAiADKAsyDC5DS0hETkpHTUVKQxIhCgtCSEFC";
		buffer[3] = "R0FQSkFIRhgKIAMoCzIMLkNJUEJCUEhHRUtKEiEKC0NESUZHSUdGTEVMGAsg";
		buffer[4] = "AygLMgwuS0FDT09GSUtIT0cSEwoLTkFMTElDTUVFREkYDiABKA1CFqoCE01h";
		buffer[5] = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			CIPBBPHGEKJReflection.Descriptor,
			CKHDNJGMEJCReflection.Descriptor,
			KACOOFIKHOGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EFBDKEHLCDF), EFBDKEHLCDF.Parser, new string[4] { "DEPLLJPKKGD", "BHABGAPJAHF", "CDIFGIGFLEL", "NALLICMEEDI" }, null, null, null, null)
		}));
	}
}
