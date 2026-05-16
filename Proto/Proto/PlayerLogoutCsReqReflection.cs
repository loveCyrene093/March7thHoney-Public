using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerLogoutCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerLogoutCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdQbGF5ZXJMb2dvdXRDc1JlcS5wcm90byITChFQbGF5ZXJMb2dvdXRDc1Jl" + "cUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerLogoutCsReq), PlayerLogoutCsReq.Parser, null, null, null, null, null)
		}));
	}
}
