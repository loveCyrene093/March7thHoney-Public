using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PFCKOAKLANFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PFCKOAKLANFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQRkNLT0FLTEFORi5wcm90byJeCgtQRkNLT0FLTEFORhITCgtBTUFERkpO" + "SE1GRhgHIAEoDRIQCghldmVudF9pZBgJIAEoDRITCgtMUEZES0hESExDRBgM" + "IAMoDRITCgtLRUtBRVBERUpKUBgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PFCKOAKLANF), PFCKOAKLANF.Parser, new string[4] { "AMADFJNHMFF", "EventId", "LPFDKHDHLCD", "KEKAEPDEJJP" }, null, null, null, null)
		}));
	}
}
