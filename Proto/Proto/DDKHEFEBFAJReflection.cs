using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DDKHEFEBFAJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DDKHEFEBFAJReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFEREtIRUZFQkZBSi5wcm90byq7AQoLRERLSEVGRUJGQUoSGwoXRERLSEVG";
		buffer[1] = "RUJGQUpfUENQREhFTFBLRU0QABIbChdEREtIRUZFQkZBSl9KTEVJTE9HTEpO";
		buffer[2] = "ShABEhsKF0RES0hFRkVCRkFKX0VISEhCSUdCS1BFEAISGwoXRERLSEVGRUJG";
		buffer[3] = "QUpfTEpNRUVLSE9FRUYQAxIbChdEREtIRUZFQkZBSl9IRk9BRklPRkhGTxAE";
		buffer[4] = "EhsKF0RES0hFRkVCRkFKX0hCSUtQUEtBTkNIEAVCFqoCE01hcmNoN3RoSG9u";
		buffer[5] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(DDKHEFEBFAJ) }, null, null));
	}
}
