using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFriendAssistListCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFriendAssistListCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "Ch5HZXRGcmllbmRBc3Npc3RMaXN0Q3NSZXEucHJvdG8aEUlQR0ZDR0hJSUtO";
		buffer[1] = "LnByb3RvIpEBChhHZXRGcmllbmRBc3Npc3RMaXN0Q3NSZXESEwoLSVBNR0xN";
		buffer[2] = "SkZHTlAYASADKA0SIQoLTkpBQVBHSkFOQ0kYAiABKA4yDC5JUEdGQ0dISUlL";
		buffer[3] = "ThITCgt0YXJnZXRfc2lkZRgHIAEoDRITCgtJQ0hFTk9KRUNBUBgNIAEoCBIT";
		buffer[4] = "CgtOTEVFSUJBUEZBQRgOIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[5] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { IPGFCGHIIKNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendAssistListCsReq), GetFriendAssistListCsReq.Parser, new string[5] { "IPMGLMJFGNP", "NJAAPGJANCI", "TargetSide", "ICHENOJECAP", "NLEEIBAPFAA" }, null, null, null, null)
		}));
	}
}
