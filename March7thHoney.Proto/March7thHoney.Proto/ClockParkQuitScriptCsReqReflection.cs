using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ClockParkQuitScriptCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ClockParkQuitScriptCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5DbG9ja1BhcmtRdWl0U2NyaXB0Q3NSZXEucHJvdG8iQgoYQ2xvY2tQYXJr" + "UXVpdFNjcmlwdENzUmVxEhEKCXNjcmlwdF9pZBgGIAEoDRITCgtOTUFLRk9E" + "TEpIUBgJIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ClockParkQuitScriptCsReq), ClockParkQuitScriptCsReq.Parser, new string[2] { "ScriptId", "NMAKFODLJHP" }, null, null, null, null)
		}));
	}
}
