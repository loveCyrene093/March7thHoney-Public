using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightQuitSettleCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightQuitSettleCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5HcmlkRmlnaHRRdWl0U2V0dGxlQ3NSZXEucHJvdG8iGgoYR3JpZEZpZ2h0" + "UXVpdFNldHRsZUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightQuitSettleCsReq), GridFightQuitSettleCsReq.Parser, null, null, null, null, null)
		}));
	}
}
