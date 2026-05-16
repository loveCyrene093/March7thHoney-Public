using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NDCJAAOLEBAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NDCJAAOLEBAReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFORENKQUFPTEVCQS5wcm90bxoRQVBITEpQTEJPSUYucHJvdG8ikwEKC05E";
		buffer[1] = "Q0pBQU9MRUJBEjIKC0JCSkNNT0ZHQkZJGAcgAygLMh0uTkRDSkFBT0xFQkEu";
		buffer[2] = "QkJKQ01PRkdCRklFbnRyeRIcCgZzb3VyY2UYCSABKAsyDC5BUEhMSlBMQk9J";
		buffer[3] = "RhoyChBCQkpDTU9GR0JGSUVudHJ5EgsKA2tleRgBIAEoDRINCgV2YWx1ZRgC";
		buffer[4] = "IAEoAToCOAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { APHLJPLBOIFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NDCJAAOLEBA), NDCJAAOLEBA.Parser, new string[2] { "BBJCMOFGBFI", "Source" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
