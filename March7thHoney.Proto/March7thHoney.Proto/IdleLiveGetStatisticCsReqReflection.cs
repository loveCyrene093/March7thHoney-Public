using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IdleLiveGetStatisticCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IdleLiveGetStatisticCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9JZGxlTGl2ZUdldFN0YXRpc3RpY0NzUmVxLnByb3RvIhsKGUlkbGVMaXZl" + "R2V0U3RhdGlzdGljQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IdleLiveGetStatisticCsReq), IdleLiveGetStatisticCsReq.Parser, null, null, null, null, null)
		}));
	}
}
