using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChangeLineupLeaderScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChangeLineupLeaderScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1DaGFuZ2VMaW5ldXBMZWFkZXJTY1JzcC5wcm90byI4ChdDaGFuZ2VMaW5l" + "dXBMZWFkZXJTY1JzcBIMCgRzbG90GA0gASgNEg8KB3JldGNvZGUYDiABKA1C" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChangeLineupLeaderScRsp), ChangeLineupLeaderScRsp.Parser, new string[2] { "Slot", "Retcode" }, null, null, null, null)
		}));
	}
}
