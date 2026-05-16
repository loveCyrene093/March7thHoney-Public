using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetCurBattleInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetCurBattleInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRDdXJCYXR0bGVJbmZvQ3NSZXEucHJvdG8iFwoVR2V0Q3VyQmF0dGxl" + "SW5mb0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetCurBattleInfoCsReq), GetCurBattleInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
