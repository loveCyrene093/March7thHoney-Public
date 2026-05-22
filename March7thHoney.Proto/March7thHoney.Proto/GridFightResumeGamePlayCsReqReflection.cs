using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightResumeGamePlayCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightResumeGamePlayCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJHcmlkRmlnaHRSZXN1bWVHYW1lUGxheUNzUmVxLnByb3RvIjEKHEdyaWRG" + "aWdodFJlc3VtZUdhbWVQbGF5Q3NSZXESEQoJdW5pcXVlX2lkGAwgASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightResumeGamePlayCsReq), GridFightResumeGamePlayCsReq.Parser, new string[1] { "UniqueId" }, null, null, null, null)
		}));
	}
}
