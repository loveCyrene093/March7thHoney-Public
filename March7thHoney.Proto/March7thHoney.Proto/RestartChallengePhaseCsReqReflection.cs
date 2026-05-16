using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RestartChallengePhaseCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RestartChallengePhaseCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZXN0YXJ0Q2hhbGxlbmdlUGhhc2VDc1JlcS5wcm90byIcChpSZXN0YXJ0" + "Q2hhbGxlbmdlUGhhc2VDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RestartChallengePhaseCsReq), RestartChallengePhaseCsReq.Parser, null, null, null, null, null)
		}));
	}
}
