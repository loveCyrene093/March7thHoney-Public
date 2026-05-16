using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CAHPBBLMDCJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CAHPBBLMDCJReflection()
	{
		InlineArray11<string> buffer = default(InlineArray11<string>);
		buffer[0] = "ChFDQUhQQkJMTURDSi5wcm90bxoRQ0lNQ0RDQk5OS0oucHJvdG8aEU1LRUlO";
		buffer[1] = "TEZPQUVBLnByb3RvIoIDCgtDQUhQQkJMTURDShIPCgdyb29tX2lkGAEgASgE";
		buffer[2] = "EhMKC0hDUEJLQUxLR0dMGAIgASgNEhMKC0JFRkpMRktKRkpEGAMgASgNEhMK";
		buffer[3] = "C0NFTE5DUENQTUhBGAQgASgNEhMKC0JKQkFCR0JHR0lOGAUgASgIEhsKE21v";
		buffer[4] = "bnN0ZXJfYmF0dGxlX3R5cGUYBiABKA0SEwoLRUVKQ0lPR0hGQ0sYByABKA0S";
		buffer[5] = "EwoLSE9LRk5DTUpLQk4YCCADKA0SIQoLRktFSE9HTUdMSkYYCSABKAsyDC5D";
		buffer[6] = "SU1DRENCTk5LShIhCgtEQ0pCRkNQR05BShgKIAEoCzIMLkNJTUNEQ0JOTktK";
		buffer[7] = "EhMKC1BIRk1KR0JKRlBIGAsgASgNEiEKC0pKR0xCUEdOSk1MGAwgASgLMgwu";
		buffer[8] = "TUtFSU5MRk9BRUESIQoLR0JNQkJMTkVHQ0kYDSABKAsyDC5NS0VJTkxGT0FF";
		buffer[9] = "QRITCgtJRUFLSERLQUtETRgOIAEoDRIRCgljb3N0X3RpbWUYDyABKA1CFqoC";
		buffer[10] = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			CIMCDCBNNKJReflection.Descriptor,
			MKEINLFOAEAReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CAHPBBLMDCJ), CAHPBBLMDCJ.Parser, new string[15]
			{
				"RoomId", "HCPBKALKGGL", "BEFJLFKJFJD", "CELNCPCPMHA", "BJBABGBGGIN", "MonsterBattleType", "EEJCIOGHFCK", "HOKFNCMJKBN", "FKEHOGMGLJF", "DCJBFCPGNAJ",
				"PHFMJGBJFPH", "JJGLBPGNJML", "GBMBBLNEGCI", "IEAKHDKAKDM", "CostTime"
			}, null, null, null, null)
		}));
	}
}
