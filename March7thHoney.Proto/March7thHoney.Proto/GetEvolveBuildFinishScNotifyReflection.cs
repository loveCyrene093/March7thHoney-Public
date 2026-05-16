using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetEvolveBuildFinishScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetEvolveBuildFinishScNotifyReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "CiJHZXRFdm9sdmVCdWlsZEZpbmlzaFNjTm90aWZ5LnByb3RvGhFDSkxKREtM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "Q05EQS5wcm90bxoRQ1BDTU5JS0ZMQ0gucHJvdG8i4QEKHEdldEV2b2x2ZUJ1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "aWxkRmluaXNoU2NOb3RpZnkSIQoLTU9ERElCSENQUEQYASABKAsyDC5DSkxK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "REtMQ05EQRIQCghzY29yZV9pZBgDIAEoDRILCgNleHAYBCABKA0SIQoLR0hJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "TUpEUFBKT0cYBSABKA4yDC5DUENNTklLRkxDSBITCgtDT0xQQkNFQ0ZPTRgG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "IAEoDRIQCghsZXZlbF9pZBgKIAEoDRIMCgR3YXZlGAwgASgNEhIKCml0ZW1f";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "dmFsdWUYDSABKA0SEwoLSkFEQktCQUJBTkcYDiABKAhCFqoCE01hcmNoN3Ro";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[2]
		{
			CJLJDKLCNDAReflection.Descriptor,
			CPCMNIKFLCHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetEvolveBuildFinishScNotify), GetEvolveBuildFinishScNotify.Parser, new string[9] { "MODDIBHCPPD", "ScoreId", "Exp", "GHIMJDPPJOG", "COLPBCECFOM", "LevelId", "Wave", "ItemValue", "JADBKBABANG" }, null, null, null, null)
		}));
	}
}
