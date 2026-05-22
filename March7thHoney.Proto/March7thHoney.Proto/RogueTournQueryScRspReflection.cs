using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournQueryScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournQueryScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChpSb2d1ZVRvdXJuUXVlcnlTY1JzcC5wcm90bxoRQVBNSERHUERHTlAucHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dG8aEUJFQkVPTUJNREZCLnByb3RvInAKFFJvZ3VlVG91cm5RdWVyeVNjUnNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "Eg8KB3JldGNvZGUYASABKA0SJAoOcm9ndWVfZ2V0X2luZm8YByABKAsyDC5C";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "RUJFT01CTURGQhIhCgtISERMRUFEQkpHThgNIAEoCzIMLkFQTUhER1BER05Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			APMHDGPDGNPReflection.Descriptor,
			BEBEOMBMDFBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournQueryScRsp), RogueTournQueryScRsp.Parser, new string[3] { "Retcode", "RogueGetInfo", "HHDLEADBJGN" }, null, null, null, null)
		}));
	}
}
