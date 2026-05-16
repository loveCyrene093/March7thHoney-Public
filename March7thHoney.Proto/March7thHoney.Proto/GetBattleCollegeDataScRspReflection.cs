using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetBattleCollegeDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetBattleCollegeDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9HZXRCYXR0bGVDb2xsZWdlRGF0YVNjUnNwLnByb3RvImMKGUdldEJhdHRs" + "ZUNvbGxlZ2VEYXRhU2NSc3ASEwoLTENEQUxFRUVESkoYBSABKA0SDwoHcmV0" + "Y29kZRgGIAEoDRIgChhmaW5pc2hlZF9jb2xsZWdlX2lkX2xpc3QYDCADKA1C" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetBattleCollegeDataScRsp), GetBattleCollegeDataScRsp.Parser, new string[3] { "LCDALEEEDJJ", "Retcode", "FinishedCollegeIdList" }, null, null, null, null)
		}));
	}
}
