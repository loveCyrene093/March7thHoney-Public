using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAvatarDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAvatarDataScRspReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 0) = "ChhHZXRBdmF0YXJEYXRhU2NSc3AucHJvdG8aDEF2YXRhci5wcm90bxoUQXZh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 1) = "dGFyUGF0aERhdGEucHJvdG8aEUdLREVLSktPSUpOLnByb3RvGhtHcm93dGhU";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 2) = "YXJ0Z2V0RnVuY1R5cGUucHJvdG8aFlBsYXllck91dGZpdEluZm8ucHJvdG8i";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 3) = "zwIKEkdldEF2YXRhckRhdGFTY1JzcBIrChBQbGF5ZXJPdXRmaXREYXRhGAEg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 4) = "ASgLMhEuUGxheWVyT3V0Zml0SW5mbxIhCgtNTUVLRkpETUlMShgDIAMoCzIM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 5) = "LkdLREVLSktPSUpOEi0KDUN1ckF2YXRhclBhdGgYBCADKA4yFi5Hcm93dGhU";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 6) = "YXJ0Z2V0RnVuY1R5cGUSEQoJc2tpbl9saXN0GAYgAygNEhIKCmlzX2dldF9h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 7) = "bGwYByABKAgSDwoHcmV0Y29kZRgIIAEoDRIaChJiYXNpY190eXBlX2lkX2xp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 8) = "c3QYCyADKA0SMwoaYXZhdGFyX3BhdGhfZGF0YV9pbmZvX2xpc3QYDCADKAsy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 9) = "Dy5BdmF0YXJQYXRoRGF0YRIcCgthdmF0YXJfbGlzdBgOIAMoCzIHLkF2YXRh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 10) = "chITCgtNTU9QQ0tMUEhJTxgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 11) = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray12<string>, string>(in buffer, 12))), new FileDescriptor[5]
		{
			AvatarReflection.Descriptor,
			AvatarPathDataReflection.Descriptor,
			GKDEKJKOIJNReflection.Descriptor,
			GrowthTartgetFuncTypeReflection.Descriptor,
			PlayerOutfitInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAvatarDataScRsp), GetAvatarDataScRsp.Parser, new string[10] { "PlayerOutfitData", "MMEKFJDMILJ", "CurAvatarPath", "SkinList", "IsGetAll", "Retcode", "BasicTypeIdList", "AvatarPathDataInfoList", "AvatarList", "MMOPCKLPHIO" }, null, null, null, null)
		}));
	}
}
