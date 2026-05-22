using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetLoginActivityScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetLoginActivityScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRMb2dpbkFjdGl2aXR5U2NSc3AucHJvdG8aF0xvZ2luQWN0aXZpdHlE" + "YXRhLnByb3RvIlkKFUdldExvZ2luQWN0aXZpdHlTY1JzcBIvChNsb2dpbl9h" + "Y3Rpdml0eV9saXN0GAkgAygLMhIuTG9naW5BY3Rpdml0eURhdGESDwoHcmV0" + "Y29kZRgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { LoginActivityDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetLoginActivityScRsp), GetLoginActivityScRsp.Parser, new string[2] { "LoginActivityList", "Retcode" }, null, null, null, null)
		}));
	}
}
