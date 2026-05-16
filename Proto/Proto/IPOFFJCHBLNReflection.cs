using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IPOFFJCHBLNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IPOFFJCHBLNReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFJUE9GRkpDSEJMTi5wcm90byqSAgoLSVBPRkZKQ0hCTE4SGwoXSVBPRkZK";
		buffer[1] = "Q0hCTE5fUENQREhFTFBLRU0QABIbChdJUE9GRkpDSEJMTl9FT1BEQUZLTVBL";
		buffer[2] = "TBABEhsKF0lQT0ZGSkNIQkxOX0ZMTUdGSFBBRkJMEAISGwoXSVBPRkZKQ0hC";
		buffer[3] = "TE5fQVBBS0xHTEpFQk0QAxIbChdJUE9GRkpDSEJMTl9BSUxNRU1NSE9BShAE";
		buffer[4] = "EhsKF0lQT0ZGSkNIQkxOX0pMS0lERUlETU5LEAUSGwoXSVBPRkZKQ0hCTE5f";
		buffer[5] = "T0tCTU1LSkdQT0wQBhIbChdJUE9GRkpDSEJMTl9HR09ET0RMTk9MQRAHEhsK";
		buffer[6] = "F0lQT0ZGSkNIQkxOX0tOT0FNRkFOSUVMEAhCFqoCE01hcmNoN3RoSG9uZXku";
		buffer[7] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(IPOFFJCHBLN) }, null, null));
	}
}
