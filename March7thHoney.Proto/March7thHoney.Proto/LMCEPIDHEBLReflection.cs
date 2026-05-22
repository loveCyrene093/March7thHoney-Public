using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LMCEPIDHEBLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LMCEPIDHEBLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMTUNFUElESEVCTC5wcm90byIeCgtMTUNFUElESEVCTBIPCgdyZXRjb2Rl" + "GA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LMCEPIDHEBL), LMCEPIDHEBL.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
