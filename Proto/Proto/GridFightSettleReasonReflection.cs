using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightSettleReasonReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightSettleReasonReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChtHcmlkRmlnaHRTZXR0bGVSZWFzb24ucHJvdG8qqAEKFUdyaWRGaWdodFNl";
		buffer[1] = "dHRsZVJlYXNvbhIbChdDRFBIREhOTEhBT19GTVBCSEVMRkdFRRAAEhsKF0NE";
		buffer[2] = "UEhESE5MSEFPX0VQSEpGS0ZGREtDEAESGwoXQ0RQSERITkxIQU9fRkxOSE5I";
		buffer[3] = "QkNES00QAhIbChdDRFBIREhOTEhBT19DTE5MR0JDTU9JShADEhsKF0NEUEhE";
		buffer[4] = "SE5MSEFPX0JBS0hBSUJHUEdDEARCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[5] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GridFightSettleReason) }, null, null));
	}
}
