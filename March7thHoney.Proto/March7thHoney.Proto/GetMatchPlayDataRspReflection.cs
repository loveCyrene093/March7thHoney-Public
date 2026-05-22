using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMatchPlayDataRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMatchPlayDataRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHZXRNYXRjaFBsYXlEYXRhUnNwLnByb3RvGhFCUEpET0VNQk5NRC5wcm90" + "byJJChNHZXRNYXRjaFBsYXlEYXRhUnNwEiEKC0RMTUdLQktFRklLGAQgAygL" + "MgwuQlBKRE9FTUJOTUQSDwoHcmV0Y29kZRgLIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { BPJDOEMBNMDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMatchPlayDataRsp), GetMatchPlayDataRsp.Parser, new string[2] { "DLMGKBKEFIK", "Retcode" }, null, null, null, null)
		}));
	}
}
