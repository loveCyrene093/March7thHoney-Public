using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdDailyActiveTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdDailyActiveTypeReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChhDbWREYWlseUFjdGl2ZVR5cGUucHJvdG8qhAIKEkNtZERhaWx5QWN0aXZl";
		buffer[1] = "VHlwZRIbChdPTURES0hCSkJHRV9QQ1BESEVMUEtFTRAAEhkKFENtZFRha2VB";
		buffer[2] = "cFJld2FyZFNjUnNwEO4ZEh0KGENtZERhaWx5QWN0aXZlSW5mb05vdGlmeRDy";
		buffer[3] = "GRIZChRDbWRUYWtlQXBSZXdhcmRDc1JlcRC/GhIfChpDbWRHZXREYWlseUFj";
		buffer[4] = "dGl2ZUluZm9Dc1JlcRDCGhIcChdDbWRUYWtlQWxsQXBSZXdhcmRDc1JlcRD2";
		buffer[5] = "GRIcChdDbWRUYWtlQWxsQXBSZXdhcmRTY1JzcBDtGRIfChpDbWRHZXREYWls";
		buffer[6] = "eUFjdGl2ZUluZm9TY1JzcBDDGkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[7] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdDailyActiveType) }, null, null));
	}
}
