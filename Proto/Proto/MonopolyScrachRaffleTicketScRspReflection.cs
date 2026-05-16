using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyScrachRaffleTicketScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyScrachRaffleTicketScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVNb25vcG9seVNjcmFjaFJhZmZsZVRpY2tldFNjUnNwLnByb3RvIlwKH01v" + "bm9wb2x5U2NyYWNoUmFmZmxlVGlja2V0U2NSc3ASDwoHcmV0Y29kZRgDIAEo" + "DRITCgtDQk9NSENETkVERxgEIAEoBBITCgtNQk1JQ0NKRUJKQhgLIAEoDUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyScrachRaffleTicketScRsp), MonopolyScrachRaffleTicketScRsp.Parser, new string[3] { "Retcode", "CBOMHCDNEDG", "MBMICCJEBJB" }, null, null, null, null)
		}));
	}
}
