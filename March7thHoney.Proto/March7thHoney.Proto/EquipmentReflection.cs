using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EquipmentReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EquipmentReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Cg9FcXVpcG1lbnQucHJvdG8ilwEKCUVxdWlwbWVudBIRCglwcm9tb3Rpb24Y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "AyABKA0SFwoPZHJlc3NfYXZhdGFyX2lkGAQgASgNEgsKA2V4cBgFIAEoDRIN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "CgVsZXZlbBgHIAEoDRIUCgxpc19wcm90ZWN0ZWQYCCABKAgSDAoEcmFuaxgK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "IAEoDRIRCgl1bmlxdWVfaWQYCyABKA0SCwoDdGlkGAwgASgNQhaqAhNNYXJj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Equipment), Equipment.Parser, new string[8] { "Promotion", "DressAvatarId", "Exp", "Level", "IsProtected", "Rank", "UniqueId", "Tid" }, null, null, null, null)
		}));
	}
}
