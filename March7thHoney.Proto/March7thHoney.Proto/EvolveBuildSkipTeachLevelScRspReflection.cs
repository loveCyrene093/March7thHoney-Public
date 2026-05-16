using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EvolveBuildSkipTeachLevelScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EvolveBuildSkipTeachLevelScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRFdm9sdmVCdWlsZFNraXBUZWFjaExldmVsU2NSc3AucHJvdG8iQwoeRXZv" + "bHZlQnVpbGRTa2lwVGVhY2hMZXZlbFNjUnNwEg8KB3JldGNvZGUYBCABKA0S" + "EAoIbGV2ZWxfaWQYCiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EvolveBuildSkipTeachLevelScRsp), EvolveBuildSkipTeachLevelScRsp.Parser, new string[2] { "Retcode", "LevelId" }, null, null, null, null)
		}));
	}
}
