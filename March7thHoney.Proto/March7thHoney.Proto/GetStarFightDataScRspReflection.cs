using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetStarFightDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetStarFightDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRTdGFyRmlnaHREYXRhU2NSc3AucHJvdG8aEUVBS0JETEFFS0hKLnBy" + "b3RvIksKFUdldFN0YXJGaWdodERhdGFTY1JzcBIPCgdyZXRjb2RlGAUgASgN" + "EiEKC0JCRktBR0VCS0FMGAwgAygLMgwuRUFLQkRMQUVLSEpCFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { EAKBDLAEKHJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetStarFightDataScRsp), GetStarFightDataScRsp.Parser, new string[2] { "Retcode", "BBFKAGEBKAL" }, null, null, null, null)
		}));
	}
}
