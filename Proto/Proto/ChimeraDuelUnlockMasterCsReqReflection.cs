using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelUnlockMasterCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelUnlockMasterCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJDaGltZXJhRHVlbFVubG9ja01hc3RlckNzUmVxLnByb3RvIjMKHENoaW1l" + "cmFEdWVsVW5sb2NrTWFzdGVyQ3NSZXESEwoLT0ZGSURNRUpCR0kYCyABKA1C" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelUnlockMasterCsReq), ChimeraDuelUnlockMasterCsReq.Parser, new string[1] { "OFFIDMEJBGI" }, null, null, null, null)
		}));
	}
}
