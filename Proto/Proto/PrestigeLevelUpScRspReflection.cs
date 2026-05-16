using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PrestigeLevelUpScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PrestigeLevelUpScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpQcmVzdGlnZUxldmVsVXBTY1JzcC5wcm90byI2ChRQcmVzdGlnZUxldmVs" + "VXBTY1JzcBINCgVsZXZlbBgFIAEoDRIPCgdyZXRjb2RlGAsgASgNQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PrestigeLevelUpScRsp), PrestigeLevelUpScRsp.Parser, new string[2] { "Level", "Retcode" }, null, null, null, null)
		}));
	}
}
