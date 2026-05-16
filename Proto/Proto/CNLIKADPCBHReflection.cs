using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CNLIKADPCBHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CNLIKADPCBHReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFDTkxJS0FEUENCSC5wcm90bxoRRUZFR0tESEVNRk4ucHJvdG8ibQoLQ05M";
		buffer[1] = "SUtBRFBDQkgSEwoLT0VGSEdERU1PTUwYAyABKA0SEwoLT0hBSUVHQ0xQTEgY";
		buffer[2] = "BiABKA0SIQoLSUhMRERESFBPSU8YCyABKAsyDC5FRkVHS0RIRU1GThIRCglh";
		buffer[3] = "dmF0YXJfaWQYDCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { EFEGKDHEMFNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CNLIKADPCBH), CNLIKADPCBH.Parser, new string[4] { "OEFHGDEMOML", "OHAIEGCLPLH", "IHLDDDHPOIO", "AvatarId" }, null, null, null, null)
		}));
	}
}
