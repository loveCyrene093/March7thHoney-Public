using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeliobusActivityDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeliobusActivityDataScRspReflection()
	{
		InlineArray11<string> buffer = default(InlineArray11<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 0) = "Ch9IZWxpb2J1c0FjdGl2aXR5RGF0YVNjUnNwLnByb3RvGhFETEZPR0pHQ0NH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 1) = "UC5wcm90bxoRRkpDREFLSUNGS0EucHJvdG8aG0hlbGlvYnVzQ2hhbGxlbmdl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 2) = "RGF0YS5wcm90bxodSGVsaW9idXNDaGFsbGVuZ2VMaW5ldXAucHJvdG8irQIK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 3) = "GUhlbGlvYnVzQWN0aXZpdHlEYXRhU2NSc3ASLQoLQ0hHTktETkZOTEYYASAD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 4) = "KAsyGC5IZWxpb2J1c0NoYWxsZW5nZUxpbmV1cBITCgtJTUJPS0dGSUFDQRgC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 5) = "IAEoDRINCgVsZXZlbBgDIAEoDRIPCgdyZXRjb2RlGAQgASgNEg0KBXBoYXNl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 6) = "GAUgASgNEhMKC0RLT0dOT0tPUEtHGAkgASgNEi4KDmNoYWxsZW5nZV9saXN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 7) = "GAogAygLMhYuSGVsaW9idXNDaGFsbGVuZ2VEYXRhEhMKC0dDRExDUE1GTE1I";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 8) = "GAsgASgNEiAKCnNraWxsX2luZm8YDCABKAsyDC5GSkNEQUtJQ0ZLQRIhCgtM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 9) = "UE1JSEJMT0lBSxgPIAMoCzIMLkRMRk9HSkdDQ0dQQhaqAhNNYXJjaDd0aEhv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 10) = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray11<string>, string>(in buffer, 11))), new FileDescriptor[4]
		{
			DLFOGJGCCGPReflection.Descriptor,
			FJCDAKICFKAReflection.Descriptor,
			HeliobusChallengeDataReflection.Descriptor,
			HeliobusChallengeLineupReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusActivityDataScRsp), HeliobusActivityDataScRsp.Parser, new string[10] { "CHGNKDNFNLF", "IMBOKGFIACA", "Level", "Retcode", "Phase", "DKOGNOKOPKG", "ChallengeList", "GCDLCPMFLMH", "SkillInfo", "LPMIHBLOIAK" }, null, null, null, null)
		}));
	}
}
