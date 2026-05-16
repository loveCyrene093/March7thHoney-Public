using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PropTimelineInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PropTimelineInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZQcm9wVGltZWxpbmVJbmZvLnByb3RvIkwKEFByb3BUaW1lbGluZUluZm8S" + "GwoTdGltZWxpbmVfYm9vbF92YWx1ZRgDIAEoCBIbChN0aW1lbGluZV9ieXRl" + "X3ZhbHVlGAwgASgMQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PropTimelineInfo), PropTimelineInfo.Parser, new string[2] { "TimelineBoolValue", "TimelineByteValue" }, null, null, null, null)
		}));
	}
}
