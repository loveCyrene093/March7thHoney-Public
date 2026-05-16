using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdMatchTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdMatchTypeReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChJDbWRNYXRjaFR5cGUucHJvdG8q0wEKDENtZE1hdGNoVHlwZRIbChdQQ0dG";
		buffer[1] = "TFBDTkNMTV9QQ1BESEVMUEtFTRAAEhkKFENtZEdldENyb3NzSW5mb0NzUmVx";
		buffer[2] = "EKo5EhgKE0NtZENhbmNlbE1hdGNoQ3NSZXEQojkSFwoSQ21kU3RhcnRNYXRj";
		buffer[3] = "aENzUmVxEJE5EhMKDkNtZEFBSENNTUtNRU5BEIs5EhMKDkNtZEpPTERKQktN";
		buffer[4] = "SEdBEJ85EhkKFENtZEdldENyb3NzSW5mb1NjUnNwEIk5EhMKDkNtZEpPRVBK";
		buffer[5] = "SktJUEpDEKc5QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdMatchType) }, null, null));
	}
}
