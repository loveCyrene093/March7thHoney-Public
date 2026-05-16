using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CakeRaceCoinScoreChangeScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CakeRaceCoinScoreChangeScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVDYWtlUmFjZUNvaW5TY29yZUNoYW5nZVNjTm90aWZ5LnByb3RvIlwKH0Nh" + "a2VSYWNlQ29pblNjb3JlQ2hhbmdlU2NOb3RpZnkSEAoIc2NvcmVfaWQYASAB" + "KA0SEgoKaXRlbV92YWx1ZRgFIAEoDRITCgtMQ0hEQVBFTFBHTxgJIAEoDUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CakeRaceCoinScoreChangeScNotify), CakeRaceCoinScoreChangeScNotify.Parser, new string[3] { "ScoreId", "ItemValue", "LCHDAPELPGO" }, null, null, null, null)
		}));
	}
}
