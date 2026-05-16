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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 0) = "ChhDbWRNdWx0aXBsYXllclR5cGUucHJvdG8q1QMKEkNtZE11bHRpcGxheWVy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 1) = "VHlwZRIbChdNQ01FQ0tJQkFETl9QQ1BESEVMUEtFTRAAEhMKDkNtZE1LTExM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 2) = "S0xFRUFQEKcIEh0KGENtZEdldE1hdGNoUGxheURhdGFDc1JlcRCCCBIfChpD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 3) = "bWRHZXRGcmllbmRSYW5raW5nSW5mb1JzcBCNCBIhChxDbWRHZXRGcmllbmRS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 4) = "YW5raW5nSW5mb0NzUmVxELIIEhsKFkNtZEZpZ2h0R2FtZVN0YXRlQ3NSZXEQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 5) = "wwgSEwoOQ21kRkNJQU5KS0dNQ0gQyggSHwoaQ21kUGxheWVyR2V0RmlnaHRH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 6) = "YXRlQ3NSZXEQxggSGAoTQ21kRmlnaHRHaXZlVXBDc1JlcRD2BxIbChZDbWRH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 7) = "ZXRNYXRjaFBsYXlEYXRhUnNwEI8IEhMKDkNtZExPS0FKR0ZNS0FLEMcIEhsK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 8) = "FkNtZEZpZ2h0R2FtZVN0YXRlU2NSc3AQ8gcSGQoUQ21kU2VsZlJhbmtDaGFu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 9) = "Z2VOdGYQ7AcSHgoZQ21kTWF0Y2hQbGF5RGF0YUNoYW5nZU50ZhDpBxIeChlD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 10) = "bWRGaWdodEdhbWVTdGFydFNjTm90aWZ5EPEHEhMKDkNtZERHRUVJTENNSEhF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 11) = "EPoHQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray12<string>, string>(in buffer, 12))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdMultiplayerType) }, null, null));
	}
}
