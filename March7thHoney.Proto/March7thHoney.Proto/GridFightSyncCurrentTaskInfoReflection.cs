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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiJHcmlkRmlnaHRTeW5jQ3VycmVudFRhc2tJbmZvLnByb3RvGhpHcmlkRmln";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "aHRDdXJyZW50VGFzay5wcm90byJhChxHcmlkRmlnaHRTeW5jQ3VycmVudFRh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "c2tJbmZvEhgKEGZpbmlzaF90YXNrX2xpc3QYBSADKA0SJwoIY3VyX3Rhc2sY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "ByABKAsyFS5HcmlkRmlnaHRDdXJyZW50VGFza0IWqgITTWFyY2g3dGhIb25l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { GridFightCurrentTaskReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightSyncCurrentTaskInfo), GridFightSyncCurrentTaskInfo.Parser, new string[2] { "FinishTaskList", "CurTask" }, null, null, null, null)
		}));
	}
}
