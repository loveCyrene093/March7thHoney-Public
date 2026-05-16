using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ELEOGABGBKGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ELEOGABGBKGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFTEVPR0FCR0JLRy5wcm90byI3CgtFTEVPR0FCR0JLRxITCgtETUVLSUZK" + "REtGTBgJIAEoDRITCgtDRUxGR0NKRk1QSBgKIAMoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ELEOGABGBKG), ELEOGABGBKG.Parser, new string[2] { "DMEKIFJDKFL", "CELFGCJFMPH" }, null, null, null, null)
		}));
	}
}
