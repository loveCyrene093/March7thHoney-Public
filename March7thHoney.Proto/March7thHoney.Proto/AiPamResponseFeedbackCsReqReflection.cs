using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AiPamResponseFeedbackCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AiPamResponseFeedbackCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBBaVBhbVJlc3BvbnNlRmVlZGJhY2tDc1JlcS5wcm90byJGChpBaVBhbVJl" + "c3BvbnNlRmVlZGJhY2tDc1JlcRITCgtESEVLREFHSkJKQhgEIAEoCBITCgtG" + "RkdJQ0dMRExLRRgGIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AiPamResponseFeedbackCsReq), AiPamResponseFeedbackCsReq.Parser, new string[2] { "DHEKDAGJBJB", "FFGICGLDLKE" }, null, null, null, null)
		}));
	}
}
