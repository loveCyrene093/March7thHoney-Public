using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerReturnSignCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerReturnSignCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtQbGF5ZXJSZXR1cm5TaWduQ3NSZXEucHJvdG8aEUtFT0xFSEhMSEhNLnBy" + "b3RvIjoKFVBsYXllclJldHVyblNpZ25Dc1JlcRIhCgtETUhHRFBCQUFMThgB" + "IAMoCzIMLktFT0xFSEhMSEhNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[1] { KEOLEHHLHHMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerReturnSignCsReq), PlayerReturnSignCsReq.Parser, new string[1] { "DMHGDPBAALN" }, null, null, null, null)
		}));
	}
}
