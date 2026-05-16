using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightHpModifyInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightHpModifyInfoReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChtHcmlkRmlnaHRIcE1vZGlmeUluZm8ucHJvdG8aI0dyaWRGaWdodFVwZGF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "ZUdsb2JhbEhwUmVhc29uLnByb3RvIpsBChVHcmlkRmlnaHRIcE1vZGlmeUlu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "Zm8SLgoGcmVhc29uGAEgASgOMh4uR3JpZEZpZ2h0VXBkYXRlR2xvYmFsSHBS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "ZWFzb24SEwoLUERFS0RIUE5DRU4YBiABKA0SEwoLRkdFREtPSU5NQUcYCCAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "KAUSEwoLSFBPUEROR0NBTEwYCSABKA0SEwoLRUhNS0xORUtJT0UYCyABKAVC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { GridFightUpdateGlobalHpReasonReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightHpModifyInfo), GridFightHpModifyInfo.Parser, new string[5] { "Reason", "PDEKDHPNCEN", "FGEDKOINMAG", "HPOPDNGCALL", "EHMKLNEKIOE" }, null, null, null, null)
		}));
	}
}
