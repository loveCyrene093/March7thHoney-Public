using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BNCEGLBGGOGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BNCEGLBGGOGReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFCTkNFR0xCR0dPRy5wcm90bxoRSEVIR05JSUNLQUEucHJvdG8aEU5MREpC";
		buffer[1] = "TUJEQ0hFLnByb3RvGhFPQkpHR0pQRkxBRS5wcm90byLKAQoLQk5DRUdMQkdH";
		buffer[2] = "T0cSEwoLUEZES0tGUFBBQUEYASADKA0SEwoLRU9NUEFPR0FBQk8YAyABKAwS";
		buffer[3] = "IQoLREVPRkFKTkpJRkwYBCADKAsyDC5PQkpHR0pQRkxBRRITCgtHSkpQRVBC";
		buffer[4] = "UENLTRgFIAEoDRIhCgtGQ0JQSktBUFBMRhgHIAMoCzIMLk5MREpCTUJEQ0hF";
		buffer[5] = "EhMKC0FLSUZQUEpDTkFDGAsgASgMEiEKC0VET0FJRU1JT0RIGA4gAygLMgwu";
		buffer[6] = "SEVIR05JSUNLQUFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			HEHGNIICKAAReflection.Descriptor,
			NLDJBMBDCHEReflection.Descriptor,
			OBJGGJPFLAEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BNCEGLBGGOG), BNCEGLBGGOG.Parser, new string[7] { "PFDKKFPPAAA", "EOMPAOGAABO", "DEOFAJNJIFL", "GJJPEPBPCKM", "FCBPJKAPPLF", "AKIFPPJCNAC", "EDOAIEMIODH" }, null, null, null, null)
		}));
	}
}
