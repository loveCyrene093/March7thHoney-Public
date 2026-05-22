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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiBHcmlkRmlnaHRBdWdtZW50QWN0aW9uSW5mby5wcm90bxohR3JpZEZpZ2h0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "UGVuZGluZ0F1Z21lbnRJbmZvLnByb3RvIl0KGkdyaWRGaWdodEF1Z21lbnRB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "Y3Rpb25JbmZvEj8KGXBlbmRpbmdfYXVnbWVudF9pbmZvX2xpc3QYCSADKAsy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "HC5HcmlkRmlnaHRQZW5kaW5nQXVnbWVudEluZm9CFqoCE01hcmNoN3RoSG9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { GridFightPendingAugmentInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightAugmentActionInfo), GridFightAugmentActionInfo.Parser, new string[1] { "PendingAugmentInfoList" }, null, null, null, null)
		}));
	}
}
