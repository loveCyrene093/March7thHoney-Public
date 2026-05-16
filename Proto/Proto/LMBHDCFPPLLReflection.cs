using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LMBHDCFPPLLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LMBHDCFPPLLReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		buffer[0] = "ChFMTUJIRENGUFBMTC5wcm90bxoRQ0pQRk5BRkxBUEQucHJvdG8aEURMR0xI";
		buffer[1] = "S0tJSkpLLnByb3RvGhFKSEZJRk5PRU1ESi5wcm90bxoRS0FCTEdBTEhNSE4u";
		buffer[2] = "cHJvdG8aEVBJQUpIR0RJR0ZGLnByb3RvGhFQUElIUERJUExMRC5wcm90byKL";
		buffer[3] = "AgoLTE1CSERDRlBQTEwSEwoLRUNOUEhKQkNMQkQYASADKA0SIQoLSkpCRUpF";
		buffer[4] = "RkRKSE8YAiABKAsyDC5LQUJMR0FMSE1IThITCgtJTUJPS0dGSUFDQRgEIAEo";
		buffer[5] = "DRIhCgtFTkhFSUJISEFJRBgGIAEoCzIMLkpIRklGTk9FTURKEiQKDnBlbmRp";
		buffer[6] = "bmdfYWN0aW9uGAcgASgLMgwuUElBSkhHRElHRkYSIQoLSUJDSUJOSEpERkUY";
		buffer[7] = "CSABKAsyDC5DSlBGTkFGTEFQRBIhCgtQS0NISU1CRUJQRRgKIAEoCzIMLlBQ";
		buffer[8] = "SUhQRElQTExEEiAKCnNraWxsX2luZm8YDiABKAsyDC5ETEdMSEtLSUpKS0IW";
		buffer[9] = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[6]
		{
			CJPFNAFLAPDReflection.Descriptor,
			DLGLHKKIJJKReflection.Descriptor,
			JHFIFNOEMDJReflection.Descriptor,
			KABLGALHMHNReflection.Descriptor,
			PIAJHGDIGFFReflection.Descriptor,
			PPIHPDIPLLDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LMBHDCFPPLL), LMBHDCFPPLL.Parser, new string[8] { "ECNPHJBCLBD", "JJBEJEFDJHO", "IMBOKGFIACA", "ENHEIBHHAID", "PendingAction", "IBCIBNHJDFE", "PKCHIMBEBPE", "SkillInfo" }, null, null, null, null)
		}));
	}
}
