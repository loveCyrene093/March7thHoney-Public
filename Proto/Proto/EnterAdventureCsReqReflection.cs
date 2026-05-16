using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterAdventureCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterAdventureCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlFbnRlckFkdmVudHVyZUNzUmVxLnByb3RvIiUKE0VudGVyQWR2ZW50dXJl" + "Q3NSZXESDgoGbWFwX2lkGAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterAdventureCsReq), EnterAdventureCsReq.Parser, new string[1] { "MapId" }, null, null, null, null)
		}));
	}
}
