using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartAlleyEventCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartAlleyEventCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTdGFydEFsbGV5RXZlbnRDc1JlcS5wcm90byIoChRTdGFydEFsbGV5RXZl" + "bnRDc1JlcRIQCghldmVudF9pZBgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartAlleyEventCsReq), StartAlleyEventCsReq.Parser, new string[1] { "EventId" }, null, null, null, null)
		}));
	}
}
