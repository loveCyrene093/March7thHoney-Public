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
		buffer[0] = "ChFOQUpHSVBJR0NESC5wcm90bxoXQ2xvY2tQYXJrQnVmZkxpc3QucHJvdG8a";
		buffer[1] = "EUpIQUtBREVLSkVKLnByb3RvGhFPQkVDQk1NTURIQy5wcm90byLKAQoLTkFK";
		buffer[2] = "R0lQSUdDREgSJwoLSEtHS05FS0tKSEIYAiABKAsyEi5DbG9ja1BhcmtCdWZm";
		buffer[3] = "TGlzdBIRCglzY3JpcHRfaWQYBCABKA0SDwoHcmV0Y29kZRgGIAEoDRITCgtO";
		buffer[4] = "TkZBTU9KQUhDSBgIIAEoDRIkCgtOSkVMR0VCSEFPUBjXCyABKAsyDC5PQkVD";
		buffer[5] = "Qk1NTURIQ0gAEiQKC01FQk1ETEJQRUhPGIsNIAEoCzIMLkpIQUtBREVLSkVK";
		buffer[6] = "SABCDQoLQkVFUEFDUEZPT0xCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[7] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
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
