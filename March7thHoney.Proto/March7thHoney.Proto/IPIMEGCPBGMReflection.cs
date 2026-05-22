using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IPIMEGCPBGMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IPIMEGCPBGMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJUElNRUdDUEJHTS5wcm90byI0CgtJUElNRUdDUEJHTRITCgtFTUxJSklC" + "UEJGTBgLIAEoDRIQCghwcm9ncmVzcxgPIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IPIMEGCPBGM), IPIMEGCPBGM.Parser, new string[2] { "EMLIJIBPBFL", "Progress" }, null, null, null, null)
		}));
	}
}
