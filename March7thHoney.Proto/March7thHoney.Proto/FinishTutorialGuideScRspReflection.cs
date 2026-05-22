using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishTutorialGuideScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishTutorialGuideScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch5GaW5pc2hUdXRvcmlhbEd1aWRlU2NSc3AucHJvdG8aDkl0ZW1MaXN0LnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "b3RvGhNUdXRvcmlhbEd1aWRlLnByb3RvIm4KGEZpbmlzaFR1dG9yaWFsR3Vp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ZGVTY1JzcBIZCgZyZXdhcmQYASABKAsyCS5JdGVtTGlzdBImCg50dXRvcmlh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "bF9ndWlkZRgHIAEoCzIOLlR1dG9yaWFsR3VpZGUSDwoHcmV0Y29kZRgKIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			ItemListReflection.Descriptor,
			TutorialGuideReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishTutorialGuideScRsp), FinishTutorialGuideScRsp.Parser, new string[3] { "Reward", "TutorialGuide", "Retcode" }, null, null, null, null)
		}));
	}
}
