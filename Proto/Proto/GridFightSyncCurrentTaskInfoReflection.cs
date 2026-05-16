using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightSyncCurrentTaskInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightSyncCurrentTaskInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiJHcmlkRmlnaHRTeW5jQ3VycmVudFRhc2tJbmZvLnByb3RvGhpHcmlkRmln";
		buffer[1] = "aHRDdXJyZW50VGFzay5wcm90byJhChxHcmlkRmlnaHRTeW5jQ3VycmVudFRh";
		buffer[2] = "c2tJbmZvEhgKEGZpbmlzaF90YXNrX2xpc3QYBSADKA0SJwoIY3VyX3Rhc2sY";
		buffer[3] = "ByABKAsyFS5HcmlkRmlnaHRDdXJyZW50VGFza0IWqgITTWFyY2g3dGhIb25l";
		buffer[4] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GridFightCurrentTaskReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightSyncCurrentTaskInfo), GridFightSyncCurrentTaskInfo.Parser, new string[2] { "FinishTaskList", "CurTask" }, null, null, null, null)
		}));
	}
}
