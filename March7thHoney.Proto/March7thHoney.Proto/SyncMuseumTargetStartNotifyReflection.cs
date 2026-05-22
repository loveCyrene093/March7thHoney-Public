using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncMuseumTargetStartNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncMuseumTargetStartNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFTeW5jTXVzZXVtVGFyZ2V0U3RhcnROb3RpZnkucHJvdG8iMgobU3luY011" + "c2V1bVRhcmdldFN0YXJ0Tm90aWZ5EhMKC0xQQUdLSEdDQ0ZIGA4gASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncMuseumTargetStartNotify), SyncMuseumTargetStartNotify.Parser, new string[1] { "LPAGKHGCCFH" }, null, null, null, null)
		}));
	}
}
