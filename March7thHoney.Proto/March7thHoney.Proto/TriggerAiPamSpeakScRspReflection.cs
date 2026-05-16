using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TriggerAiPamSpeakScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TriggerAiPamSpeakScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxUcmlnZ2VyQWlQYW1TcGVha1NjUnNwLnByb3RvIj4KFlRyaWdnZXJBaVBh" + "bVNwZWFrU2NSc3ASDwoHcmV0Y29kZRgHIAEoDRITCgtDRUhKSkdFSU1DTBgP" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TriggerAiPamSpeakScRsp), TriggerAiPamSpeakScRsp.Parser, new string[2] { "Retcode", "CEHJJGEIMCL" }, null, null, null, null)
		}));
	}
}
