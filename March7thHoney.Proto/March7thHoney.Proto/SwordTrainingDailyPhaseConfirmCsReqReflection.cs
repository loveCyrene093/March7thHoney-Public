using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingDailyPhaseConfirmCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingDailyPhaseConfirmCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CilTd29yZFRyYWluaW5nRGFpbHlQaGFzZUNvbmZpcm1Dc1JlcS5wcm90bxoh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "U3dvcmRUcmFpbmluZ0RhaWx5UGhhc2VUeXBlLnByb3RvIlgKI1N3b3JkVHJh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "aW5pbmdEYWlseVBoYXNlQ29uZmlybUNzUmVxEjEKC0JGUEZETUdNQ0FJGAQg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "ASgOMhwuU3dvcmRUcmFpbmluZ0RhaWx5UGhhc2VUeXBlQhaqAhNNYXJjaDd0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { SwordTrainingDailyPhaseTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingDailyPhaseConfirmCsReq), SwordTrainingDailyPhaseConfirmCsReq.Parser, new string[1] { "BFPFDMGMCAI" }, null, null, null, null)
		}));
	}
}
