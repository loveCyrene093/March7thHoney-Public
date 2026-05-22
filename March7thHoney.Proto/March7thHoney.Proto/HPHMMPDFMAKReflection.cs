using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HPHMMPDFMAKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HPHMMPDFMAKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIUEhNTVBERk1BSy5wcm90bxoRREtER0dHQ0RBR00ucHJvdG8iOQoLSFBI" + "TU1QREZNQUsSDAoEc2xvdBgDIAEoDRIcCgZsaW5ldXAYDyABKAsyDC5ES0RH" + "R0dDREFHTUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { DKDGGGCDAGMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HPHMMPDFMAK), HPHMMPDFMAK.Parser, new string[2] { "Slot", "Lineup" }, null, null, null, null)
		}));
	}
}
