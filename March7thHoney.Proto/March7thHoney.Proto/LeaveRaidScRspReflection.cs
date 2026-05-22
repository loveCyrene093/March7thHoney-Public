using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LeaveRaidScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LeaveRaidScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRMZWF2ZVJhaWRTY1JzcC5wcm90byJHCg5MZWF2ZVJhaWRTY1JzcBITCgt3" + "b3JsZF9sZXZlbBgDIAEoDRIPCgdyYWlkX2lkGAggASgNEg8KB3JldGNvZGUY" + "DiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LeaveRaidScRsp), LeaveRaidScRsp.Parser, new string[3] { "WorldLevel", "RaidId", "Retcode" }, null, null, null, null)
		}));
	}
}
