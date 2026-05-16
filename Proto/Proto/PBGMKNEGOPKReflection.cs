using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PBGMKNEGOPKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PBGMKNEGOPKReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFQQkdNS05FR09QSy5wcm90bxoRQkRFTUFCUExQS08ucHJvdG8aEUhJQkJQ";
		buffer[1] = "T0FNRE1BLnByb3RvGhFPTk9JTkFIRUhIQi5wcm90byK1AQoLUEJHTUtORUdP";
		buffer[2] = "UEsSEwoLTUpJRE1CSk5HRUkYAyABKA0SIQoLQktBUEJER0hJQUIYBCADKAsy";
		buffer[3] = "DC5ISUJCUE9BTURNQRIhCgtBTEhEQkxBSkhOThgGIAEoCzIMLkJERU1BQlBM";
		buffer[4] = "UEtPEhMKC0FGREJIR0NBSkRCGAkgASgNEhMKC0xLQkRMQkVBTUdQGAwgAygN";
		buffer[5] = "EiEKC0JJTU5DTk1CT0dGGA0gAygLMgwuT05PSU5BSEVISEJCFqoCE01hcmNo";
		buffer[6] = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			BDEMABPLPKOReflection.Descriptor,
			HIBBPOAMDMAReflection.Descriptor,
			ONOINAHEHHBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PBGMKNEGOPK), PBGMKNEGOPK.Parser, new string[6] { "MJIDMBJNGEI", "BKAPBDGHIAB", "ALHDBLAJHNN", "AFDBHGCAJDB", "LKBDLBEAMGP", "BIMNCNMBOGF" }, null, null, null, null)
		}));
	}
}
