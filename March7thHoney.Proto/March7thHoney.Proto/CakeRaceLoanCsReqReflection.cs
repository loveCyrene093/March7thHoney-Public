using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CakeRaceLoanCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CakeRaceLoanCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdDYWtlUmFjZUxvYW5Dc1JlcS5wcm90byITChFDYWtlUmFjZUxvYW5Dc1Jl" + "cUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CakeRaceLoanCsReq), CakeRaceLoanCsReq.Parser, null, null, null, null, null)
		}));
	}
}
