using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GPKCEDKHLADReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GPKCEDKHLADReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHUEtDRURLSExBRC5wcm90byIzCgtHUEtDRURLSExBRBITCgtERElERUVB" + "S0NQUBgJIAMoDRIPCgdyZXRjb2RlGAogASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GPKCEDKHLAD), GPKCEDKHLAD.Parser, new string[2] { "DDIDEEAKCPP", "Retcode" }, null, null, null, null)
		}));
	}
}
