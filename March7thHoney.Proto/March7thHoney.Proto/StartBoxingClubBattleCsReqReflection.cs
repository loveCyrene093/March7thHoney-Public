using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartBoxingClubBattleCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartBoxingClubBattleCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBTdGFydEJveGluZ0NsdWJCYXR0bGVDc1JlcS5wcm90byIyChpTdGFydEJv" + "eGluZ0NsdWJCYXR0bGVDc1JlcRIUCgxjaGFsbGVuZ2VfaWQYCyABKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartBoxingClubBattleCsReq), StartBoxingClubBattleCsReq.Parser, new string[1] { "ChallengeId" }, null, null, null, null)
		}));
	}
}
