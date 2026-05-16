using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NCCLJBCHBBPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NCCLJBCHBBPReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFOQ0NMSkJDSEJCUC5wcm90byq7AQoLTkNDTEpCQ0hCQlASGwoXTkNDTEpC";
		buffer[1] = "Q0hCQlBfT0ZQRlBCSElBTUIQABIbChdOQ0NMSkJDSEJCUF9QUENMQ0ZGR0hG";
		buffer[2] = "QhABEhsKF05DQ0xKQkNIQkJQX0RLQ05QQ0ZCTUlGEAISGwoXTkNDTEpCQ0hC";
		buffer[3] = "QlBfRkxCT0RFREdPRlAQAxIbChdOQ0NMSkJDSEJCUF9OQ0pQRUdOSkhGSxAE";
		buffer[4] = "EhsKF05DQ0xKQkNIQkJQX0tERk1LRUtGQUlIEAVCFqoCE01hcmNoN3RoSG9u";
		buffer[5] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(NCCLJBCHBBP) }, null, null));
	}
}
