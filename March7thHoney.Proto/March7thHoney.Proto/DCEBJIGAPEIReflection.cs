using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DCEBJIGAPEIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DCEBJIGAPEIReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFEQ0VCSklHQVBFSS5wcm90bxoRR0xKTEVFUE9DREEucHJvdG8aEUxLRk5E";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "QU9HTU1PLnByb3RvIo4BCgtEQ0VCSklHQVBFSRIhCgtIQUlPSEFORElLSRgE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "IAMoCzIMLkxLRk5EQU9HTU1PEgwKBHdhdmUYBiABKA0SDgoGbWF4X2hwGAcg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "ASgNEg4KBmN1cl9ocBgJIAEoDRIQCghzdGFnZV9pZBgKIAEoDRIcCgZyZWFz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "b24YDyABKA4yDC5HTEpMRUVQT0NEQUIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			GLJLEEPOCDAReflection.Descriptor,
			LKFNDAOGMMOReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DCEBJIGAPEI), DCEBJIGAPEI.Parser, new string[6] { "HAIOHANDIKI", "Wave", "MaxHp", "CurHp", "StageId", "Reason" }, null, null, null, null)
		}));
	}
}
