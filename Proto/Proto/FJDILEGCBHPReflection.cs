using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FJDILEGCBHPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FJDILEGCBHPReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFGSkRJTEVHQ0JIUC5wcm90byq7AQoLRkpESUxFR0NCSFASGwoXRkpESUxF";
		buffer[1] = "R0NCSFBfUENQREhFTFBLRU0QABIbChdGSkRJTEVHQ0JIUF9NSExKTUpGRFBH";
		buffer[2] = "ShABEhsKF0ZKRElMRUdDQkhQX1BKSUdITkZIRktEEAISGwoXRkpESUxFR0NC";
		buffer[3] = "SFBfS0NOT0tNRE9QSkIQAxIbChdGSkRJTEVHQ0JIUF9MT0VISExCSkFDRhAE";
		buffer[4] = "EhsKF0ZKRElMRUdDQkhQX0JNS0FFRkFLTkZKEAVCFqoCE01hcmNoN3RoSG9u";
		buffer[5] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(FJDILEGCBHP) }, null, null));
	}
}
