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
		buffer[0] = "Cg9FcXVpcG1lbnQucHJvdG8ilwEKCUVxdWlwbWVudBIRCglwcm9tb3Rpb24Y";
		buffer[1] = "AyABKA0SFwoPZHJlc3NfYXZhdGFyX2lkGAQgASgNEgsKA2V4cBgFIAEoDRIN";
		buffer[2] = "CgVsZXZlbBgHIAEoDRIUCgxpc19wcm90ZWN0ZWQYCCABKAgSDAoEcmFuaxgK";
		buffer[3] = "IAEoDRIRCgl1bmlxdWVfaWQYCyABKA0SCwoDdGlkGAwgASgNQhaqAhNNYXJj";
		buffer[4] = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Equipment), Equipment.Parser, new string[8] { "Promotion", "DressAvatarId", "Exp", "Level", "IsProtected", "Rank", "UniqueId", "Tid" }, null, null, null, null)
		}));
	}
}
