using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightGameItemsInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightGameItemsInfoReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChxHcmlkRmlnaHRHYW1lSXRlbXNJbmZvLnByb3RvGh1HcmlkRmlnaHRDb25z";
		buffer[1] = "dW1hYmxlSW5mby5wcm90bxocR3JpZEZpZ2h0RXF1aXBtZW50SW5mby5wcm90";
		buffer[2] = "bxobR3JpZEdhbWVGb3JnZUl0ZW1JbmZvLnByb3RvIs0BChZHcmlkRmlnaHRH";
		buffer[3] = "YW1lSXRlbXNJbmZvEjoKGWdyaWRfZmlnaHRfZXF1aXBtZW50X2xpc3QYAiAD";
		buffer[4] = "KAsyFy5HcmlkRmlnaHRFcXVpcG1lbnRJbmZvEjkKGWdyaWRfZ2FtZV9mb3Jn";
		buffer[5] = "ZV9pdGVtX2xpc3QYByADKAsyFi5HcmlkR2FtZUZvcmdlSXRlbUluZm8SPAoa";
		buffer[6] = "Z3JpZF9maWdodF9jb25zdW1hYmxlX2xpc3QYCSADKAsyGC5HcmlkRmlnaHRD";
		buffer[7] = "b25zdW1hYmxlSW5mb0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			GridFightConsumableInfoReflection.Descriptor,
			GridFightEquipmentInfoReflection.Descriptor,
			GridGameForgeItemInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightGameItemsInfo), GridFightGameItemsInfo.Parser, new string[3] { "GridFightEquipmentList", "GridGameForgeItemList", "GridFightConsumableList" }, null, null, null, null)
		}));
	}
}
