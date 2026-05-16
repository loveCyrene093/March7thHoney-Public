using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AddMultiPathAvatarScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AddMultiPathAvatarScNotifyReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "CiBBZGRNdWx0aVBhdGhBdmF0YXJTY05vdGlmeS5wcm90bxoRRFBCRUdCTklD";
		buffer[1] = "UEcucHJvdG8aDkl0ZW1MaXN0LnByb3RvGhFQSk5FRkJCTFBORC5wcm90byKg";
		buffer[2] = "AQoaQWRkTXVsdGlQYXRoQXZhdGFyU2NOb3RpZnkSIQoLTEFOR0pPSkxFT0MY";
		buffer[3] = "AiABKA4yDC5QSk5FRkJCTFBORBIOCgZpc19uZXcYBCABKAgSIQoLT0lPRlBB";
		buffer[4] = "RE9HRkMYCiADKAsyDC5EUEJFR0JOSUNQRxIRCglhdmF0YXJfaWQYDCABKA0S";
		buffer[5] = "GQoGcmV3YXJkGA4gASgLMgkuSXRlbUxpc3RCFqoCE01hcmNoN3RoSG9uZXku";
		buffer[6] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			DPBEGBNICPGReflection.Descriptor,
			ItemListReflection.Descriptor,
			PJNEFBBLPNDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AddMultiPathAvatarScNotify), AddMultiPathAvatarScNotify.Parser, new string[5] { "LANGJOJLEOC", "IsNew", "OIOFPADOGFC", "AvatarId", "Reward" }, null, null, null, null)
		}));
	}
}
