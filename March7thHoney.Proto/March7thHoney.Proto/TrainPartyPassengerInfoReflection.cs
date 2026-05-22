using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyPassengerInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyPassengerInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch1UcmFpblBhcnR5UGFzc2VuZ2VySW5mby5wcm90bxoZVHJhaW5QYXJ0eVBh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "c3Nlbmdlci5wcm90byJhChdUcmFpblBhcnR5UGFzc2VuZ2VySW5mbxIxChNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "YXNzZW5nZXJfaW5mb19saXN0GAIgAygLMhQuVHJhaW5QYXJ0eVBhc3Nlbmdl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "chITCgtEQUNFRE5HSkxCTRgNIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { TrainPartyPassengerReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyPassengerInfo), TrainPartyPassengerInfo.Parser, new string[2] { "PassengerInfoList", "DACEDNGJLBM" }, null, null, null, null)
		}));
	}
}
