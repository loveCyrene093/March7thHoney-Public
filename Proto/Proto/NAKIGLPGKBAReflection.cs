using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NAKIGLPGKBAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NAKIGLPGKBAReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		buffer[0] = "ChFOQUtJR0xQR0tCQS5wcm90bxoRQ09GREpGSUJQRE0ucHJvdG8aH0NoZXNz";
		buffer[1] = "Um9ndWVCb2FyZENlbGxTdGF0dXMucHJvdG8aH0NoZXNzUm9ndWVDZWxsU3Bl";
		buffer[2] = "Y2lhbFR5cGUucHJvdG8irAIKC05BS0lHTFBHS0JBEgoKAmlkGAEgASgNEi8K";
		buffer[3] = "C0VITkNMRkxLTUZBGAIgASgOMhouQ2hlc3NSb2d1ZUJvYXJkQ2VsbFN0YXR1";
		buffer[4] = "cxITCgtFT09JR0NDS0dGQhgDIAEoDRIvCgtHRUxESUxCRkdCTRgEIAEoDjIa";
		buffer[5] = "LkNoZXNzUm9ndWVDZWxsU3BlY2lhbFR5cGUSIAoKc3RhZ2VfaW5mbxgGIAEo";
		buffer[6] = "CzIMLkNPRkRKRklCUERNEhMKC0dLQkVOQ0RGQ0VKGAggASgNEhMKC0NLSUhC";
		buffer[7] = "REtET0VKGAkgASgIEhMKC1BQRVBBUENFUENNGAogASgNEg8KB3Jvb21faWQY";
		buffer[8] = "CyABKA0SEwoLQ0VCUEFKQUFKUFAYDiABKAgSEwoLTUZOSU9CS0ZCS0YYDyAB";
		buffer[9] = "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			COFDJFIBPDMReflection.Descriptor,
			ChessRogueBoardCellStatusReflection.Descriptor,
			ChessRogueCellSpecialTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NAKIGLPGKBA), NAKIGLPGKBA.Parser, new string[11]
			{
				"Id", "EHNCLFLKMFA", "EOOIGCCKGFB", "GELDILBFGBM", "StageInfo", "GKBENCDFCEJ", "CKIHBDKDOEJ", "PPEPAPCEPCM", "RoomId", "CEBPAJAAJPP",
				"MFNIOBKFBKF"
			}, null, null, null, null)
		}));
	}
}
