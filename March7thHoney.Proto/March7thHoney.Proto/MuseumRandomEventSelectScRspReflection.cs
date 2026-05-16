using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MuseumRandomEventSelectScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MuseumRandomEventSelectScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJNdXNldW1SYW5kb21FdmVudFNlbGVjdFNjUnNwLnByb3RvIlYKHE11c2V1" + "bVJhbmRvbUV2ZW50U2VsZWN0U2NSc3ASEAoIZXZlbnRfaWQYAiABKA0SDwoH" + "cmV0Y29kZRgKIAEoDRITCgtJTEhBQkZKS0VHRBgMIAEoDUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MuseumRandomEventSelectScRsp), MuseumRandomEventSelectScRsp.Parser, new string[3] { "EventId", "Retcode", "ILHABFJKEGD" }, null, null, null, null)
		}));
	}
}
