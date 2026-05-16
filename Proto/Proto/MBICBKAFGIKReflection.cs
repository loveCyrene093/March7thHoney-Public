using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MBICBKAFGIKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MBICBKAFGIKReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFNQklDQktBRkdJSy5wcm90bxoTSGVhZEZyYW1lSW5mby5wcm90bxoSUGxh";
		buffer[1] = "dGZvcm1UeXBlLnByb3RvIuwBCgtNQklDQktBRkdJSxITCgtyZW1hcmtfbmFt";
		buffer[2] = "ZRgBIAEoCRInCg9oZWFkX2ZyYW1lX2luZm8YAyABKAsyDi5IZWFkRnJhbWVJ";
		buffer[3] = "bmZvEhMKC0NMRE5HQUVJQkRGGAQgASgNEhAKCG5pY2tuYW1lGAUgASgJEgsK";
		buffer[4] = "A3VpZBgGIAEoDRINCgVsZXZlbBgHIAEoDRITCgtHS0RQTENDQUxNSBgJIAEo";
		buffer[5] = "DRITCgtJQ0pJR0hPTUROTBgKIAEoCRIfCghwbGF0Zm9ybRgMIAEoDjINLlBs";
		buffer[6] = "YXRmb3JtVHlwZRIRCgloZWFkX2ljb24YDiABKA1CFqoCE01hcmNoN3RoSG9u";
		buffer[7] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			HeadFrameInfoReflection.Descriptor,
			PlatformTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MBICBKAFGIK), MBICBKAFGIK.Parser, new string[10] { "RemarkName", "HeadFrameInfo", "CLDNGAEIBDF", "Nickname", "Uid", "Level", "GKDPLCCALMH", "ICJIGHOMDNL", "Platform", "HeadIcon" }, null, null, null, null)
		}));
	}
}
