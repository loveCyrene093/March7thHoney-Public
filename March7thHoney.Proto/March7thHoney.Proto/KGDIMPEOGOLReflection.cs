using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KGDIMPEOGOLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KGDIMPEOGOLReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFLR0RJTVBFT0dPTC5wcm90byq7AQoLS0dESU1QRU9HT0wSGwoXS0dESU1Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "RU9HT0xfSU1JSUdKQk1ET1AQABIbChdLR0RJTVBFT0dPTF9OUE5KREJLREZD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "TxABEhsKF0tHRElNUEVPR09MX0tOQ0pOSUhCSEVIEAISGwoXS0dESU1QRU9H";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "T0xfQUVNTU5IUE1HREkQAxIbChdLR0RJTVBFT0dPTF9CSktPTUhLTkNBRRAE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "EhsKF0tHRElNUEVPR09MX0FDTE5QQ0RHTUlCEAVCFqoCE01hcmNoN3RoSG9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(KGDIMPEOGOL) }, null, null));
	}
}
