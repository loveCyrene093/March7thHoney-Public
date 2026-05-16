using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NAJGIPIGCDHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NAJGIPIGCDHReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChFOQUpHSVBJR0NESC5wcm90bxoXQ2xvY2tQYXJrQnVmZkxpc3QucHJvdG8a";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "EUpIQUtBREVLSkVKLnByb3RvGhFPQkVDQk1NTURIQy5wcm90byLKAQoLTkFK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "R0lQSUdDREgSJwoLSEtHS05FS0tKSEIYAiABKAsyEi5DbG9ja1BhcmtCdWZm";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "TGlzdBIRCglzY3JpcHRfaWQYBCABKA0SDwoHcmV0Y29kZRgGIAEoDRITCgtO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "TkZBTU9KQUhDSBgIIAEoDRIkCgtOSkVMR0VCSEFPUBjXCyABKAsyDC5PQkVD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "Qk1NTURIQ0gAEiQKC01FQk1ETEJQRUhPGIsNIAEoCzIMLkpIQUtBREVLSkVK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "SABCDQoLQkVFUEFDUEZPT0xCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[3]
		{
			ClockParkBuffListReflection.Descriptor,
			JHAKADEKJEJReflection.Descriptor,
			OBECBMMMDHCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NAJGIPIGCDH), NAJGIPIGCDH.Parser, new string[6] { "HKGKNEKKJHB", "ScriptId", "Retcode", "NNFAMOJAHCH", "NJELGEBHAOP", "MEBMDLBPEHO" }, new string[1] { "BEEPACPFOOL" }, null, null, null)
		}));
	}
}
