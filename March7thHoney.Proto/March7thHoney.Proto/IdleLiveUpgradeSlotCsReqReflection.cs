using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IdleLiveUpgradeSlotCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IdleLiveUpgradeSlotCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5JZGxlTGl2ZVVwZ3JhZGVTbG90Q3NSZXEucHJvdG8iPgoYSWRsZUxpdmVV" + "cGdyYWRlU2xvdENzUmVxEhMKC0pOR0hNT1BFS0pPGAwgASgNEg0KBWxldmVs" + "GA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IdleLiveUpgradeSlotCsReq), IdleLiveUpgradeSlotCsReq.Parser, new string[2] { "JNGHMOPEKJO", "Level" }, null, null, null, null)
		}));
	}
}
