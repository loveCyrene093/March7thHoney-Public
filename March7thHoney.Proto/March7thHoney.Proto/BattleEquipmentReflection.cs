using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleEquipmentReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleEquipmentReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVCYXR0bGVFcXVpcG1lbnQucHJvdG8iTQoPQmF0dGxlRXF1aXBtZW50EgoK" + "AmlkGAEgASgNEg0KBWxldmVsGAIgASgNEhEKCXByb21vdGlvbhgDIAEoDRIM" + "CgRyYW5rGAQgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BattleEquipment), BattleEquipment.Parser, new string[4] { "Id", "Level", "Promotion", "Rank" }, null, null, null, null)
		}));
	}
}
