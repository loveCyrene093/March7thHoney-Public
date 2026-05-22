using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetCurLineupDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetCurLineupDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRDdXJMaW5ldXBEYXRhQ3NSZXEucHJvdG8iFwoVR2V0Q3VyTGluZXVw" + "RGF0YUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetCurLineupDataCsReq), GetCurLineupDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
