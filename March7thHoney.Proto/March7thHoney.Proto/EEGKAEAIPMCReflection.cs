using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EEGKAEAIPMCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EEGKAEAIPMCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFRUdLQUVBSVBNQy5wcm90byIfCgtFRUdLQUVBSVBNQxIQCghldmVudF9p" + "ZBgCIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EEGKAEAIPMC), EEGKAEAIPMC.Parser, new string[1] { "EventId" }, null, null, null, null)
		}));
	}
}
