using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NCLCIIMIHDHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NCLCIIMIHDHReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChFOQ0xDSUlNSUhESC5wcm90bxonUGxheWVyQ2hhbGxlbmdlUGVha1JlY29y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "ZEJvc3NEYXRhLnByb3RvGiZQbGF5ZXJDaGFsbGVuZ2VQZWFrUmVjb3JkTW9i";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "RGF0YS5wcm90byKQAQoLTkNMQ0lJTUlIREgSEAoIZ3JvdXBfaWQYASABKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "NwoLTkZDTEpNQkxGTUsYAyABKAsyIi5QbGF5ZXJDaGFsbGVuZ2VQZWFrUmVj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "b3JkQm9zc0RhdGESNgoLRERKSURJS0hBTkgYCyADKAsyIS5QbGF5ZXJDaGFs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "bGVuZ2VQZWFrUmVjb3JkTW9iRGF0YUIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			PlayerChallengePeakRecordBossDataReflection.Descriptor,
			PlayerChallengePeakRecordMobDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NCLCIIMIHDH), NCLCIIMIHDH.Parser, new string[3] { "GroupId", "NFCLJMBLFMK", "DDJIDIKHANH" }, null, null, null, null)
		}));
	}
}
