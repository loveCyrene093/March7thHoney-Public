using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartChallengePeakScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartChallengePeakScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1TdGFydENoYWxsZW5nZVBlYWtTY1JzcC5wcm90byIqChdTdGFydENoYWxs" + "ZW5nZVBlYWtTY1JzcBIPCgdyZXRjb2RlGAogASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartChallengePeakScRsp), StartChallengePeakScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
