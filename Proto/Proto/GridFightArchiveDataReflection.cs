using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightArchiveDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightArchiveDataReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChpHcmlkRmlnaHRBcmNoaXZlRGF0YS5wcm90bxoZR3JpZEZpZ2h0RmluaXNo";
		buffer[1] = "SW5mby5wcm90byK6AQoUR3JpZEZpZ2h0QXJjaGl2ZURhdGESEwoLQUpNQk9M";
		buffer[2] = "SERHSEsYAiABKA0SEwoLUERMQkVDSERKQkwYBiABKAgSDgoGc2Vhc29uGAkg";
		buffer[3] = "ASgNEhMKC0JNUENDUENDSkpPGAwgASgNEikKC0VES0pNUEFDSE5KGA0gASgL";
		buffer[4] = "MhQuR3JpZEZpZ2h0RmluaXNoSW5mbxITCgtDQUxJTUFLR0dIShgOIAEoDRIT";
		buffer[5] = "CgtES0NGSk5EQ0JFUBgPIAEoA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[6] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GridFightFinishInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightArchiveData), GridFightArchiveData.Parser, new string[7] { "AJMBOLHDGHK", "PDLBECHDJBL", "Season", "BMPCCPCCJJO", "EDKJMPACHNJ", "CALIMAKGGHJ", "DKCFJNDCBEP" }, null, null, null, null)
		}));
	}
}
