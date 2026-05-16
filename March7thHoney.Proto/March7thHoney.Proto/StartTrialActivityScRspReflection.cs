using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartTrialActivityScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartTrialActivityScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1TdGFydFRyaWFsQWN0aXZpdHlTY1JzcC5wcm90byI8ChdTdGFydFRyaWFs" + "QWN0aXZpdHlTY1JzcBIPCgdyZXRjb2RlGAsgASgNEhAKCHN0YWdlX2lkGAwg" + "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartTrialActivityScRsp), StartTrialActivityScRsp.Parser, new string[2] { "Retcode", "StageId" }, null, null, null, null)
		}));
	}
}
