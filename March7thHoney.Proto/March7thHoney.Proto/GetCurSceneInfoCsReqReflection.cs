using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetCurSceneInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetCurSceneInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHZXRDdXJTY2VuZUluZm9Dc1JlcS5wcm90byIWChRHZXRDdXJTY2VuZUlu" + "Zm9Dc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetCurSceneInfoCsReq), GetCurSceneInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
