using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JFIAMODBOIJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JFIAMODBOIJReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		buffer[0] = "ChFKRklBTU9EQk9JSi5wcm90bxoRQ0lNQ0RDQk5OS0oucHJvdG8aEUxPTEtE";
		buffer[1] = "S09DTExPLnByb3RvIpQDCgtKRklBTU9EQk9JShIPCgdyb29tX2lkGAEgASgE";
		buffer[2] = "EhMKC01NTEtGSklBS0tIGAIgASgNEhMKC05ES0FJQUZQTkJKGAMgASgNEhMK";
		buffer[3] = "C0dMTk1FUE5LSExOGAQgASgNEhMKC1BLSkFJSk9LSkxFGAUgASgIEhMKC0VF";
		buffer[4] = "SkNJT0dIRkNLGAYgASgNEhMKC0hPS0ZOQ01KS0JOGAcgAygNEiEKC0ZLRUhP";
		buffer[5] = "R01HTEpGGAggASgLMgwuQ0lNQ0RDQk5OS0oSIQoLSE1EQkFHRUxFSUUYCSAB";
		buffer[6] = "KAsyDC5DSU1DRENCTk5LShITCgtQSEZNSkdCSkZQSBgLIAEoDRIhCgtQSkFO";
		buffer[7] = "RUpESVBMSBgMIAEoCzIMLkxPTEtES09DTExPEiEKC0lIREFQTUZFT1BKGA0g";
		buffer[8] = "ASgLMgwuTE9MS0RLT0NMTE8SEAoIc2NvcmVfaWQYDiABKA0SEwoLUERGUEZG";
		buffer[9] = "SUxFTkoYDyABKA0SEQoJY29zdF90aW1lGBAgASgNEhsKE21vbnN0ZXJfYmF0";
		buffer[10] = "dGxlX3R5cGUYESABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[11] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			CIMCDCBNNKJReflection.Descriptor,
			LOLKDKOCLLOReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JFIAMODBOIJ), JFIAMODBOIJ.Parser, new string[16]
			{
				"RoomId", "MMLKFJIAKKH", "NDKAIAFPNBJ", "GLNMEPNKHLN", "PKJAIJOKJLE", "EEJCIOGHFCK", "HOKFNCMJKBN", "FKEHOGMGLJF", "HMDBAGELEIE", "PHFMJGBJFPH",
				"PJANEJDIPLH", "IHDAPMFEOPJ", "ScoreId", "PDFPFFILENJ", "CostTime", "MonsterBattleType"
			}, null, null, null, null)
		}));
	}
}
