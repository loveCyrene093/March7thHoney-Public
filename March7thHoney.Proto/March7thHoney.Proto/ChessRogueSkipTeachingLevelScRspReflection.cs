using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueSkipTeachingLevelScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueSkipTeachingLevelScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZDaGVzc1JvZ3VlU2tpcFRlYWNoaW5nTGV2ZWxTY1JzcC5wcm90bxoOSXRl" + "bUxpc3QucHJvdG8iUwogQ2hlc3NSb2d1ZVNraXBUZWFjaGluZ0xldmVsU2NS" + "c3ASDwoHcmV0Y29kZRgBIAEoDRIeCgtBSUpPTUJMTU1PTBgCIAEoCzIJLkl0" + "ZW1MaXN0QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueSkipTeachingLevelScRsp), ChessRogueSkipTeachingLevelScRsp.Parser, new string[2] { "Retcode", "AIJOMBLMMOL" }, null, null, null, null)
		}));
	}
}
