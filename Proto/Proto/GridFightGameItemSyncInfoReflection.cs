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
		buffer[0] = "Ch9HcmlkRmlnaHRHYW1lSXRlbVN5bmNJbmZvLnByb3RvGh1HcmlkRmlnaHRD";
		buffer[1] = "b25zdW1hYmxlSW5mby5wcm90bxojR3JpZEZpZ2h0Q29uc3VtYWJsZVVwZGF0";
		buffer[2] = "ZUluZm8ucHJvdG8aHEdyaWRGaWdodEVxdWlwbWVudEluZm8ucHJvdG8aG0dy";
		buffer[3] = "aWRHYW1lRm9yZ2VJdGVtSW5mby5wcm90byKbAgoZR3JpZEZpZ2h0R2FtZUl0";
		buffer[4] = "ZW1TeW5jSW5mbxI5ChlncmlkX2dhbWVfZm9yZ2VfaXRlbV9saXN0GAQgAygL";
		buffer[5] = "MhYuR3JpZEdhbWVGb3JnZUl0ZW1JbmZvEjoKGWdyaWRfZmlnaHRfZXF1aXBt";
		buffer[6] = "ZW50X2xpc3QYCSADKAsyFy5HcmlkRmlnaHRFcXVpcG1lbnRJbmZvEjwKGmdy";
		buffer[7] = "aWRfZmlnaHRfY29uc3VtYWJsZV9saXN0GAogAygLMhguR3JpZEZpZ2h0Q29u";
		buffer[8] = "c3VtYWJsZUluZm8SSQohdXBkYXRlX2dyaWRfZmlnaHRfY29uc3VtYWJsZV9s";
		buffer[9] = "aXN0GAwgAygLMh4uR3JpZEZpZ2h0Q29uc3VtYWJsZVVwZGF0ZUluZm9CFqoC";
		buffer[10] = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
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
