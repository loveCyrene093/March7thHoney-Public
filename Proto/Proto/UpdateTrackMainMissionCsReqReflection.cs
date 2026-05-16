using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdateTrackMainMissionCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdateTrackMainMissionCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiFVcGRhdGVUcmFja01haW5NaXNzaW9uQ3NSZXEucHJvdG8aJFRyYWNrTWFp";
		buffer[1] = "bk1pc3Npb25VcGRhdGVSZWFzb25JZC5wcm90byKCAQobVXBkYXRlVHJhY2tN";
		buffer[2] = "YWluTWlzc2lvbkNzUmVxEjQKC05JTExNS01LT0RQGAEgASgOMh8uVHJhY2tN";
		buffer[3] = "YWluTWlzc2lvblVwZGF0ZVJlYXNvbklkEhgKEHRyYWNrX21pc3Npb25faWQY";
		buffer[4] = "AyABKA0SEwoLR05QREdMR0JJTU0YBCABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		buffer[5] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { TrackMainMissionUpdateReasonIdReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdateTrackMainMissionCsReq), UpdateTrackMainMissionCsReq.Parser, new string[3] { "NILLMKMKODP", "TrackMissionId", "GNPDGLGBIMM" }, null, null, null, null)
		}));
	}
}
