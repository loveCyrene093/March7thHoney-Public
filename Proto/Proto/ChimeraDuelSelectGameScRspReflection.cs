using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelSelectGameScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelSelectGameScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDaGltZXJhRHVlbFNlbGVjdEdhbWVTY1JzcC5wcm90byJCChpDaGltZXJh" + "RHVlbFNlbGVjdEdhbWVTY1JzcBITCgtNQVBETkxCSEhDRBgBIAEoDRIPCgdy" + "ZXRjb2RlGAMgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelSelectGameScRsp), ChimeraDuelSelectGameScRsp.Parser, new string[2] { "MAPDNLBHHCD", "Retcode" }, null, null, null, null)
		}));
	}
}
