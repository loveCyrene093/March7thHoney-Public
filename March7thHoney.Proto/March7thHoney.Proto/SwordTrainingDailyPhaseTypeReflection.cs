using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingDailyPhaseTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingDailyPhaseTypeReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiFTd29yZFRyYWluaW5nRGFpbHlQaGFzZVR5cGUucHJvdG8qrgEKG1N3b3Jk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "VHJhaW5pbmdEYWlseVBoYXNlVHlwZRIbChdNTUtKSktCT05FQV9QQ1BESEVM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "UEtFTRAAEhsKF01NS0pKS0JPTkVBX0ZITktGSkZEQ0tPEAESGwoXTU1LSkpL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "Qk9ORUFfT0RQREhQRE1BRkMQAhIbChdNTUtKSktCT05FQV9DUEFERktIS0RN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "RBADEhsKF01NS0pKS0JPTkVBX0pOTFBGS0FMQ0lCEARCFqoCE01hcmNoN3Ro";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(SwordTrainingDailyPhaseType) }, null, null));
	}
}
