using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BuyNpcStuffScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BuyNpcStuffScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZCdXlOcGNTdHVmZlNjUnNwLnByb3RvIjgKEEJ1eU5wY1N0dWZmU2NSc3AS" + "DwoHcmV0Y29kZRgDIAEoDRITCgtHS0ZFR0lCR0VHSRgFIAEoDUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BuyNpcStuffScRsp), BuyNpcStuffScRsp.Parser, new string[2] { "Retcode", "GKFEGIBGEGI" }, null, null, null, null)
		}));
	}
}
