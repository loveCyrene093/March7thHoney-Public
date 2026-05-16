using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OfferingInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OfferingInfoReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChJPZmZlcmluZ0luZm8ucHJvdG8aE09mZmVyaW5nU3RhdGUucHJvdG8iqwEK";
		buffer[1] = "DE9mZmVyaW5nSW5mbxIRCgl0b3RhbF9leHAYASABKA0SFgoOb2ZmZXJpbmdf";
		buffer[2] = "bGV2ZWwYBCABKA0SIAoYaGFzX3Rha2VuX3Jld2FyZF9pZF9saXN0GAYgAygN";
		buffer[3] = "EhMKC29mZmVyaW5nX2lkGAcgASgNEhEKCWxldmVsX2V4cBgMIAEoDRImCg5v";
		buffer[4] = "ZmZlcmluZ19zdGF0ZRgOIAEoDjIOLk9mZmVyaW5nU3RhdGVCFqoCE01hcmNo";
		buffer[5] = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { OfferingStateReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OfferingInfo), OfferingInfo.Parser, new string[6] { "TotalExp", "OfferingLevel", "HasTakenRewardIdList", "OfferingId", "LevelExp", "OfferingState" }, null, null, null, null)
		}));
	}
}
