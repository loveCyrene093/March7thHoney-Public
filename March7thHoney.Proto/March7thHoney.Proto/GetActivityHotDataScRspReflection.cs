using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetActivityHotDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetActivityHotDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HZXRBY3Rpdml0eUhvdERhdGFTY1JzcC5wcm90bxoRR0ZBREJDTUdGRkYu" + "cHJvdG8iVgoXR2V0QWN0aXZpdHlIb3REYXRhU2NSc3ASDwoHcmV0Y29kZRgD" + "IAEoDRIqChRjb250ZW50X3BhY2thZ2VfbGlzdBgKIAMoCzIMLkdGQURCQ01H" + "RkZGQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { GFADBCMGFFFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetActivityHotDataScRsp), GetActivityHotDataScRsp.Parser, new string[2] { "Retcode", "ContentPackageList" }, null, null, null, null)
		}));
	}
}
