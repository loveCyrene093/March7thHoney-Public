using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartBattleCollegeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartBattleCollegeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1TdGFydEJhdHRsZUNvbGxlZ2VDc1JlcS5wcm90byIlChdTdGFydEJhdHRs" + "ZUNvbGxlZ2VDc1JlcRIKCgJpZBgFIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartBattleCollegeCsReq), StartBattleCollegeCsReq.Parser, new string[1] { "Id" }, null, null, null, null)
		}));
	}
}
