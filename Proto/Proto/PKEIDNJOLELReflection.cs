using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PKEIDNJOLELReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PKEIDNJOLELReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFQS0VJRE5KT0xFTC5wcm90bxoRRkhCTkROTktET04ucHJvdG8aGkxvYmJ5";
		buffer[1] = "Q2hhcmFjdGVyU3RhdHVzLnByb3RvIlcKC1BLRUlETkpPTEVMEiEKC0hCQ01Q";
		buffer[2] = "T0xJS0hHGAEgASgOMgwuRkhCTkROTktET04SJQoGc3RhdHVzGAIgASgOMhUu";
		buffer[3] = "TG9iYnlDaGFyYWN0ZXJTdGF0dXNCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[4] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			FHBNDNNKDONReflection.Descriptor,
			LobbyCharacterStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PKEIDNJOLEL), PKEIDNJOLEL.Parser, new string[2] { "HBCMPOLIKHG", "Status" }, null, null, null, null)
		}));
	}
}
