using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueQuestFinishNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueQuestFinishNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDaGVzc1JvZ3VlUXVlc3RGaW5pc2hOb3RpZnkucHJvdG8iRAobQ2hlc3NS" + "b2d1ZVF1ZXN0RmluaXNoTm90aWZ5EhAKCHF1ZXN0X2lkGAcgASgNEhMKC09H" + "UElETFBISEdHGAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueQuestFinishNotify), ChessRogueQuestFinishNotify.Parser, new string[2] { "QuestId", "OGPIDLPHHGG" }, null, null, null, null)
		}));
	}
}
