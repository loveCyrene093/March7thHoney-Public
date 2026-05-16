using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DFJGPODAKAMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DFJGPODAKAMReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFERkpHUE9EQUtBTS5wcm90bxoRQVBDTkxGQU5QRVAucHJvdG8aEUNNSEFN";
		buffer[1] = "QktDSkJLLnByb3RvIvMBCgtERkpHUE9EQUtBTRITCgtJTEVNTUtQR1BORBgB";
		buffer[2] = "IAEoDRITCgtOS0dJR0tFQk9ERxgCIAMoDRIvChlncmlkX2ZpZ2h0X2VxdWlw";
		buffer[3] = "bWVudF9saXN0GAMgAygLMgwuQVBDTkxGQU5QRVASMgoLT1BMSkRGT09NR0YY";
		buffer[4] = "BCADKAsyHS5ERkpHUE9EQUtBTS5PUExKREZPT01HRkVudHJ5EiEKC0ZESk1K";
		buffer[5] = "T0tHT01GGAUgAygLMgwuQ01IQU1CS0NKQksaMgoQT1BMSkRGT09NR0ZFbnRy";
		buffer[6] = "eRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKAU6AjgBQhaqAhNNYXJjaDd0";
		buffer[7] = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			APCNLFANPEPReflection.Descriptor,
			CMHAMBKCJBKReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DFJGPODAKAM), DFJGPODAKAM.Parser, new string[5] { "ILEMMKPGPND", "NKGIGKEBODG", "GridFightEquipmentList", "OPLJDFOOMGF", "FDJMJOKGOMF" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
