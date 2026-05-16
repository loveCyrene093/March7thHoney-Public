using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LeaveChallengePeakCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LeaveChallengePeakCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1MZWF2ZUNoYWxsZW5nZVBlYWtDc1JlcS5wcm90byIZChdMZWF2ZUNoYWxs" + "ZW5nZVBlYWtDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LeaveChallengePeakCsReq), LeaveChallengePeakCsReq.Parser, null, null, null, null, null)
		}));
	}
}
