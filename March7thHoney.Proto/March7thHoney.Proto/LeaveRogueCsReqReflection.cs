using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LeaveRogueCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LeaveRogueCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVMZWF2ZVJvZ3VlQ3NSZXEucHJvdG8iEQoPTGVhdmVSb2d1ZUNzUmVxQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LeaveRogueCsReq), LeaveRogueCsReq.Parser, null, null, null, null, null)
		}));
	}
}
