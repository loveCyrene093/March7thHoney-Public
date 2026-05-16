using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LobbySyncInfoScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LobbySyncInfoScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChtMb2JieVN5bmNJbmZvU2NOb3RpZnkucHJvdG8aEUFESE5KQURJSkFDLnBy";
		buffer[1] = "b3RvGhVMb2JieU1vZGlmeVR5cGUucHJvdG8iZwoVTG9iYnlTeW5jSW5mb1Nj";
		buffer[2] = "Tm90aWZ5Eh4KBHR5cGUYCCABKA4yEC5Mb2JieU1vZGlmeVR5cGUSCwoDdWlk";
		buffer[3] = "GAkgASgNEiEKC0JJRUJGSEVDRVBNGA0gAygLMgwuQURITkpBRElKQUNCFqoC";
		buffer[4] = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ADHNJADIJACReflection.Descriptor,
			LobbyModifyTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LobbySyncInfoScNotify), LobbySyncInfoScNotify.Parser, new string[3] { "Type", "Uid", "BIEBFHECEPM" }, null, null, null, null)
		}));
	}
}
