using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightRecycleRoleCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightRecycleRoleCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9HcmlkRmlnaHRSZWN5Y2xlUm9sZUNzUmVxLnByb3RvIi4KGUdyaWRGaWdo" + "dFJlY3ljbGVSb2xlQ3NSZXESEQoJdW5pcXVlX2lkGAQgASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightRecycleRoleCsReq), GridFightRecycleRoleCsReq.Parser, new string[1] { "UniqueId" }, null, null, null, null)
		}));
	}
}
