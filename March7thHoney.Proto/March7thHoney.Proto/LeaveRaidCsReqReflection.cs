using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LeaveRaidCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LeaveRaidCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRMZWF2ZVJhaWRDc1JlcS5wcm90byIyCg5MZWF2ZVJhaWRDc1JlcRIPCgdp" + "c19zYXZlGAkgASgIEg8KB3JhaWRfaWQYDyABKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LeaveRaidCsReq), LeaveRaidCsReq.Parser, new string[2] { "IsSave", "RaidId" }, null, null, null, null)
		}));
	}
}
