using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LogisticsGameCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LogisticsGameCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhMb2dpc3RpY3NHYW1lQ3NSZXEucHJvdG8aEUNDQktHSkdORENMLnByb3Rv" + "IkwKEkxvZ2lzdGljc0dhbWVDc1JlcRITCgtDTFBOQkZPS0pMShgBIAEoCBIh" + "CgtLREtCTk1FSkxGUBgIIAMoCzIMLkNDQktHSkdORENMQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { CCBKGJGNDCLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LogisticsGameCsReq), LogisticsGameCsReq.Parser, new string[2] { "CLPNBFOKJLJ", "KDKBNMEJLFP" }, null, null, null, null)
		}));
	}
}
