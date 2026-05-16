using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KJGMAEGNBKLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KJGMAEGNBKLReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFLSkdNQUVHTkJLTC5wcm90bxoVQXJlYUR5bmFtaWNJbmZvLnByb3RvGhFJ";
		buffer[1] = "T0JCSUxHT0ZDTC5wcm90bxoRTE1IRk9GSUVJTU4ucHJvdG8iegoLS0pHTUFF";
		buffer[2] = "R05CS0wSJQoLSkRCT0lISkhFSFAYAiADKAsyEC5BcmVhRHluYW1pY0luZm8S";
		buffer[3] = "IQoLTk1MQU5QSkdKRkEYBCADKAsyDC5MTUhGT0ZJRUlNThIhCgtJRFBIQ0tB";
		buffer[4] = "QkJKTRgJIAMoCzIMLklPQkJJTEdPRkNMQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[5] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			AreaDynamicInfoReflection.Descriptor,
			IOBBILGOFCLReflection.Descriptor,
			LMHFOFIEIMNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KJGMAEGNBKL), KJGMAEGNBKL.Parser, new string[3] { "JDBOIHJHEHP", "NMLANPJGJFA", "IDPHCKABBJM" }, null, null, null, null)
		}));
	}
}
