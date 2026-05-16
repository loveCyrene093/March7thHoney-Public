using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetHeadIconScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetHeadIconScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZTZXRIZWFkSWNvblNjUnNwLnByb3RvIkEKEFNldEhlYWRJY29uU2NSc3AS" + "DwoHcmV0Y29kZRgBIAEoDRIcChRjdXJyZW50X2hlYWRfaWNvbl9pZBgOIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetHeadIconScRsp), SetHeadIconScRsp.Parser, new string[2] { "Retcode", "CurrentHeadIconId" }, null, null, null, null)
		}));
	}
}
