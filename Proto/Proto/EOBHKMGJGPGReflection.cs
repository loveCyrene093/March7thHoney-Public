using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EOBHKMGJGPGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EOBHKMGJGPGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFT0JIS01HSkdQRy5wcm90byIiCgtFT0JIS01HSkdQRxITCgtBQkdMTklE" + "T0FETRgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EOBHKMGJGPG), EOBHKMGJGPG.Parser, new string[1] { "ABGLNIDOADM" }, null, null, null, null)
		}));
	}
}
