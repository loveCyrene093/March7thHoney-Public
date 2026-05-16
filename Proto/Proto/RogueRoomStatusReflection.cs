using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueRoomStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueRoomStatusReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChVSb2d1ZVJvb21TdGF0dXMucHJvdG8qogEKD1JvZ3VlUm9vbVN0YXR1cxIb";
		buffer[1] = "ChdMSUJER01NT0lMSV9QQ1BESEVMUEtFTRAAEhsKF0xJQkRHTU1PSUxJX0RL";
		buffer[2] = "TFBBQUZGTEVFEAESGwoXTElCREdNTU9JTElfTkdNTUlDT0dERlAQAhIbChdM";
		buffer[3] = "SUJER01NT0lMSV9MQUVJRENQS0xDRBADEhsKF0xJQkRHTU1PSUxJX0tMSERD";
		buffer[4] = "T1BQTE5HEARCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(RogueRoomStatus) }, null, null));
	}
}
