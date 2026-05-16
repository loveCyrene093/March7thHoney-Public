using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdInteractiveTriggerMazeBuffTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdInteractiveTriggerMazeBuffTypeReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CidDbWRJbnRlcmFjdGl2ZVRyaWdnZXJNYXplQnVmZlR5cGUucHJvdG8qagoh";
		buffer[1] = "Q21kSW50ZXJhY3RpdmVUcmlnZ2VyTWF6ZUJ1ZmZUeXBlEhsKF0NPQ05CTU1G";
		buffer[2] = "TElJX1BDUERIRUxQS0VNEAASEwoOQ21kQ09FT0hFQkZJQ08Qh0oSEwoOQ21k";
		buffer[3] = "SkhJQUdMR1BNQkQQiEpCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdInteractiveTriggerMazeBuffType) }, null, null));
	}
}
