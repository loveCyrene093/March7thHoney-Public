using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EvolveBuildSkipTeachLevelCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EvolveBuildSkipTeachLevelCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRFdm9sdmVCdWlsZFNraXBUZWFjaExldmVsQ3NSZXEucHJvdG8iMgoeRXZv" + "bHZlQnVpbGRTa2lwVGVhY2hMZXZlbENzUmVxEhAKCGxldmVsX2lkGAsgASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EvolveBuildSkipTeachLevelCsReq), EvolveBuildSkipTeachLevelCsReq.Parser, new string[1] { "LevelId" }, null, null, null, null)
		}));
	}
}
