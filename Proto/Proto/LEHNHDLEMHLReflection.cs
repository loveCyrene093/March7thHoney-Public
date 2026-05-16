using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LEHNHDLEMHLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LEHNHDLEMHLReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFMRUhOSERMRU1ITC5wcm90bxoRQkNNTUxBREJFQU0ucHJvdG8ihwEKC0xF";
		buffer[1] = "SE5IRExFTUhMEhMKC05BSkNQT1BKR0xCGAIgASgFEgoKAmlkGAMgASgNEgoK";
		buffer[2] = "AmhwGAUgASgFEiEKC01QTElOQ0FET0RLGAYgASgLMgwuQkNNTUxBREJFQU0S";
		buffer[3] = "EwoLS0FFQkNOTkFLSUQYDSABKAgSEwoLQk1HQUJBSExHSkkYDiADKA1CFqoC";
		buffer[4] = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { BCMMLADBEAMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LEHNHDLEMHL), LEHNHDLEMHL.Parser, new string[6] { "NAJCPOPJGLB", "Id", "Hp", "MPLINCADODK", "KAEBCNNAKID", "BMGABAHLGJI" }, null, null, null, null)
		}));
	}
}
