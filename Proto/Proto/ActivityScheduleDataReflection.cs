using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ActivityScheduleDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ActivityScheduleDataReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpBY3Rpdml0eVNjaGVkdWxlRGF0YS5wcm90byJjChRBY3Rpdml0eVNjaGVk" + "dWxlRGF0YRISCgpiZWdpbl90aW1lGAYgASgDEhAKCHBhbmVsX2lkGAsgASgN" + "EhAKCGVuZF90aW1lGAwgASgDEhMKC2FjdGl2aXR5X2lkGA8gASgNQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ActivityScheduleData), ActivityScheduleData.Parser, new string[4] { "BeginTime", "PanelId", "EndTime", "ActivityId" }, null, null, null, null)
		}));
	}
}
