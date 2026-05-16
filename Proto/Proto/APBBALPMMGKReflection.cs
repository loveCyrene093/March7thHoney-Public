using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class APBBALPMMGKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static APBBALPMMGKReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFBUEJCQUxQTU1HSy5wcm90byq7AQoLQVBCQkFMUE1NR0sSGwoXQVBCQkFM";
		buffer[1] = "UE1NR0tfUENQREhFTFBLRU0QABIbChdBUEJCQUxQTU1HS19HSEdBUE9BS0dB";
		buffer[2] = "QhABEhsKF0FQQkJBTFBNTUdLX0JQQ0VLTUxQSkNKEAISGwoXQVBCQkFMUE1N";
		buffer[3] = "R0tfR1BKTUtLQURMREMQAxIbChdBUEJCQUxQTU1HS19DQkJIUEdBR0NPRRAE";
		buffer[4] = "EhsKF0FQQkJBTFBNTUdLX0pOQUFBSUdMSEhJEAVCFqoCE01hcmNoN3RoSG9u";
		buffer[5] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(APBBALPMMGK) }, null, null));
	}
}
