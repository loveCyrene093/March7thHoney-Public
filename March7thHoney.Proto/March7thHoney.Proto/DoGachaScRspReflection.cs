using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DoGachaScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DoGachaScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChJEb0dhY2hhU2NSc3AucHJvdG8aD0dhY2hhSXRlbS5wcm90byLSAQoMRG9H";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "YWNoYVNjUnNwEhAKCGdhY2hhX2lkGAIgASgNEg8KB3JldGNvZGUYAyABKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "EwoLT0tGTk5ITkxCT08YBSABKA0SEwoLRUhLRlBNSkNFTUkYCCABKA0SEwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "TkpKS0lDTk9GQ0wYCSABKA0SEQoJZ2FjaGFfbnVtGAogASgNEiMKD2dhY2hh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "X2l0ZW1fbGlzdBgLIAMoCzIKLkdhY2hhSXRlbRITCgtjZWlsaW5nX251bRgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "IAEoDRITCgtGSklCT0FHRE5ERxgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[1] { GachaItemReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DoGachaScRsp), DoGachaScRsp.Parser, new string[9] { "GachaId", "Retcode", "OKFNNHNLBOO", "EHKFPMJCEMI", "NJJKICNOFCL", "GachaNum", "GachaItemList", "CeilingNum", "FJIBOAGDNDG" }, null, null, null, null)
		}));
	}
}
