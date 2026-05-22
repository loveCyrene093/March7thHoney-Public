using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ENEHKONPJNAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ENEHKONPJNAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFTkVIS09OUEpOQS5wcm90byI3CgtFTkVIS09OUEpOQRITCgtDQkNISVBG" + "QUhNRxgCIAEoDRITCgtES0pGRExLSkxCRRgGIAEoCEIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ENEHKONPJNA), ENEHKONPJNA.Parser, new string[2] { "CBCHIPFAHMG", "DKJFDLKJLBE" }, null, null, null, null)
		}));
	}
}
