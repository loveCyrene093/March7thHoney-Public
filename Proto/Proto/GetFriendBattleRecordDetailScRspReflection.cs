using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFriendBattleRecordDetailScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFriendBattleRecordDetailScRspReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "CiZHZXRGcmllbmRCYXR0bGVSZWNvcmREZXRhaWxTY1JzcC5wcm90bxoiRnJp";
		buffer[1] = "ZW5kQ2hhbGxlbmdlQ2xlYXJhbmNlSW5mby5wcm90bxoRSEJOSkFCUEhMTUwu";
		buffer[2] = "cHJvdG8aEU5DTENJSU1JSERILnByb3RvGhFQS0VDSlBKQ09OSi5wcm90byLd";
		buffer[3] = "AQogR2V0RnJpZW5kQmF0dGxlUmVjb3JkRGV0YWlsU2NSc3ASIQoLUEFFRUJB";
		buffer[4] = "R09FREoYASADKAsyDC5OQ0xDSUlNSUhESBIhCgtLSUlPTkpCREtOShgGIAEo";
		buffer[5] = "CzIMLkhCTkpBQlBITE1MEiEKC0VOQ1BISExETkxCGAkgASgLMgwuUEtFQ0pQ";
		buffer[6] = "SkNPTkoSMgoLQklLSU5OQURLRksYDCADKAsyHS5GcmllbmRDaGFsbGVuZ2VD";
		buffer[7] = "bGVhcmFuY2VJbmZvEg8KB3JldGNvZGUYDSABKA0SCwoDdWlkGA8gASgNQhaq";
		buffer[8] = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			FriendChallengeClearanceInfoReflection.Descriptor,
			HBNJABPHLMLReflection.Descriptor,
			NCLCIIMIHDHReflection.Descriptor,
			PKECJPJCONJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendBattleRecordDetailScRsp), GetFriendBattleRecordDetailScRsp.Parser, new string[6] { "PAEEBAGOEDJ", "KIIONJBDKNJ", "ENCPHHLDNLB", "BIKINNADKFK", "Retcode", "Uid" }, null, null, null, null)
		}));
	}
}
