using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PunkLordBattleResultScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PunkLordBattleResultScNotifyReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "CiJQdW5rTG9yZEJhdHRsZVJlc3VsdFNjTm90aWZ5LnByb3RvGhFQSE9DRUNK";
		buffer[1] = "T0JISC5wcm90bxoeUHVua0xvcmRNb25zdGVyQmFzaWNJbmZvLnByb3RvIrAB";
		buffer[2] = "ChxQdW5rTG9yZEJhdHRsZVJlc3VsdFNjTm90aWZ5Ei4KC0ZGQ0RQSE1KSktH";
		buffer[3] = "GAIgASgLMhkuUHVua0xvcmRNb25zdGVyQmFzaWNJbmZvEiEKC0ZIUE9JTElN";
		buffer[4] = "S0lJGAggASgLMgwuUEhPQ0VDSk9CSEgSEwoLUERCTkdOQUJESkkYCyABKA0S";
		buffer[5] = "EwoLR0dIQ0ZNT0xETkkYDCABKA0SEwoLTUhESkpETkhJTEsYDyABKA1CFqoC";
		buffer[6] = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			PHOCECJOBHHReflection.Descriptor,
			PunkLordMonsterBasicInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PunkLordBattleResultScNotify), PunkLordBattleResultScNotify.Parser, new string[5] { "FFCDPHMJJKG", "FHPOILIMKII", "PDBNGNABDJI", "GGHCFMOLDNI", "MHDJJDNHILK" }, null, null, null, null)
		}));
	}
}
