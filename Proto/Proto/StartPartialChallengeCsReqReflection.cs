using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartPartialChallengeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartPartialChallengeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBTdGFydFBhcnRpYWxDaGFsbGVuZ2VDc1JlcS5wcm90byJaChpTdGFydFBh" + "cnRpYWxDaGFsbGVuZ2VDc1JlcRIPCgdidWZmX2lkGAQgASgNEhUKDWlzX2Zp" + "cnN0X2hhbGYYBSABKAgSFAoMY2hhbGxlbmdlX2lkGAsgASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartPartialChallengeCsReq), StartPartialChallengeCsReq.Parser, new string[3] { "BuffId", "IsFirstHalf", "ChallengeId" }, null, null, null, null)
		}));
	}
}
