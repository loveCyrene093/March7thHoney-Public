using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetNpcStatusCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetNpcStatusCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHZXROcGNTdGF0dXNDc1JlcS5wcm90byITChFHZXROcGNTdGF0dXNDc1Jl" + "cUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetNpcStatusCsReq), GetNpcStatusCsReq.Parser, null, null, null, null, null)
		}));
	}
}
