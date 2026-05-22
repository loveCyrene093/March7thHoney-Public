using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ConfirmChallengePeakSettleCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ConfirmChallengePeakSettleCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVDb25maXJtQ2hhbGxlbmdlUGVha1NldHRsZUNzUmVxLnByb3RvIkcKH0Nv" + "bmZpcm1DaGFsbGVuZ2VQZWFrU2V0dGxlQ3NSZXESDwoHcGVha19pZBgDIAEo" + "DRITCgtBQkhPTE5KTlBKTRgLIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ConfirmChallengePeakSettleCsReq), ConfirmChallengePeakSettleCsReq.Parser, new string[2] { "PeakId", "ABHOLNJNPJM" }, null, null, null, null)
		}));
	}
}
