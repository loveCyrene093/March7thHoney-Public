using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HLDONLICNOBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HLDONLICNOBReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFITERPTkxJQ05PQi5wcm90byq7AQoLSExET05MSUNOT0ISGwoXSExET05M";
		buffer[1] = "SUNOT0JfTU5FTEhNRUJIUEsQABIbChdITERPTkxJQ05PQl9OTUlITk1BUEtH";
		buffer[2] = "SRABEhsKF0hMRE9OTElDTk9CX01IQ01NT1BQQUxKEAISGwoXSExET05MSUNO";
		buffer[3] = "T0JfT0pHRUlDQk9HSlAQAxIbChdITERPTkxJQ05PQl9CTEpNSkhQSEVBRhAE";
		buffer[4] = "EhsKF0hMRE9OTElDTk9CX0ZNUEVGR0pQSEtDEAVCFqoCE01hcmNoN3RoSG9u";
		buffer[5] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(HLDONLICNOB) }, null, null));
	}
}
