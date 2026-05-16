using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NewAssistHistoryNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NewAssistHistoryNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxOZXdBc3Npc3RIaXN0b3J5Tm90aWZ5LnByb3RvIi0KFk5ld0Fzc2lzdEhp" + "c3RvcnlOb3RpZnkSEwoLT0tQQk5JSURDRUoYBSABKA1CFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NewAssistHistoryNotify), NewAssistHistoryNotify.Parser, new string[1] { "OKPBNIIDCEJ" }, null, null, null, null)
		}));
	}
}
