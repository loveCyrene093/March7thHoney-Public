using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OJKAHCEKDGNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OJKAHCEKDGNReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFPSktBSENFS0RHTi5wcm90bxoRQVBNSERHUERHTlAucHJvdG8aEUNOTUJJ";
		buffer[1] = "UE9QT0ZILnByb3RvGhFIRERCSklLTkVQRi5wcm90bxoRTkNEQlBLQUlISU4u";
		buffer[2] = "cHJvdG8i1QEKC09KS0FIQ0VLREdOEgwKBG5hbWUYAyABKAkSEAoIZW5kX3Rp";
		buffer[3] = "bWUYBCABKAMSEwoLS0tHSUVFTkNPSUMYBSABKA0SIQoLSEhETEVBREJKR04Y";
		buffer[4] = "BiABKAsyDC5BUE1IREdQREdOUBIhCgtIQ0VIT0hEQ0NGRRgHIAEoCzIMLkNO";
		buffer[5] = "TUJJUE9QT0ZIEhoKBGRhdGEYDCABKAsyDC5OQ0RCUEtBSUhJThIhCgthdmF0";
		buffer[6] = "YXJfbGlzdBgNIAMoCzIMLkhEREJKSUtORVBGEgwKBHRpbWUYDyABKANCFqoC";
		buffer[7] = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			APMHDGPDGNPReflection.Descriptor,
			CNMBIPOPOFHReflection.Descriptor,
			HDDBJIKNEPFReflection.Descriptor,
			NCDBPKAIHINReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OJKAHCEKDGN), OJKAHCEKDGN.Parser, new string[8] { "Name", "EndTime", "KKGIEENCOIC", "HHDLEADBJGN", "HCEHOHDCCFE", "Data", "AvatarList", "Time" }, null, null, null, null)
		}));
	}
}
