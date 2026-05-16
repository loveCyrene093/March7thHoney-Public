using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CommonRogueUpdateScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CommonRogueUpdateScNotifyReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "Ch9Db21tb25Sb2d1ZVVwZGF0ZVNjTm90aWZ5LnByb3RvGhFCRkhOQ0ZER0NM";
		buffer[1] = "Ry5wcm90bxoRTEhPRU1DSEZPRkEucHJvdG8aEU5GSUtQRkJQT01GLnByb3Rv";
		buffer[2] = "IpkBChlDb21tb25Sb2d1ZVVwZGF0ZVNjTm90aWZ5EiMKC0ZDQVBCUEhMTkNK";
		buffer[3] = "GAQgASgLMgwuQkZITkNGREdDTEdIABIjCgtCTEFMTExOS0hBQxgGIAEoCzIM";
		buffer[4] = "Lk5GSUtQRkJQT01GSAASIwoLSk5LTUpNQUJQTVAYDiABKAsyDC5MSE9FTUNI";
		buffer[5] = "Rk9GQUgAQg0KC0tMQkpOTkpCT0FDQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[6] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			BFHNCFDGCLGReflection.Descriptor,
			LHOEMCHFOFAReflection.Descriptor,
			NFIKPFBPOMFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CommonRogueUpdateScNotify), CommonRogueUpdateScNotify.Parser, new string[3] { "FCAPBPHLNCJ", "BLALLLNKHAC", "JNKMJMABPMP" }, new string[1] { "KLBJNNJBOAC" }, null, null, null)
		}));
	}
}
