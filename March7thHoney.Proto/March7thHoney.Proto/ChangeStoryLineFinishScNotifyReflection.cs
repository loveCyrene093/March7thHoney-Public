using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChangeStoryLineFinishScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChangeStoryLineFinishScNotifyReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiNDaGFuZ2VTdG9yeUxpbmVGaW5pc2hTY05vdGlmeS5wcm90bxobQ2hhbmdl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "U3RvcnlMaW5lQWN0aW9uLnByb3RvIowBCh1DaGFuZ2VTdG9yeUxpbmVGaW5p";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "c2hTY05vdGlmeRITCgtLSEROR0ZLT0ZMSBgEIAEoDRImCgZhY3Rpb24YBSAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "KA4yFi5DaGFuZ2VTdG9yeUxpbmVBY3Rpb24SEwoLR09IQ0VPTEVITEcYCSAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "KAgSGQoRY3VyX3N0b3J5X2xpbmVfaWQYDSABKA1CFqoCE01hcmNoN3RoSG9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { ChangeStoryLineActionReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChangeStoryLineFinishScNotify), ChangeStoryLineFinishScNotify.Parser, new string[4] { "KHDNGFKOFLH", "Action", "GOHCEOLEHLG", "CurStoryLineId" }, null, null, null, null)
		}));
	}
}
