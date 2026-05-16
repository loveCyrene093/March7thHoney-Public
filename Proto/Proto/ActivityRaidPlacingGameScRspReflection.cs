using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ActivityRaidPlacingGameScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ActivityRaidPlacingGameScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJBY3Rpdml0eVJhaWRQbGFjaW5nR2FtZVNjUnNwLnByb3RvImwKHEFjdGl2" + "aXR5UmFpZFBsYWNpbmdHYW1lU2NSc3ASDwoHcmV0Y29kZRgBIAEoDRIVCgtP" + "QlBOREtQUEZHRxgIIAEoDUgAEhUKC01GTUhIQVBQUEpKGAogASgNSABCDQoL" + "RExPTUtGTEVFSUNCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ActivityRaidPlacingGameScRsp), ActivityRaidPlacingGameScRsp.Parser, new string[3] { "Retcode", "OBPNDKPPFGG", "MFMHHAPPPJJ" }, new string[1] { "DLOMKFLEEIC" }, null, null, null)
		}));
	}
}
