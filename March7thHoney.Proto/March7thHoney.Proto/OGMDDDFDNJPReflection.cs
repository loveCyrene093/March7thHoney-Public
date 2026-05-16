using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OGMDDDFDNJPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OGMDDDFDNJPReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFPR01ERERGRE5KUC5wcm90bxoRRFBERExBT0JNQkgucHJvdG8idAoLT0dN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "RERERkROSlASEQoJdW5pcXVlX2lkGAQgASgNEg8KB3JldGNvZGUYCiABKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "DgoEbmFtZRgDIAEoCUgAEiIKCnJlbGljX2xpc3QYCCABKAsyDC5EUERETEFP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "Qk1CSEgAQg0KC0JQSUhGQUpDTE9DQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { DPDDLAOBMBHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OGMDDDFDNJP), OGMDDDFDNJP.Parser, new string[4] { "UniqueId", "Retcode", "Name", "RelicList" }, new string[1] { "BPIHFAJCLOC" }, null, null, null)
		}));
	}
}
