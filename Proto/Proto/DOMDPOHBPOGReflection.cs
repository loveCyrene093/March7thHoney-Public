using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DOMDPOHBPOGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DOMDPOHBPOGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFET01EUE9IQlBPRy5wcm90byIiCgtET01EUE9IQlBPRxITCgtHUEpISk9P" + "SUpKQxgHIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DOMDPOHBPOG), DOMDPOHBPOG.Parser, new string[1] { "GPJHJOOIJJC" }, null, null, null, null)
		}));
	}
}
