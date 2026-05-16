using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MFLDHBJNEOOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MFLDHBJNEOOReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFNRkxESEJKTkVPTy5wcm90bxoRQ0tQRUlIT0xBRFAucHJvdG8aEUhLR0RH";
		buffer[1] = "QUpISlBPLnByb3RvGhFITEVJT0ZKRUFLQy5wcm90byJ2CgtNRkxESEJKTkVP";
		buffer[2] = "TxIhCgtER09ESElKQk1EUBgDIAMoCzIMLkhLR0RHQUpISlBPEiEKC05DSkZE";
		buffer[3] = "Qk1ISU5KGAcgASgLMgwuSExFSU9GSkVBS0MSIQoLRUZPQURDR0tMRkcYCiAD";
		buffer[4] = "KAsyDC5DS1BFSUhPTEFEUEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[5] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			CKPEIHOLADPReflection.Descriptor,
			HKGDGAJHJPOReflection.Descriptor,
			HLEIOFJEAKCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MFLDHBJNEOO), MFLDHBJNEOO.Parser, new string[3] { "DGODHIJBMDP", "NCJFDBMHINJ", "EFOADCGKLFG" }, null, null, null, null)
		}));
	}
}
