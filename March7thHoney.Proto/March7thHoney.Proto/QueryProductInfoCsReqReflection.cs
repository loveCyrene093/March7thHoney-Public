using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class QueryProductInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static QueryProductInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtRdWVyeVByb2R1Y3RJbmZvQ3NSZXEucHJvdG8iFwoVUXVlcnlQcm9kdWN0" + "SW5mb0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(QueryProductInfoCsReq), QueryProductInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
