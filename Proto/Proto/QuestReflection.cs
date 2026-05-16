using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class QuestReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static QuestReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CgtRdWVzdC5wcm90bxoRUXVlc3RTdGF0dXMucHJvdG8ibQoFUXVlc3QSEwoL" + "TEZCQURPQ0hDRE4YASADKA0SEAoIcHJvZ3Jlc3MYAiABKA0SEwoLZmluaXNo" + "X3RpbWUYAyABKAMSHAoGc3RhdHVzGAggASgOMgwuUXVlc3RTdGF0dXMSCgoC" + "aWQYDSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { QuestStatusReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Quest), Quest.Parser, new string[5] { "LFBADOCHCDN", "Progress", "FinishTime", "Status", "Id" }, null, null, null, null)
		}));
	}
}
