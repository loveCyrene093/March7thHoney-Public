using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetUnreleasedBlockInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetUnreleasedBlockInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHZXRVbnJlbGVhc2VkQmxvY2tJbmZvQ3NSZXEucHJvdG8iHQobR2V0VW5y" + "ZWxlYXNlZEJsb2NrSW5mb0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetUnreleasedBlockInfoCsReq), GetUnreleasedBlockInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
