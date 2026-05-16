using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CEOELEOKPOFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CEOELEOKPOFReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFDRU9FTEVPS1BPRi5wcm90bxoRQ0lNQ0RDQk5OS0oucHJvdG8i1QEKC0NF";
		buffer[1] = "T0VMRU9LUE9GEg8KB3Jvb21faWQYASABKAQSEwoLSENQQktBTEtHR0wYAiAB";
		buffer[2] = "KA0SEwoLQkVGSkxGS0pGSkQYAyABKA0SEwoLQ0VMTkNQQ1BNSEEYBCABKA0S";
		buffer[3] = "GwoTbW9uc3Rlcl9iYXR0bGVfdHlwZRgFIAEoDRITCgtFRUpDSU9HSEZDSxgG";
		buffer[4] = "IAEoDRIhCgtGS0VIT0dNR0xKRhgHIAEoCzIMLkNJTUNEQ0JOTktKEiEKC0RD";
		buffer[5] = "SkJGQ1BHTkFKGAggASgLMgwuQ0lNQ0RDQk5OS0pCFqoCE01hcmNoN3RoSG9u";
		buffer[6] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { CIMCDCBNNKJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CEOELEOKPOF), CEOELEOKPOF.Parser, new string[8] { "RoomId", "HCPBKALKGGL", "BEFJLFKJFJD", "CELNCPCPMHA", "MonsterBattleType", "EEJCIOGHFCK", "FKEHOGMGLJF", "DCJBFCPGNAJ" }, null, null, null, null)
		}));
	}
}
