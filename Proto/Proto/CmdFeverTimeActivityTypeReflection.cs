using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdFeverTimeActivityTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdFeverTimeActivityTypeReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "Ch5DbWRGZXZlclRpbWVBY3Rpdml0eVR5cGUucHJvdG8qhQIKGENtZEZldmVy";
		buffer[1] = "VGltZUFjdGl2aXR5VHlwZRIbChdBSUVMT0hCQ09QR19QQ1BESEVMUEtFTRAA";
		buffer[2] = "EioKJUNtZEZldmVyVGltZUFjdGl2aXR5QmF0dGxlRW5kU2NOb3RpZnkQ7zcS";
		buffer[3] = "KAojQ21kRW50ZXJGZXZlclRpbWVBY3Rpdml0eVN0YWdlU2NSc3AQ+DcSJQog";
		buffer[4] = "Q21kR2V0RmV2ZXJUaW1lQWN0aXZpdHlEYXRhU2NSc3AQ8zcSKAojQ21kRW50";
		buffer[5] = "ZXJGZXZlclRpbWVBY3Rpdml0eVN0YWdlQ3NSZXEQ9zcSJQogQ21kR2V0RmV2";
		buffer[6] = "ZXJUaW1lQWN0aXZpdHlEYXRhQ3NSZXEQ9TdCFqoCE01hcmNoN3RoSG9uZXku";
		buffer[7] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdFeverTimeActivityType) }, null, null));
	}
}
