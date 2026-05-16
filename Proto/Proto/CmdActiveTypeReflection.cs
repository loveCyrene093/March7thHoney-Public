using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdActiveTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdActiveTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChNDbWRBY3RpdmVUeXBlLnByb3RvKuwBCg1DbWRBY3RpdmVUeXBlEhsKF0RP";
		buffer[1] = "SUxQRFBFTkxKX1BDUERIRUxQS0VNEAASIgodQ21kR2V0QWN0aXZlQWN0aXZp";
		buffer[2] = "dHlEYXRhU2NSc3AQ4koSKAojQ21kQWN0aXZlQWN0aXZpdHlEYXRhQ2hhbmdl";
		buffer[3] = "U2NOb3RpZnkQ3UoSJQogQ21kVGFrZUFjdGl2ZUFjdGl2aXR5UmV3YXJkQ3NS";
		buffer[4] = "ZXEQ0EoSIgodQ21kR2V0QWN0aXZpdHlBY3RpdmVEYXRhQ3NSZXEQz0oSJQog";
		buffer[5] = "Q21kVGFrZUFjdGl2ZUFjdGl2aXR5UmV3YXJkU2NSc3AQ2EpCFqoCE01hcmNo";
		buffer[6] = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdActiveType) }, null, null));
	}
}
