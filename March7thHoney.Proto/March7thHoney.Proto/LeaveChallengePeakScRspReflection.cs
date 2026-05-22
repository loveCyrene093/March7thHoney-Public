using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LeaveChallengePeakScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LeaveChallengePeakScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1MZWF2ZUNoYWxsZW5nZVBlYWtTY1JzcC5wcm90byIqChdMZWF2ZUNoYWxs" + "ZW5nZVBlYWtTY1JzcBIPCgdyZXRjb2RlGAcgASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LeaveChallengePeakScRsp), LeaveChallengePeakScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
