using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AvatarReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AvatarReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "CgxBdmF0YXIucHJvdG8i6gEKBkF2YXRhchIcChRmaXJzdF9tZXRfdGltZV9z";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "dGFtcBgCIAEoBBIRCglwcm9tb3Rpb24YAyABKA0SEQoJaXNfbWFya2VkGAUg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "ASgIEg0KBWxldmVsGAggASgNEhYKDmJhc2VfYXZhdGFyX2lkGAkgASgNEicK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "H2hhc190YWtlbl9wcm9tb3Rpb25fcmV3YXJkX2xpc3QYDCADKA0SIgoaY3Vy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "X211bHRpX3BhdGhfYXZhdGFyX3R5cGUYDSABKA0SCwoDZXhwGA4gASgNEhsK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "E2VxdWlwbWVudF91bmlxdWVfaWQYDyABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Avatar), Avatar.Parser, new string[9] { "FirstMetTimeStamp", "Promotion", "IsMarked", "Level", "BaseAvatarId", "HasTakenPromotionRewardList", "CurMultiPathAvatarType", "Exp", "EquipmentUniqueId" }, null, null, null, null)
		}));
	}
}
