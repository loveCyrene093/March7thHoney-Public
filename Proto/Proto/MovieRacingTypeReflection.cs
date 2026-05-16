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
		buffer[0] = "ChVNb3ZpZVJhY2luZ1R5cGUucHJvdG8qhQEKD01vdmllUmFjaW5nVHlwZRIb";
		buffer[1] = "ChdQS0hJQ0xFSEpLTF9ITktESFBLQ0dFTxAAEhsKF1BLSElDTEVISktMX0VC";
		buffer[2] = "QUJIT0FPREZGEAESGwoXUEtISUNMRUhKS0xfSEhGSUJFTk5FQkgQAhIbChdQ";
		buffer[3] = "S0hJQ0xFSEpLTF9LSURJS0tKTkpOShADQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[4] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(MovieRacingType) }, null, null));
	}
}
