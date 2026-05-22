using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwitchHandFinishCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwitchHandFinishCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtTd2l0Y2hIYW5kRmluaXNoQ3NSZXEucHJvdG8iFwoVU3dpdGNoSGFuZEZp" + "bmlzaENzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwitchHandFinishCsReq), SwitchHandFinishCsReq.Parser, null, null, null, null, null)
		}));
	}
}
