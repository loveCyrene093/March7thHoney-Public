using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CIAANMCPBGFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CIAANMCPBGFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDSUFBTk1DUEJHRi5wcm90byIzCgtDSUFBTk1DUEJHRhITCgtOS0RFTUtB" + "UE5NThgJIAMoDRIPCgdyZXRjb2RlGAsgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CIAANMCPBGF), CIAANMCPBGF.Parser, new string[2] { "NKDEMKAPNMN", "Retcode" }, null, null, null, null)
		}));
	}
}
