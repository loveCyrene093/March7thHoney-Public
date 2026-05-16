using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyLikeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyLikeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdNb25vcG9seUxpa2VDc1JlcS5wcm90byIoChFNb25vcG9seUxpa2VDc1Jl" + "cRITCgt0ZWxlcG9ydF9pZBgHIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyLikeCsReq), MonopolyLikeCsReq.Parser, new string[1] { "TeleportId" }, null, null, null, null)
		}));
	}
}
