using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetBenefitActivityInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetBenefitActivityInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxHZXRCZW5lZml0QWN0aXZpdHlJbmZvLnByb3RvGhFCZW5lZml0RGF0YS5w" + "cm90byJhChZHZXRCZW5lZml0QWN0aXZpdHlJbmZvEiEKC01LTERNQUVBUFBG" + "GAMgAygLMgwuQmVuZWZpdERhdGESDwoHcmV0Y29kZRgLIAEoDRITCgtFSEdC" + "SENQS0dKSBgMIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { BenefitDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetBenefitActivityInfo), GetBenefitActivityInfo.Parser, new string[3] { "MKLDMAEAPPF", "Retcode", "EHGBHCPKGJH" }, null, null, null, null)
		}));
	}
}
