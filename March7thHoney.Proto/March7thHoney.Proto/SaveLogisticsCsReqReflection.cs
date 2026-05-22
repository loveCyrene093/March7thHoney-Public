using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SaveLogisticsCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SaveLogisticsCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhTYXZlTG9naXN0aWNzQ3NSZXEucHJvdG8aEUNDQktHSkdORENMLnByb3Rv" + "IjcKElNhdmVMb2dpc3RpY3NDc1JlcRIhCgtLREtCTk1FSkxGUBgCIAMoCzIM" + "LkNDQktHSkdORENMQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { CCBKGJGNDCLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SaveLogisticsCsReq), SaveLogisticsCsReq.Parser, new string[1] { "KDKBNMEJLFP" }, null, null, null, null)
		}));
	}
}
