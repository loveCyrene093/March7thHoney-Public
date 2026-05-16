using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetServerPrefsDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetServerPrefsDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HZXRTZXJ2ZXJQcmVmc0RhdGFTY1JzcC5wcm90bxoRU2VydmVyUHJlZnMu" + "cHJvdG8iTgoXR2V0U2VydmVyUHJlZnNEYXRhU2NSc3ASIgoMc2VydmVyX3By" + "ZWZzGAMgASgLMgwuU2VydmVyUHJlZnMSDwoHcmV0Y29kZRgMIAEoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ServerPrefsReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetServerPrefsDataScRsp), GetServerPrefsDataScRsp.Parser, new string[2] { "ServerPrefs", "Retcode" }, null, null, null, null)
		}));
	}
}
