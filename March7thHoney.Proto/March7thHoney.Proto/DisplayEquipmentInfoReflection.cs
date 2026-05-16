using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DisplayEquipmentInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DisplayEquipmentInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpEaXNwbGF5RXF1aXBtZW50SW5mby5wcm90byJgChREaXNwbGF5RXF1aXBt" + "ZW50SW5mbxILCgNleHAYAiABKA0SDAoEcmFuaxgIIAEoDRINCgVsZXZlbBgJ" + "IAEoDRILCgN0aWQYCyABKA0SEQoJcHJvbW90aW9uGA0gASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DisplayEquipmentInfo), DisplayEquipmentInfo.Parser, new string[5] { "Exp", "Rank", "Level", "Tid", "Promotion" }, null, null, null, null)
		}));
	}
}
