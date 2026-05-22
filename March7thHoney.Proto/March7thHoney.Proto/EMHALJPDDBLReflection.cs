using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EMHALJPDDBLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EMHALJPDDBLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFTUhBTEpQRERCTC5wcm90byJ2CgtFTUhBTEpQRERCTBITCgtITkZOT0tJ" + "TE5GRRgEIAEoCBITCgtET0hMTE1MRExNUBgHIAMoDRITCgtMQlBMTkxESENC" + "TxgJIAEoCBITCgtHUEpISk9PSUpKQxgMIAEoDRITCgtHSUFPSU1PRkFMSBgN" + "IAEoBEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EMHALJPDDBL), EMHALJPDDBL.Parser, new string[5] { "HNFNOKILNFE", "DOHLLMLDLMP", "LBPLNLDHCBO", "GPJHJOOIJJC", "GIAOIMOFALH" }, null, null, null, null)
		}));
	}
}
