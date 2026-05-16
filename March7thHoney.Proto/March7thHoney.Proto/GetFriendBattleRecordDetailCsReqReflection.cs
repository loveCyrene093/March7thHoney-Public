using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFriendBattleRecordDetailCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFriendBattleRecordDetailCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZHZXRGcmllbmRCYXR0bGVSZWNvcmREZXRhaWxDc1JlcS5wcm90byIvCiBH" + "ZXRGcmllbmRCYXR0bGVSZWNvcmREZXRhaWxDc1JlcRILCgN1aWQYBCABKA1C" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendBattleRecordDetailCsReq), GetFriendBattleRecordDetailCsReq.Parser, new string[1] { "Uid" }, null, null, null, null)
		}));
	}
}
