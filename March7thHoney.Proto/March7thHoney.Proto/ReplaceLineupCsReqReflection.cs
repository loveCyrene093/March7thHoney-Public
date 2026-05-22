using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ReplaceLineupCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ReplaceLineupCsReqReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChhSZXBsYWNlTGluZXVwQ3NSZXEucHJvdG8aFUV4dHJhTGluZXVwVHlwZS5w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "cm90bxoUTGluZXVwU2xvdERhdGEucHJvdG8i/AEKElJlcGxhY2VMaW5ldXBD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "c1JlcRITCgtsZWFkZXJfc2xvdBgBIAEoDRITCgtGTEZKTUNGQUNLThgFIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "CBITCgtCSkFESENPRkxHSRgGIAEoCBINCgVpbmRleBgIIAEoDRISCgppc192";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "aXJ0dWFsGAkgASgIEikKEGxpbmV1cF9zbG90X2xpc3QYCyADKAsyDy5MaW5l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "dXBTbG90RGF0YRIaChJnYW1lX3N0b3J5X2xpbmVfaWQYDCABKA0SEAoIcGxh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "bmVfaWQYDiABKA0SKwoRZXh0cmFfbGluZXVwX3R5cGUYDyABKA4yEC5FeHRy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "YUxpbmV1cFR5cGVCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[2]
		{
			ExtraLineupTypeReflection.Descriptor,
			LineupSlotDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ReplaceLineupCsReq), ReplaceLineupCsReq.Parser, new string[9] { "LeaderSlot", "FLFJMCFACKN", "BJADHCOFLGI", "Index", "IsVirtual", "LineupSlotList", "GameStoryLineId", "PlaneId", "ExtraLineupType" }, null, null, null, null)
		}));
	}
}
