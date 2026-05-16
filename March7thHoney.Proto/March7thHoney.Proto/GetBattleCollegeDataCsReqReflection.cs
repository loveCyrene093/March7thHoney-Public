using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetBattleCollegeDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetBattleCollegeDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9HZXRCYXR0bGVDb2xsZWdlRGF0YUNzUmVxLnByb3RvIhsKGUdldEJhdHRs" + "ZUNvbGxlZ2VEYXRhQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetBattleCollegeDataCsReq), GetBattleCollegeDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
