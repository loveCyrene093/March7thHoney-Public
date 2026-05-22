using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DPEHILAANONReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DPEHILAANONReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFEUEVISUxBQU5PTi5wcm90byKCAQoLRFBFSElMQUFOT04SEwoLREVBS09P";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "RUJMSkwYAiABKA0SHwoXZ3JpZF9maWdodF9lcXVpcG1lbnRfaWQYAyABKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "EwoLSExLQUZQQ0xNRU8YBSABKAgSEwoLSEpNSklBREJBT0MYCyABKA0SEwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "RERHRU9PTEhBUEcYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DPEHILAANON), DPEHILAANON.Parser, new string[5] { "DEAKOOEBLJL", "GridFightEquipmentId", "HLKAFPCLMEO", "HJMJIADBAOC", "DDGEOOLHAPG" }, null, null, null, null)
		}));
	}
}
