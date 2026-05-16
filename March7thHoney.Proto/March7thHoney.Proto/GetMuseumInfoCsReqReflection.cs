using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMuseumInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMuseumInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhHZXRNdXNldW1JbmZvQ3NSZXEucHJvdG8iFAoSR2V0TXVzZXVtSW5mb0Nz" + "UmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMuseumInfoCsReq), GetMuseumInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
