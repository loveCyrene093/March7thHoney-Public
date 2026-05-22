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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChFQQkdNS05FR09QSy5wcm90bxoRQkRFTUFCUExQS08ucHJvdG8aEUhJQkJQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "T0FNRE1BLnByb3RvGhFPTk9JTkFIRUhIQi5wcm90byK1AQoLUEJHTUtORUdP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "UEsSEwoLTUpJRE1CSk5HRUkYAyABKA0SIQoLQktBUEJER0hJQUIYBCADKAsy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "DC5ISUJCUE9BTURNQRIhCgtBTEhEQkxBSkhOThgGIAEoCzIMLkJERU1BQlBM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "UEtPEhMKC0FGREJIR0NBSkRCGAkgASgNEhMKC0xLQkRMQkVBTUdQGAwgAygN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "EiEKC0JJTU5DTk1CT0dGGA0gAygLMgwuT05PSU5BSEVISEJCFqoCE01hcmNo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[3]
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
