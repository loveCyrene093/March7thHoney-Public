using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelStartGameScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelStartGameScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9DaGltZXJhRHVlbFN0YXJ0R2FtZVNjUnNwLnByb3RvGhFEREpPRUlCT0VM" + "SC5wcm90byJPChlDaGltZXJhRHVlbFN0YXJ0R2FtZVNjUnNwEg8KB3JldGNv" + "ZGUYBCABKA0SIQoLT0lBUEhCQkRQSEwYDyABKAsyDC5EREpPRUlCT0VMSEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { DDJOEIBOELHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelStartGameScRsp), ChimeraDuelStartGameScRsp.Parser, new string[2] { "Retcode", "OIAPHBBDPHL" }, null, null, null, null)
		}));
	}
}
