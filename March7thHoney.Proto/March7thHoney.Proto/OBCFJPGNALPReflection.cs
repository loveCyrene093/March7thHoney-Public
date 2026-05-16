using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OBCFJPGNALPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OBCFJPGNALPReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFPQkNGSlBHTkFMUC5wcm90byq7AQoLT0JDRkpQR05BTFASGwoXT0JDRkpQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "R05BTFBfUENQREhFTFBLRU0QABIbChdPQkNGSlBHTkFMUF9MREtOUEtLREtE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "UBACEhsKF09CQ0ZKUEdOQUxQX0pCQ09KTUdCSE1HEAQSGwoXT0JDRkpQR05B";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "TFBfTlBCS0xDSExKTUcQBRIbChdPQkNGSlBHTkFMUF9QQk9JUEpMQ09EShAG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "EhsKF09CQ0ZKUEdOQUxQX0JPRkxJT0hLUEtCEAdCFqoCE01hcmNoN3RoSG9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(OBCFJPGNALP) }, null, null));
	}
}
