using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncStatusReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChBTeW5jU3RhdHVzLnByb3RvGhFHcm91cFN0YXR1cy5wcm90bxoTU2VjdGlv";
		buffer[1] = "blN0YXR1cy5wcm90byKKAQoKU3luY1N0YXR1cxImCg5zZWN0aW9uX3N0YXR1";
		buffer[2] = "cxgDIAMoCzIOLlNlY3Rpb25TdGF0dXMSEwoLQ01FS0JNQUVITEQYDCADKA0S";
		buffer[3] = "EwoLQUZLQ1BMSElNR0gYDiADKA0SKgoUbWVzc2FnZV9ncm91cF9zdGF0dXMY";
		buffer[4] = "DyADKAsyDC5Hcm91cFN0YXR1c0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[5] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			GroupStatusReflection.Descriptor,
			SectionStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncStatus), SyncStatus.Parser, new string[4] { "SectionStatus", "CMEKBMAEHLD", "AFKCPLHIMGH", "MessageGroupStatus" }, null, null, null, null)
		}));
	}
}
