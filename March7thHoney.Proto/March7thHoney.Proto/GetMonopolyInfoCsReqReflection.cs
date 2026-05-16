using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMonopolyInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMonopolyInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHZXRNb25vcG9seUluZm9Dc1JlcS5wcm90byIWChRHZXRNb25vcG9seUlu" + "Zm9Dc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMonopolyInfoCsReq), GetMonopolyInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
