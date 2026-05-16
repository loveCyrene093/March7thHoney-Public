using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MADEENABOKEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MADEENABOKEReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChFNQURFRU5BQk9LRS5wcm90bxoRQ2hhcmdlckluZm8ucHJvdG8aE1JvdGF0";
		buffer[1] = "ZU1hcEluZm8ucHJvdG8aEVJvdGF0ZXJEYXRhLnByb3RvGhdSb3RhdGVyRW5l";
		buffer[2] = "cmd5SW5mby5wcm90byLgAQoLTUFERUVOQUJPS0USIQoLR1BLQUJJQktKSEYY";
		buffer[3] = "AiADKAsyDC5DaGFyZ2VySW5mbxInCgtlbmVyZ3lfaW5mbxgEIAEoCzISLlJv";
		buffer[4] = "dGF0ZXJFbmVyZ3lJbmZvEhMKC0pIRExOQlBORUtHGAUgASgFEiEKC0RKSERE";
		buffer[5] = "T0ZITUNGGAYgAygLMgwuUm90YXRlckRhdGESEwoLQU9MRkZPTEVKTEIYCyAB";
		buffer[6] = "KAgSEwoLQkNQQ0JITUZJSU4YDSABKA0SIwoLQU1NSkVDSFBHUEUYDyABKAsy";
		buffer[7] = "Di5Sb3RhdGVNYXBJbmZvQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[8] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			ChargerInfoReflection.Descriptor,
			RotateMapInfoReflection.Descriptor,
			RotaterDataReflection.Descriptor,
			RotaterEnergyInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MADEENABOKE), MADEENABOKE.Parser, new string[7] { "GPKABIBKJHF", "EnergyInfo", "JHDLNBPNEKG", "DJHDDOFHMCF", "AOLFFOLEJLB", "BCPCBHMFIIN", "AMMJECHPGPE" }, null, null, null, null)
		}));
	}
}
