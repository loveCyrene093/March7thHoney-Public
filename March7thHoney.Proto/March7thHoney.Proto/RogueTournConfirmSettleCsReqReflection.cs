using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournConfirmSettleCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournConfirmSettleCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSb2d1ZVRvdXJuQ29uZmlybVNldHRsZUNzUmVxLnByb3RvIlIKHFJvZ3Vl" + "VG91cm5Db25maXJtU2V0dGxlQ3NSZXESDwoHYXJlYV9pZBgEIAEoDRIMCgRu" + "YW1lGAcgASgJEhMKC0tLR0lFRU5DT0lDGA0gASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournConfirmSettleCsReq), RogueTournConfirmSettleCsReq.Parser, new string[3] { "AreaId", "Name", "KKGIEENCOIC" }, null, null, null, null)
		}));
	}
}
