using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetOrigamiPropInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetOrigamiPropInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HZXRPcmlnYW1pUHJvcEluZm9Dc1JlcS5wcm90byJXChdHZXRPcmlnYW1p" + "UHJvcEluZm9Dc1JlcRITCgtNRUxOUEJLQUFCSRgBIAMoDRISCgpjb250ZW50" + "X2lkGAMgASgNEhMKC0dGR0ZMSUhDQ09EGAYgASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetOrigamiPropInfoCsReq), GetOrigamiPropInfoCsReq.Parser, new string[3] { "MELNPBKAABI", "ContentId", "GFGFLIHCCOD" }, null, null, null, null)
		}));
	}
}
