using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesBonusEventInteractScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesBonusEventInteractScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiZQbGFuZXRGZXNCb251c0V2ZW50SW50ZXJhY3RTY1JzcC5wcm90bxoRSExM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "Q0RCTENJUEsucHJvdG8aEUpJUEFDREVKS0pDLnByb3RvIokBCiBQbGFuZXRG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "ZXNCb251c0V2ZW50SW50ZXJhY3RTY1JzcBITCgtQSEtBSEFITERBRRgCIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "DRIhCgtESUhFQ0lJS0VMRRgHIAEoCzIMLkpJUEFDREVKS0pDEhwKBnJld2Fy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "ZBgIIAEoCzIMLkhMTENEQkxDSVBLEg8KB3JldGNvZGUYDiABKA1CFqoCE01h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			HLLCDBLCIPKReflection.Descriptor,
			JIPACDEJKJCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesBonusEventInteractScRsp), PlanetFesBonusEventInteractScRsp.Parser, new string[4] { "PHKAHAHLDAE", "DIHECIIKELE", "Reward", "Retcode" }, null, null, null, null)
		}));
	}
}
