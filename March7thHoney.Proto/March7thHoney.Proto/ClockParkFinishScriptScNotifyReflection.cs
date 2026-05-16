using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ClockParkFinishScriptScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ClockParkFinishScriptScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNDbG9ja1BhcmtGaW5pc2hTY3JpcHRTY05vdGlmeS5wcm90bxoRS0NFSEVB" + "R0VEQUEucHJvdG8iQgodQ2xvY2tQYXJrRmluaXNoU2NyaXB0U2NOb3RpZnkS" + "IQoLZmluaXNoX2luZm8YDyABKAsyDC5LQ0VIRUFHRURBQUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { KCEHEAGEDAAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ClockParkFinishScriptScNotify), ClockParkFinishScriptScNotify.Parser, new string[1] { "FinishInfo" }, null, null, null, null)
		}));
	}
}
