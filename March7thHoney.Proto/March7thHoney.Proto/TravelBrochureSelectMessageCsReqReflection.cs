using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TravelBrochureSelectMessageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TravelBrochureSelectMessageCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZUcmF2ZWxCcm9jaHVyZVNlbGVjdE1lc3NhZ2VDc1JlcS5wcm90byJMCiBU" + "cmF2ZWxCcm9jaHVyZVNlbGVjdE1lc3NhZ2VDc1JlcRITCgtESUNFUENHRkJO" + "TxgEIAEoDRITCgtIQkNKUENNSlBIRRgOIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TravelBrochureSelectMessageCsReq), TravelBrochureSelectMessageCsReq.Parser, new string[2] { "DICEPCGFBNO", "HBCJPCMJPHE" }, null, null, null, null)
		}));
	}
}
