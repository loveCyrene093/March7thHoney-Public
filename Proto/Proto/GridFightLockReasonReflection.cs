using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightLockReasonReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightLockReasonReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChlHcmlkRmlnaHRMb2NrUmVhc29uLnByb3RvKokBChNHcmlkRmlnaHRMb2Nr";
		buffer[1] = "UmVhc29uEhsKF0RGT0ZGRkNFRkZPX0RJT05LQk1GRkROEAASGwoXREZPRkZG";
		buffer[2] = "Q0VGRk9fQkRQUEVFSENETEYQARIbChdERk9GRkZDRUZGT19DRkFGTUtPQkFQ";
		buffer[3] = "ShACEhsKF0RGT0ZGRkNFRkZPX0tKTUpEQkpNQk1DEANCFqoCE01hcmNoN3Ro";
		buffer[4] = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GridFightLockReason) }, null, null));
	}
}
