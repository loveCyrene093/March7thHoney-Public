using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LobbyQuitCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LobbyQuitCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRMb2JieVF1aXRDc1JlcS5wcm90byIQCg5Mb2JieVF1aXRDc1JlcUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LobbyQuitCsReq), LobbyQuitCsReq.Parser, null, null, null, null, null)
		}));
	}
}
