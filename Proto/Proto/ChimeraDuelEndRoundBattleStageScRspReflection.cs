using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelEndRoundBattleStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelEndRoundBattleStageScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "CilDaGltZXJhRHVlbEVuZFJvdW5kQmF0dGxlU3RhZ2VTY1JzcC5wcm90bxoR";
		buffer[1] = "RENJRlBJQ1BKTUsucHJvdG8aEURESk9FSUJPRUxILnByb3RvGhFIT0JDSU9L";
		buffer[2] = "S05LSC5wcm90byK0AQojQ2hpbWVyYUR1ZWxFbmRSb3VuZEJhdHRsZVN0YWdl";
		buffer[3] = "U2NSc3ASDwoHcmV0Y29kZRgMIAEoDRIhCgtLR0VCSk5IT0xDThgOIAEoDjIM";
		buffer[4] = "LkRDSUZQSUNQSk1LEiQKC09JQVBIQkJEUEhMGMAIIAEoCzIMLkRESk9FSUJP";
		buffer[5] = "RUxISAASJAoLQ0tJTU9FTFBPQUIY3Q8gASgLMgwuSE9CQ0lPS0tOS0hIAEIN";
		buffer[6] = "CgtCUElIRkFKQ0xPQ0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			DCIFPICPJMKReflection.Descriptor,
			DDJOEIBOELHReflection.Descriptor,
			HOBCIOKKNKHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelEndRoundBattleStageScRsp), ChimeraDuelEndRoundBattleStageScRsp.Parser, new string[4] { "Retcode", "KGEBJNHOLCN", "OIAPHBBDPHL", "CKIMOELPOAB" }, new string[1] { "BPIHFAJCLOC" }, null, null, null)
		}));
	}
}
