using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPlayerReturnMultiDropInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPlayerReturnMultiDropInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidHZXRQbGF5ZXJSZXR1cm5NdWx0aURyb3BJbmZvQ3NSZXEucHJvdG8iIwoh" + "R2V0UGxheWVyUmV0dXJuTXVsdGlEcm9wSW5mb0NzUmVxQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPlayerReturnMultiDropInfoCsReq), GetPlayerReturnMultiDropInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
