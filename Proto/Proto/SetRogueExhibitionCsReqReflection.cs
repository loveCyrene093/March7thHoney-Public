using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetRogueExhibitionCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetRogueExhibitionCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch1TZXRSb2d1ZUV4aGliaXRpb25Dc1JlcS5wcm90bxoRQUdMTkxIT0JES0ku";
		buffer[1] = "cHJvdG8iZgoXU2V0Um9ndWVFeGhpYml0aW9uQ3NSZXESEwoLTUdQTkJNRkpD";
		buffer[2] = "REEYASADKA0SIQoLRURNQ0RJRkhGQkEYAiADKA4yDC5BR0xOTEhPQkRLSRIT";
		buffer[3] = "CgtBS0VDSkNQT0xDUBgDIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[4] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { AGLNLHOBDKIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetRogueExhibitionCsReq), SetRogueExhibitionCsReq.Parser, new string[3] { "MGPNBMFJCDA", "EDMCDIFHFBA", "AKECJCPOLCP" }, null, null, null, null)
		}));
	}
}
