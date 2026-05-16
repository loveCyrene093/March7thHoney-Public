using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeQuestRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeQuestRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpUYWtlUXVlc3RSZXdhcmRDc1JlcS5wcm90byIyChRUYWtlUXVlc3RSZXdh" + "cmRDc1JlcRIaChJzdWNjX3F1ZXN0X2lkX2xpc3QYDiADKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeQuestRewardCsReq), TakeQuestRewardCsReq.Parser, new string[1] { "SuccQuestIdList" }, null, null, null, null)
		}));
	}
}
