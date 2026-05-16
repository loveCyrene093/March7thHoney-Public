using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DFLMKFIFHKBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DFLMKFIFHKBReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFERkxNS0ZJRkhLQi5wcm90bxoRSUNJS0hOS0VFTEoucHJvdG8ifgoLREZM";
		buffer[1] = "TUtGSUZIS0ISIQoLRUZJSkRFQkZGTkYYAiADKAsyDC5JQ0lLSE5LRUVMShIU";
		buffer[2] = "CgxkaWNlX3Nsb3RfaWQYBiABKA0SEwoLQk9JTk1KSkVCQkUYByABKAkSDAoE";
		buffer[3] = "bmFtZRgIIAEoCRITCgtMRU5DTEpQS0RBTxgJIAEoDEIWqgITTWFyY2g3dGhI";
		buffer[4] = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ICIKHNKEELJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DFLMKFIFHKB), DFLMKFIFHKB.Parser, new string[5] { "EFIJDEBFFNF", "DiceSlotId", "BOINMJJEBBE", "Name", "LENCLJPKDAO" }, null, null, null, null)
		}));
	}
}
