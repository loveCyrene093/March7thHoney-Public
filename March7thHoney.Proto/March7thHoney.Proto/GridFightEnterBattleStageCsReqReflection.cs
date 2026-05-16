using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightEnterBattleStageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightEnterBattleStageCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRHcmlkRmlnaHRFbnRlckJhdHRsZVN0YWdlQ3NSZXEucHJvdG8iIAoeR3Jp" + "ZEZpZ2h0RW50ZXJCYXR0bGVTdGFnZUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightEnterBattleStageCsReq), GridFightEnterBattleStageCsReq.Parser, null, null, null, null, null)
		}));
	}
}
