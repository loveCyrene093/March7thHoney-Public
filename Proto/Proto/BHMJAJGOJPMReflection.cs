using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BHMJAJGOJPMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BHMJAJGOJPMReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFCSE1KQUpHT0pQTS5wcm90bxoRQUhPTE9IQ0xMS0QucHJvdG8aEUhIQUFO";
		buffer[1] = "Qk5DTEhJLnByb3RvGhFJR0pKRk9LQUhBUC5wcm90bxoQTGluZXVwSW5mby5w";
		buffer[2] = "cm90byKYAQoLQkhNSkFKR09KUE0SIQoLS0tMSEdDSktQTEoYAyABKAsyDC5I";
		buffer[3] = "SEFBTkJOQ0xISRIhCgtISERMRUFEQkpHThgGIAEoCzIMLkFIT0xPSENMTEtE";
		buffer[4] = "EiAKC0xCTkhLUFBBSklNGAogASgLMgsuTGluZXVwSW5mbxIhCgtOT0NORU9N";
		buffer[5] = "S0ZJTxgPIAEoCzIMLklHSkpGT0tBSEFQQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[6] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			AHOLOHCLLKDReflection.Descriptor,
			HHAANBNCLHIReflection.Descriptor,
			IGJJFOKAHAPReflection.Descriptor,
			LineupInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BHMJAJGOJPM), BHMJAJGOJPM.Parser, new string[4] { "KKLHGCJKPLJ", "HHDLEADBJGN", "LBNHKPPAJIM", "NOCNEOMKFIO" }, null, null, null, null)
		}));
	}
}
