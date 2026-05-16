using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightAugmentActionInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightAugmentActionInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiBHcmlkRmlnaHRBdWdtZW50QWN0aW9uSW5mby5wcm90bxohR3JpZEZpZ2h0";
		buffer[1] = "UGVuZGluZ0F1Z21lbnRJbmZvLnByb3RvIl0KGkdyaWRGaWdodEF1Z21lbnRB";
		buffer[2] = "Y3Rpb25JbmZvEj8KGXBlbmRpbmdfYXVnbWVudF9pbmZvX2xpc3QYCSADKAsy";
		buffer[3] = "HC5HcmlkRmlnaHRQZW5kaW5nQXVnbWVudEluZm9CFqoCE01hcmNoN3RoSG9u";
		buffer[4] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GridFightPendingAugmentInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightAugmentActionInfo), GridFightAugmentActionInfo.Parser, new string[1] { "PendingAugmentInfoList" }, null, null, null, null)
		}));
	}
}
