using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class Match3GetDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static Match3GetDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhNYXRjaDNHZXREYXRhQ3NSZXEucHJvdG8iFAoSTWF0Y2gzR2V0RGF0YUNz" + "UmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Match3GetDataCsReq), Match3GetDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
