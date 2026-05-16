using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SpaceZooTakeScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SpaceZooTakeScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdTcGFjZVpvb1Rha2VTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJvdG8iVAoR" + "U3BhY2Vab29UYWtlU2NSc3ASEwoLQk1MS0lCTkxOSkEYCiABKA0SDwoHcmV0" + "Y29kZRgLIAEoDRIZCgZyZXdhcmQYDSABKAsyCS5JdGVtTGlzdEIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SpaceZooTakeScRsp), SpaceZooTakeScRsp.Parser, new string[3] { "BMLKIBNLNJA", "Retcode", "Reward" }, null, null, null, null)
		}));
	}
}
