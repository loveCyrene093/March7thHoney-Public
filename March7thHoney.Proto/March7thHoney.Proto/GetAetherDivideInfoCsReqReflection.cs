using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAetherDivideInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAetherDivideInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5HZXRBZXRoZXJEaXZpZGVJbmZvQ3NSZXEucHJvdG8iGgoYR2V0QWV0aGVy" + "RGl2aWRlSW5mb0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAetherDivideInfoCsReq), GetAetherDivideInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
