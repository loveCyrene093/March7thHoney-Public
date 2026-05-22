using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EquipmentRecommendReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EquipmentRecommendReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhFcXVpcG1lbnRSZWNvbW1lbmQucHJvdG8aEUpFRklLSEtKRkNNLnByb3Rv" + "IjoKEkVxdWlwbWVudFJlY29tbWVuZBIkCg5lcXVpcG1lbnRfbGlzdBgCIAMo" + "CzIMLkpFRklLSEtKRkNNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { JEFIKHKJFCMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EquipmentRecommend), EquipmentRecommend.Parser, new string[1] { "EquipmentList" }, null, null, null, null)
		}));
	}
}
