using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NpcMeetByPerformanceStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NpcMeetByPerformanceStatusReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBOcGNNZWV0QnlQZXJmb3JtYW5jZVN0YXR1cy5wcm90byJFChpOcGNNZWV0" + "QnlQZXJmb3JtYW5jZVN0YXR1cxIWCg5wZXJmb3JtYW5jZV9pZBgIIAEoDRIP" + "Cgdpc19tZWV0GAogASgIQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NpcMeetByPerformanceStatus), NpcMeetByPerformanceStatus.Parser, new string[2] { "PerformanceId", "IsMeet" }, null, null, null, null)
		}));
	}
}
