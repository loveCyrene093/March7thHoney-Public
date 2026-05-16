using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeApRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeApRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdUYWtlQXBSZXdhcmRDc1JlcS5wcm90byIiChFUYWtlQXBSZXdhcmRDc1Jl" + "cRINCgVsZXZlbBgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeApRewardCsReq), TakeApRewardCsReq.Parser, new string[1] { "Level" }, null, null, null, null)
		}));
	}
}
