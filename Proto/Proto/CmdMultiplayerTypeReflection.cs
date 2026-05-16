using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdMultiplayerTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdMultiplayerTypeReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		buffer[0] = "ChhDbWRNdWx0aXBsYXllclR5cGUucHJvdG8q1QMKEkNtZE11bHRpcGxheWVy";
		buffer[1] = "VHlwZRIbChdNQ01FQ0tJQkFETl9QQ1BESEVMUEtFTRAAEhMKDkNtZE1LTExM";
		buffer[2] = "S0xFRUFQEKcIEh0KGENtZEdldE1hdGNoUGxheURhdGFDc1JlcRCCCBIfChpD";
		buffer[3] = "bWRHZXRGcmllbmRSYW5raW5nSW5mb1JzcBCNCBIhChxDbWRHZXRGcmllbmRS";
		buffer[4] = "YW5raW5nSW5mb0NzUmVxELIIEhsKFkNtZEZpZ2h0R2FtZVN0YXRlQ3NSZXEQ";
		buffer[5] = "wwgSEwoOQ21kRkNJQU5KS0dNQ0gQyggSHwoaQ21kUGxheWVyR2V0RmlnaHRH";
		buffer[6] = "YXRlQ3NSZXEQxggSGAoTQ21kRmlnaHRHaXZlVXBDc1JlcRD2BxIbChZDbWRH";
		buffer[7] = "ZXRNYXRjaFBsYXlEYXRhUnNwEI8IEhMKDkNtZExPS0FKR0ZNS0FLEMcIEhsK";
		buffer[8] = "FkNtZEZpZ2h0R2FtZVN0YXRlU2NSc3AQ8gcSGQoUQ21kU2VsZlJhbmtDaGFu";
		buffer[9] = "Z2VOdGYQ7AcSHgoZQ21kTWF0Y2hQbGF5RGF0YUNoYW5nZU50ZhDpBxIeChlD";
		buffer[10] = "bWRGaWdodEdhbWVTdGFydFNjTm90aWZ5EPEHEhMKDkNtZERHRUVJTENNSEhF";
		buffer[11] = "EPoHQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdMultiplayerType) }, null, null));
	}
}
