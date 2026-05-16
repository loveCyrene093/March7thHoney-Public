using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MMFFHGPBALOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MMFFHGPBALOReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFNTUZGSEdQQkFMTy5wcm90bxoRSUNJS0hOS0VFTEoucHJvdG8ifgoLTU1G";
		buffer[1] = "RkhHUEJBTE8SEwoLTEVOQ0xKUEtEQU8YBCABKAwSFAoMZGljZV9zbG90X2lk";
		buffer[2] = "GAUgASgNEgwKBG5hbWUYCSABKAkSIQoLRUZJSkRFQkZGTkYYDCADKAsyDC5J";
		buffer[3] = "Q0lLSE5LRUVMShITCgtCT0lOTUpKRUJCRRgNIAEoCUIWqgITTWFyY2g3dGhI";
		buffer[4] = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ICIKHNKEELJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MMFFHGPBALO), MMFFHGPBALO.Parser, new string[5] { "LENCLJPKDAO", "DiceSlotId", "Name", "EFIJDEBFFNF", "BOINMJJEBBE" }, null, null, null, null)
		}));
	}
}
