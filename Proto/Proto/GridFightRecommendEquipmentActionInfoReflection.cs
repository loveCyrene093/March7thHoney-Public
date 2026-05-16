using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightRecommendEquipmentActionInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightRecommendEquipmentActionInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CitHcmlkRmlnaHRSZWNvbW1lbmRFcXVpcG1lbnRBY3Rpb25JbmZvLnByb3Rv" + "IkkKJUdyaWRGaWdodFJlY29tbWVuZEVxdWlwbWVudEFjdGlvbkluZm8SIAoY" + "YXZhaWxhYmxlX2VxdWlwbWVudF9saXN0GAQgAygNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightRecommendEquipmentActionInfo), GridFightRecommendEquipmentActionInfo.Parser, new string[1] { "AvailableEquipmentList" }, null, null, null, null)
		}));
	}
}
