using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MNHCLKHLAHMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MNHCLKHLAHMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNTkhDTEtITEFITS5wcm90byIwCgtNTkhDTEtITEFITRIQCgh1aWRfbGlz" + "dBgBIAMoDRIPCgdyZXRjb2RlGAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MNHCLKHLAHM), MNHCLKHLAHM.Parser, new string[2] { "UidList", "Retcode" }, null, null, null, null)
		}));
	}
}
