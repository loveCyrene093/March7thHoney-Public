using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRogueAeonInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRogueAeonInfoScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRSb2d1ZUFlb25JbmZvU2NSc3AucHJvdG8aEUNOSE5HTEVFQktQLnBy" + "b3RvIksKFUdldFJvZ3VlQWVvbkluZm9TY1JzcBIhCgtPRkVOSUNGSkFOQxgB" + "IAMoCzIMLkNOSE5HTEVFQktQEg8KB3JldGNvZGUYByABKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { CNHNGLEEBKPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueAeonInfoScRsp), GetRogueAeonInfoScRsp.Parser, new string[2] { "OFENICFJANC", "Retcode" }, null, null, null, null)
		}));
	}
}
