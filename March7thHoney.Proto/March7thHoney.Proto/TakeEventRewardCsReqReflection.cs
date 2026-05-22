using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeEventRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeEventRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpUYWtlRXZlbnRSZXdhcmRDc1JlcS5wcm90byIoChRUYWtlRXZlbnRSZXdh" + "cmRDc1JlcRIQCghldmVudF9pZBgJIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeEventRewardCsReq), TakeEventRewardCsReq.Parser, new string[1] { "EventId" }, null, null, null, null)
		}));
	}
}
