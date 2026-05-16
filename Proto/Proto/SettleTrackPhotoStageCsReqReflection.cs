using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SettleTrackPhotoStageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SettleTrackPhotoStageCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiBTZXR0bGVUcmFja1Bob3RvU3RhZ2VDc1JlcS5wcm90bxoRTUJDQ0JJQU1J";
		buffer[1] = "SlAucHJvdG8iZAoaU2V0dGxlVHJhY2tQaG90b1N0YWdlQ3NSZXESIQoLQUpE";
		buffer[2] = "S0NCRkNOTEcYCiADKAsyDC5NQkNDQklBTUlKUBIRCgljb3N0X3RpbWUYDSAB";
		buffer[3] = "KA0SEAoIc3RhZ2VfaWQYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[4] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MBCCBIAMIJPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SettleTrackPhotoStageCsReq), SettleTrackPhotoStageCsReq.Parser, new string[3] { "AJDKCBFCNLG", "CostTime", "StageId" }, null, null, null, null)
		}));
	}
}
