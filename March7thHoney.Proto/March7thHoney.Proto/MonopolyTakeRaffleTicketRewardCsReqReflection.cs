using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyTakeRaffleTicketRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyTakeRaffleTicketRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilNb25vcG9seVRha2VSYWZmbGVUaWNrZXRSZXdhcmRDc1JlcS5wcm90byJP" + "CiNNb25vcG9seVRha2VSYWZmbGVUaWNrZXRSZXdhcmRDc1JlcRITCgtNQk1J" + "Q0NKRUJKQhgCIAEoDRITCgtDQk9NSENETkVERxgHIAEoBEIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyTakeRaffleTicketRewardCsReq), MonopolyTakeRaffleTicketRewardCsReq.Parser, new string[2] { "MBMICCJEBJB", "CBOMHCDNEDG" }, null, null, null, null)
		}));
	}
}
