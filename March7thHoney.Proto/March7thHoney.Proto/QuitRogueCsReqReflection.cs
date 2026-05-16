using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class QuitRogueCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static QuitRogueCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRRdWl0Um9ndWVDc1JlcS5wcm90byIhCg5RdWl0Um9ndWVDc1JlcRIPCgdh" + "cmVhX2lkGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(QuitRogueCsReq), QuitRogueCsReq.Parser, new string[1] { "AreaId" }, null, null, null, null)
		}));
	}
}
