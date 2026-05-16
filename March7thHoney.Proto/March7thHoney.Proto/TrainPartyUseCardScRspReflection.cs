using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyUseCardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyUseCardScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxUcmFpblBhcnR5VXNlQ2FyZFNjUnNwLnByb3RvIj4KFlRyYWluUGFydHlV" + "c2VDYXJkU2NSc3ASDwoHcmV0Y29kZRgGIAEoDRITCgtHREZQQkhNTUZFQRgL" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyUseCardScRsp), TrainPartyUseCardScRsp.Parser, new string[2] { "Retcode", "GDFPBHMMFEA" }, null, null, null, null)
		}));
	}
}
