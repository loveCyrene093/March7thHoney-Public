using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RemoveRotatorCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RemoveRotatorCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhSZW1vdmVSb3RhdG9yQ3NSZXEucHJvdG8aEVJvdGF0ZXJEYXRhLnByb3Rv" + "IjgKElJlbW92ZVJvdGF0b3JDc1JlcRIiCgxyb3RhdGVyX2RhdGEYDSABKAsy" + "DC5Sb3RhdGVyRGF0YUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { RotaterDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RemoveRotatorCsReq), RemoveRotatorCsReq.Parser, new string[1] { "RotaterData" }, null, null, null, null)
		}));
	}
}
