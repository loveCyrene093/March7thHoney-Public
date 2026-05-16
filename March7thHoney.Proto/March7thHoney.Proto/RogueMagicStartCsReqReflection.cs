using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueMagicStartCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueMagicStartCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpSb2d1ZU1hZ2ljU3RhcnRDc1JlcS5wcm90byJuChRSb2d1ZU1hZ2ljU3Rh" + "cnRDc1JlcRITCgtOR0RLTEJIREFHRxgBIAEoDRIPCgdhcmVhX2lkGAQgASgN" + "EhMKC09KQUhNTkFOSU5MGAwgAygNEhsKE2Jhc2VfYXZhdGFyX2lkX2xpc3QY" + "DiADKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicStartCsReq), RogueMagicStartCsReq.Parser, new string[4] { "NGDKLBHDAGG", "AreaId", "OJAHMNANINL", "BaseAvatarIdList" }, null, null, null, null)
		}));
	}
}
