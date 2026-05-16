using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SearchPlayerCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SearchPlayerCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdTZWFyY2hQbGF5ZXJDc1JlcS5wcm90byI6ChFTZWFyY2hQbGF5ZXJDc1Jl" + "cRIQCgh1aWRfbGlzdBgHIAMoDRITCgtJQ0hFTk9KRUNBUBgJIAEoCEIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SearchPlayerCsReq), SearchPlayerCsReq.Parser, new string[2] { "UidList", "ICHENOJECAP" }, null, null, null, null)
		}));
	}
}
