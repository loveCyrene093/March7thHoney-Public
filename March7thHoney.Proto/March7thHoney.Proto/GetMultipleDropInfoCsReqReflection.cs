using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMultipleDropInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMultipleDropInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5HZXRNdWx0aXBsZURyb3BJbmZvQ3NSZXEucHJvdG8iGgoYR2V0TXVsdGlw" + "bGVEcm9wSW5mb0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMultipleDropInfoCsReq), GetMultipleDropInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
