using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FiveDimGameDataUpdateScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FiveDimGameDataUpdateScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiNGaXZlRGltR2FtZURhdGFVcGRhdGVTY05vdGlmeS5wcm90bxoRS0FJRUxK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "UE1HSEwucHJvdG8icwodRml2ZURpbUdhbWVEYXRhVXBkYXRlU2NOb3RpZnkS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "GgoSY2xpZW50X3Bvc192ZXJzaW9uGAwgASgNEiEKC09JQVBIQkJEUEhMGA4g";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "ASgLMgwuS0FJRUxKUE1HSEwSEwoLUEJPQkJQRUtCTEsYDyABKAhCFqoCE01h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { KAIELJPMGHLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FiveDimGameDataUpdateScNotify), FiveDimGameDataUpdateScNotify.Parser, new string[3] { "ClientPosVersion", "OIAPHBBDPHL", "PBOBBPEKBLK" }, null, null, null, null)
		}));
	}
}
