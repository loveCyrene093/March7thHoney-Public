using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AetherAvatarInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AetherAvatarInfoReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChZBZXRoZXJBdmF0YXJJbmZvLnByb3RvGhFITEpNQ0lCT0JKTy5wcm90bxoP";
		buffer[1] = "U3BCYXJJbmZvLnByb3RvIpQBChBBZXRoZXJBdmF0YXJJbmZvEgoKAmlkGAEg";
		buffer[2] = "ASgNEg0KBWluZGV4GAIgASgNEhEKCXByb21vdGlvbhgDIAEoDRITCgtPS01G";
		buffer[3] = "RUdESU9ORxgEIAMoDRIhCgtLQk5DTEZDR0hDSxgFIAEoDjIMLkhMSk1DSUJP";
		buffer[4] = "QkpPEhoKBnNwX2JhchgGIAEoCzIKLlNwQmFySW5mb0IWqgITTWFyY2g3dGhI";
		buffer[5] = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			HLJMCIBOBJOReflection.Descriptor,
			SpBarInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AetherAvatarInfo), AetherAvatarInfo.Parser, new string[6] { "Id", "Index", "Promotion", "OKMFEGDIONG", "KBNCLFCGHCK", "SpBar" }, null, null, null, null)
		}));
	}
}
