using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DNFNEINEOENReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DNFNEINEOENReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFETkZORUlORU9FTi5wcm90bxoRTEJDTkFPRktDSUwucHJvdG8iMAoLRE5G" + "TkVJTkVPRU4SIQoLSUdBRkxDS0pKS00YAyABKAsyDC5MQkNOQU9GS0NJTEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { LBCNAOFKCILReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DNFNEINEOEN), DNFNEINEOEN.Parser, new string[1] { "IGAFLCKJJKM" }, null, null, null, null)
		}));
	}
}
