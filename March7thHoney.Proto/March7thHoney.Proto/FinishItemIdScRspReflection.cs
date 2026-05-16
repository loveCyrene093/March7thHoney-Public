using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishItemIdScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishItemIdScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdGaW5pc2hJdGVtSWRTY1JzcC5wcm90byJGChFGaW5pc2hJdGVtSWRTY1Jz" + "cBIPCgdyZXRjb2RlGAMgASgNEg8KB2l0ZW1faWQYCiABKA0SDwoHdGV4dF9p" + "ZBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishItemIdScRsp), FinishItemIdScRsp.Parser, new string[3] { "Retcode", "ItemId", "TextId" }, null, null, null, null)
		}));
	}
}
