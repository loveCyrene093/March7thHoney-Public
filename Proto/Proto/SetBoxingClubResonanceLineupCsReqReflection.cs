using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetBoxingClubResonanceLineupCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetBoxingClubResonanceLineupCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CidTZXRCb3hpbmdDbHViUmVzb25hbmNlTGluZXVwQ3NSZXEucHJvdG8aEU1I";
		buffer[1] = "Sk5CQlBCTEJPLnByb3RvIlwKIVNldEJveGluZ0NsdWJSZXNvbmFuY2VMaW5l";
		buffer[2] = "dXBDc1JlcRIhCgtJRE9JRERFSElKRxgCIAMoCzIMLk1ISk5CQlBCTEJPEhQK";
		buffer[3] = "DGNoYWxsZW5nZV9pZBgHIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[4] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MHJNBBPBLBOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetBoxingClubResonanceLineupCsReq), SetBoxingClubResonanceLineupCsReq.Parser, new string[2] { "IDOIDDEHIJG", "ChallengeId" }, null, null, null, null)
		}));
	}
}
