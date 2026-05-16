using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetChallengeScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetChallengeScRspReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChdHZXRDaGFsbGVuZ2VTY1JzcC5wcm90bxoPQ2hhbGxlbmdlLnByb3RvGhRD";
		buffer[1] = "aGFsbGVuZ2VHcm91cC5wcm90bxoeQ2hhbGxlbmdlSGlzdG9yeU1heExldmVs";
		buffer[2] = "LnByb3RvIr8BChFHZXRDaGFsbGVuZ2VTY1JzcBITCgtNSEFQSUhDSlBKTRgB";
		buffer[3] = "IAEoDRIiCg5jaGFsbGVuZ2VfbGlzdBgEIAMoCzIKLkNoYWxsZW5nZRItChRj";
		buffer[4] = "aGFsbGVuZ2VfZ3JvdXBfbGlzdBgIIAMoCzIPLkNoYWxsZW5nZUdyb3VwEg8K";
		buffer[5] = "B3JldGNvZGUYCyABKA0SMQoObWF4X2xldmVsX2xpc3QYDCADKAsyGS5DaGFs";
		buffer[6] = "bGVuZ2VIaXN0b3J5TWF4TGV2ZWxCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[7] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			ChallengeReflection.Descriptor,
			ChallengeGroupReflection.Descriptor,
			ChallengeHistoryMaxLevelReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetChallengeScRsp), GetChallengeScRsp.Parser, new string[5] { "MHAPIHCJPJM", "ChallengeList", "ChallengeGroupList", "Retcode", "MaxLevelList" }, null, null, null, null)
		}));
	}
}
