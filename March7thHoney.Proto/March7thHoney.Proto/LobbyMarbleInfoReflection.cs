using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LobbyMarbleInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LobbyMarbleInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVMb2JieU1hcmJsZUluZm8ucHJvdG8iWwoPTG9iYnlNYXJibGVJbmZvEhMK" + "C1BKQ0dBSlBET0JOGAEgASgNEgwKBHJhbmsYAiABKA0SEwoLQU9QSlBDUE5B" + "Q0gYAyADKA0SEAoIc2NvcmVfaWQYBCABKA1CFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LobbyMarbleInfo), LobbyMarbleInfo.Parser, new string[4] { "PJCGAJPDOBN", "Rank", "AOPJPCPNACH", "ScoreId" }, null, null, null, null)
		}));
	}
}
