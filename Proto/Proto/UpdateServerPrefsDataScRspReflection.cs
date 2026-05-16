using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdateServerPrefsDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdateServerPrefsDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBVcGRhdGVTZXJ2ZXJQcmVmc0RhdGFTY1JzcC5wcm90byJGChpVcGRhdGVT" + "ZXJ2ZXJQcmVmc0RhdGFTY1JzcBIPCgdyZXRjb2RlGAsgASgNEhcKD3NlcnZl" + "cl9wcmVmc19pZBgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdateServerPrefsDataScRsp), UpdateServerPrefsDataScRsp.Parser, new string[2] { "Retcode", "ServerPrefsId" }, null, null, null, null)
		}));
	}
}
