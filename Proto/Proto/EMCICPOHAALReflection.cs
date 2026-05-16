using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EMCICPOHAALReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EMCICPOHAALReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFTUNJQ1BPSEFBTC5wcm90byIiCgtFTUNJQ1BPSEFBTBITCgtIUE1IQUNC" + "Tk9PSxgEIAEoBUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EMCICPOHAAL), EMCICPOHAAL.Parser, new string[1] { "HPMHACBNOOK" }, null, null, null, null)
		}));
	}
}
