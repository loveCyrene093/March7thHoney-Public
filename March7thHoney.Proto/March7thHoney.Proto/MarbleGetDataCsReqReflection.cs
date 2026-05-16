using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MarbleGetDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MarbleGetDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhNYXJibGVHZXREYXRhQ3NSZXEucHJvdG8iFAoSTWFyYmxlR2V0RGF0YUNz" + "UmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MarbleGetDataCsReq), MarbleGetDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
