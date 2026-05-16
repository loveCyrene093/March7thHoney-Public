using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFriendRankingInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFriendRankingInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9HZXRGcmllbmRSYW5raW5nSW5mb0NzUmVxLnByb3RvGhNGaWdodEdhbWVN" + "b2RlLnByb3RvIkAKGUdldEZyaWVuZFJhbmtpbmdJbmZvQ3NSZXESIwoLUExP" + "Qk1CRlBORksYDSABKA4yDi5GaWdodEdhbWVNb2RlQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { FightGameModeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendRankingInfoCsReq), GetFriendRankingInfoCsReq.Parser, new string[1] { "PLOBMBFPNFK" }, null, null, null, null)
		}));
	}
}
