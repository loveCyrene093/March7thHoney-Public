using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ECNCEKBIDPBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ECNCEKBIDPBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFQ05DRUtCSURQQi5wcm90byJwCgtFQ05DRUtCSURQQhITCgtCT0lOTUpK" + "RUJCRRgCIAEoCRIMCgRuYW1lGAMgASgJEhQKDGRpY2Vfc2xvdF9pZBgEIAEo" + "DRITCgtMRU5DTEpQS0RBTxgNIAEoDBITCgtDRUxIQ0RBQkZDTBgOIAEoCEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ECNCEKBIDPB), ECNCEKBIDPB.Parser, new string[5] { "BOINMJJEBBE", "Name", "DiceSlotId", "LENCLJPKDAO", "CELHCDABFCL" }, null, null, null, null)
		}));
	}
}
