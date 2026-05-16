using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DeployRotatorCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DeployRotatorCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhEZXBsb3lSb3RhdG9yQ3NSZXEucHJvdG8aEVJvdGF0ZXJEYXRhLnByb3Rv" + "IjgKEkRlcGxveVJvdGF0b3JDc1JlcRIiCgxyb3RhdGVyX2RhdGEYAyABKAsy" + "DC5Sb3RhdGVyRGF0YUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { RotaterDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DeployRotatorCsReq), DeployRotatorCsReq.Parser, new string[1] { "RotaterData" }, null, null, null, null)
		}));
	}
}
