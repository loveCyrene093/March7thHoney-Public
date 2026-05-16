using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetSignatureScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetSignatureScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdTZXRTaWduYXR1cmVTY1JzcC5wcm90byI3ChFTZXRTaWduYXR1cmVTY1Jz" + "cBIPCgdyZXRjb2RlGAUgASgNEhEKCXNpZ25hdHVyZRgPIAEoCUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetSignatureScRsp), SetSignatureScRsp.Parser, new string[2] { "Retcode", "Signature" }, null, null, null, null)
		}));
	}
}
