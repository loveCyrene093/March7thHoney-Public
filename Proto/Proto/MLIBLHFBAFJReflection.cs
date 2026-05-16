using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MLIBLHFBAFJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MLIBLHFBAFJReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFNTElCTEhGQkFGSi5wcm90byq7AQoLTUxJQkxIRkJBRkoSGwoXTUxJQkxI";
		buffer[1] = "RkJBRkpfUENQREhFTFBLRU0QABIbChdNTElCTEhGQkFGSl9NTUFPT05QQVBE";
		buffer[2] = "UBABEhsKF01MSUJMSEZCQUZKX0FDSkdIRU9NQk5CEAISGwoXTUxJQkxIRkJB";
		buffer[3] = "RkpfSklETUdQT0tMUEsQAxIbChdNTElCTEhGQkFGSl9CTktITEFHTUxNSRAE";
		buffer[4] = "EhsKF01MSUJMSEZCQUZKX0xKT0pOTkNGTUlBEAVCFqoCE01hcmNoN3RoSG9u";
		buffer[5] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(MLIBLHFBAFJ) }, null, null));
	}
}
