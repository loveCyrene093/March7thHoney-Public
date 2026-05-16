using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdFantasticStoryActivityTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdFantasticStoryActivityTypeReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "CiNDbWRGYW50YXN0aWNTdG9yeUFjdGl2aXR5VHlwZS5wcm90byqzAgodQ21k";
		buffer[1] = "RmFudGFzdGljU3RvcnlBY3Rpdml0eVR5cGUSGwoXUEdFS0pJRURISERfUENQ";
		buffer[2] = "REhFTFBLRU0QABIvCipDbWRGYW50YXN0aWNTdG9yeUFjdGl2aXR5QmF0dGxl";
		buffer[3] = "RW5kU2NOb3RpZnkQtiYSKAojQ21kRW50ZXJBY3Rpdml0eUZhbnRhc3RpY1N0";
		buffer[4] = "b3J5Q3NSZXEQgycSEwoOQ21kTkRLS0FHS0NGR0gQgicSLQooQ21kRW50ZXJG";
		buffer[5] = "YW50YXN0aWNTdG9yeUFjdGl2aXR5U3RhZ2VTY1JzcBCyJhIqCiVDbWRHZXRG";
		buffer[6] = "YW50YXN0aWNTdG9yeUFjdGl2aXR5RGF0YVNjUnNwEK4mEioKJUNtZEdldEZh";
		buffer[7] = "bnRhc3RpY1N0b3J5QWN0aXZpdHlEYXRhQ3NSZXEQ/yZCFqoCE01hcmNoN3Ro";
		buffer[8] = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdFantasticStoryActivityType) }, null, null));
	}
}
