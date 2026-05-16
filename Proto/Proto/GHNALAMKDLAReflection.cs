using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GHNALAMKDLAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GHNALAMKDLAReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFHSE5BTEFNS0RMQS5wcm90bxoRQkhDTUhOS09OTUoucHJvdG8aEU9KQ0lK";
		buffer[1] = "RlBOUEtGLnByb3RvImUKC0dITkFMQU1LRExBEiEKC0dFSUpET0JLTkFEGAUg";
		buffer[2] = "AygLMgwuT0pDSUpGUE5QS0YSIQoLUEhLQUhBSExEQUUYCSABKA4yDC5CSENN";
		buffer[3] = "SE5LT05NShIQCghldmVudF9pZBgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[4] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			BHCMHNKONMJReflection.Descriptor,
			OJCIJFPNPKFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GHNALAMKDLA), GHNALAMKDLA.Parser, new string[3] { "GEIJDOBKNAD", "PHKAHAHLDAE", "EventId" }, null, null, null, null)
		}));
	}
}
