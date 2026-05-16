using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleEndStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleEndStatusReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVCYXR0bGVFbmRTdGF0dXMucHJvdG8qZAoPQmF0dGxlRW5kU3RhdHVzEhMK" + "D0JBVFRMRV9FTkRfTk9ORRAAEhIKDkJBVFRMRV9FTkRfV0lOEAESEwoPQkFU" + "VExFX0VORF9MT1NFEAISEwoPQkFUVExFX0VORF9RVUlUEANCFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(BattleEndStatus) }, null, null));
	}
}
