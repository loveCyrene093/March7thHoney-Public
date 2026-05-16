using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MarbleUpdateShownSealCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MarbleUpdateShownSealCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBNYXJibGVVcGRhdGVTaG93blNlYWxDc1JlcS5wcm90byIxChpNYXJibGVV" + "cGRhdGVTaG93blNlYWxDc1JlcRITCgtMQUlOQUVBTUhKQhgNIAMoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MarbleUpdateShownSealCsReq), MarbleUpdateShownSealCsReq.Parser, new string[1] { "LAINAEAMHJB" }, null, null, null, null)
		}));
	}
}
