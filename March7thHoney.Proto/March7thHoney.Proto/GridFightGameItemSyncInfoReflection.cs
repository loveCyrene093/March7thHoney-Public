using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightGameItemSyncInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightGameItemSyncInfoReflection()
	{
		InlineArray11<string> buffer = default(InlineArray11<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 0) = "Ch9HcmlkRmlnaHRHYW1lSXRlbVN5bmNJbmZvLnByb3RvGh1HcmlkRmlnaHRD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 1) = "b25zdW1hYmxlSW5mby5wcm90bxojR3JpZEZpZ2h0Q29uc3VtYWJsZVVwZGF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 2) = "ZUluZm8ucHJvdG8aHEdyaWRGaWdodEVxdWlwbWVudEluZm8ucHJvdG8aG0dy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 3) = "aWRHYW1lRm9yZ2VJdGVtSW5mby5wcm90byKbAgoZR3JpZEZpZ2h0R2FtZUl0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 4) = "ZW1TeW5jSW5mbxI5ChlncmlkX2dhbWVfZm9yZ2VfaXRlbV9saXN0GAQgAygL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 5) = "MhYuR3JpZEdhbWVGb3JnZUl0ZW1JbmZvEjoKGWdyaWRfZmlnaHRfZXF1aXBt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 6) = "ZW50X2xpc3QYCSADKAsyFy5HcmlkRmlnaHRFcXVpcG1lbnRJbmZvEjwKGmdy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 7) = "aWRfZmlnaHRfY29uc3VtYWJsZV9saXN0GAogAygLMhguR3JpZEZpZ2h0Q29u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 8) = "c3VtYWJsZUluZm8SSQohdXBkYXRlX2dyaWRfZmlnaHRfY29uc3VtYWJsZV9s";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 9) = "aXN0GAwgAygLMh4uR3JpZEZpZ2h0Q29uc3VtYWJsZVVwZGF0ZUluZm9CFqoC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 10) = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray11<string>, string>(in buffer, 11))), new FileDescriptor[4]
		{
			GridFightConsumableInfoReflection.Descriptor,
			GridFightConsumableUpdateInfoReflection.Descriptor,
			GridFightEquipmentInfoReflection.Descriptor,
			GridGameForgeItemInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightGameItemSyncInfo), GridFightGameItemSyncInfo.Parser, new string[4] { "GridGameForgeItemList", "GridFightEquipmentList", "GridFightConsumableList", "UpdateGridFightConsumableList" }, null, null, null, null)
		}));
	}
}
