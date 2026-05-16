using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KCEHEAGEDAAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KCEHEAGEDAAReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFLQ0VIRUFHRURBQS5wcm90bxoOSXRlbUxpc3QucHJvdG8ioQEKC0tDRUhF";
		buffer[1] = "QUdFREFBEhAKCHByb2dyZXNzGAEgASgNEhMKC0VGRE1FTENGSUtKGAIgASgN";
		buffer[2] = "EhEKCXNjcmlwdF9pZBgGIAEoDRITCgtIRktCSkxBTUpMRxgIIAEoCBITCgtE";
		buffer[3] = "Q1BLUE5MS0dNTRgJIAEoDRIZCgZyZXdhcmQYCyABKAsyCS5JdGVtTGlzdBIT";
		buffer[4] = "CgtESU9IS01QUEtIQRgOIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[5] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KCEHEAGEDAA), KCEHEAGEDAA.Parser, new string[7] { "Progress", "EFDMELCFIKJ", "ScriptId", "HFKBJLAMJLG", "DCPKPNLKGMM", "Reward", "DIOHKMPPKHA" }, null, null, null, null)
		}));
	}
}
