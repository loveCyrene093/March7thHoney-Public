using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ParkourGetDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ParkourGetDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlQYXJrb3VyR2V0RGF0YVNjUnNwLnByb3RvGhFMTkdKQ0pOS1BLRS5wcm90" + "byJJChNQYXJrb3VyR2V0RGF0YVNjUnNwEiEKC0xDUEhFS1BBREtGGAEgAygL" + "MgwuTE5HSkNKTktQS0USDwoHcmV0Y29kZRgOIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { LNGJCJNKPKEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ParkourGetDataScRsp), ParkourGetDataScRsp.Parser, new string[2] { "LCPHEKPADKF", "Retcode" }, null, null, null, null)
		}));
	}
}
