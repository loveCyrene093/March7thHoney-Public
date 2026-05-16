using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAlleyInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAlleyInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHZXRBbGxleUluZm9Dc1JlcS5wcm90byITChFHZXRBbGxleUluZm9Dc1Jl" + "cUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAlleyInfoCsReq), GetAlleyInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
