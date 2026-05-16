using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DKBCDGFJADMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DKBCDGFJADMReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFES0JDREdGSkFETS5wcm90bxoRTUhNRkFNSEhKQUEucHJvdG8aEU9JREhB";
		buffer[1] = "R05HS0xHLnByb3RvIqMBCgtES0JDREdGSkFETRITCgtETUhMTEtCTUhFTBgE";
		buffer[2] = "IAEoDRIhCgtGUEhHSEFQR05BRRgGIAEoDjIMLk1ITUZBTUhISkFBEg8KB2l0";
		buffer[3] = "ZW1faWQYCiABKA0SEwoLTUFHUEFPTkpPQkQYDSABKA0SIQoLQk1OREJLQkhJ";
		buffer[4] = "T0MYDiABKAsyDC5PSURIQUdOR0tMRxITCgtOSlBDTUROSE9GTBgPIAEoDUIW";
		buffer[5] = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			MHMFAMHHJAAReflection.Descriptor,
			OIDHAGNGKLGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DKBCDGFJADM), DKBCDGFJADM.Parser, new string[6] { "DMHLLKBMHEL", "FPHGHAPGNAE", "ItemId", "MAGPAONJOBD", "BMNDBKBHIOC", "NJPCMDNHOFL" }, null, null, null, null)
		}));
	}
}
