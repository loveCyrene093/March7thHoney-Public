using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LGNEOKBPPEOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LGNEOKBPPEOReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFMR05FT0tCUFBFTy5wcm90byq7AQoLTEdORU9LQlBQRU8SGwoXTEdORU9L";
		buffer[1] = "QlBQRU9fUENQREhFTFBLRU0QABIbChdMR05FT0tCUFBFT19HTEVNSEVDTE1H";
		buffer[2] = "UBABEhsKF0xHTkVPS0JQUEVPX0pQQUFQTU5LSUVGEAISGwoXTEdORU9LQlBQ";
		buffer[3] = "RU9fSkhCSUtDUExGRkoQAxIbChdMR05FT0tCUFBFT19CQ0RIT0ZOTVBORxAE";
		buffer[4] = "EhsKF0xHTkVPS0JQUEVPX0NNSEhCUE9IQUhKEAVCFqoCE01hcmNoN3RoSG9u";
		buffer[5] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(LGNEOKBPPEO) }, null, null));
	}
}
