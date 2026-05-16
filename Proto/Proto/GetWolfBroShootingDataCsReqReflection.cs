using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetWolfBroShootingDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetWolfBroShootingDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHZXRXb2xmQnJvU2hvb3RpbmdEYXRhQ3NSZXEucHJvdG8iHQobR2V0V29s" + "ZkJyb1Nob290aW5nRGF0YUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetWolfBroShootingDataCsReq), GetWolfBroShootingDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
