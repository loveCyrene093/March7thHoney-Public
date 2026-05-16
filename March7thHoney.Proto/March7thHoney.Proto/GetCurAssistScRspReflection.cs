using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetCurAssistScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetCurAssistScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHZXRDdXJBc3Npc3RTY1JzcC5wcm90bxoWUGxheWVyQXNzaXN0SW5mby5w" + "cm90byJMChFHZXRDdXJBc3Npc3RTY1JzcBImCgtJTFBLUEJPS01FThgFIAEo" + "CzIRLlBsYXllckFzc2lzdEluZm8SDwoHcmV0Y29kZRgKIAEoDUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { PlayerAssistInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetCurAssistScRsp), GetCurAssistScRsp.Parser, new string[2] { "ILPKPBOKMEN", "Retcode" }, null, null, null, null)
		}));
	}
}
