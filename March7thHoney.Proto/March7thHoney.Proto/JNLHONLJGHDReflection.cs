using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JNLHONLJGHDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JNLHONLJGHDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKTkxIT05MSkdIRC5wcm90byIzCgtKTkxIT05MSkdIRBITCgtOTUREQUZL" + "SUdERhgGIAEoDRIPCgdyZXRjb2RlGAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JNLHONLJGHD), JNLHONLJGHD.Parser, new string[2] { "NMDDAFKIGDF", "Retcode" }, null, null, null, null)
		}));
	}
}
