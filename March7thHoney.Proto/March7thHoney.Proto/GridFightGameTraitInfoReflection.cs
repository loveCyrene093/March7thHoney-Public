using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightGameTraitInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightGameTraitInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChxHcmlkRmlnaHRHYW1lVHJhaXRJbmZvLnByb3RvGhFFTEVPR0FCR0JLRy5w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "cm90bxoXR3JpZEdhbWVUcmFpdEluZm8ucHJvdG8ibgoWR3JpZEZpZ2h0R2Ft";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ZVRyYWl0SW5mbxIxChVncmlkX2ZpZ2h0X3RyYWl0X2luZm8YBSADKAsyEi5H";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "cmlkR2FtZVRyYWl0SW5mbxIhCgtBTElERExCRFBESBgNIAMoCzIMLkVMRU9H";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "QUJHQktHQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			ELEOGABGBKGReflection.Descriptor,
			GridGameTraitInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightGameTraitInfo), GridFightGameTraitInfo.Parser, new string[2] { "GridFightTraitInfo", "ALIDDLBDPDH" }, null, null, null, null)
		}));
	}
}
