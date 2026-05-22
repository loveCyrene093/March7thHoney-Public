using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MovieRacingTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MovieRacingTypeReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChVNb3ZpZVJhY2luZ1R5cGUucHJvdG8qhQEKD01vdmllUmFjaW5nVHlwZRIb";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "ChdQS0hJQ0xFSEpLTF9ITktESFBLQ0dFTxAAEhsKF1BLSElDTEVISktMX0VC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "QUJIT0FPREZGEAESGwoXUEtISUNMRUhKS0xfSEhGSUJFTk5FQkgQAhIbChdQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "S0hJQ0xFSEpLTF9LSURJS0tKTkpOShADQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(MovieRacingType) }, null, null));
	}
}
