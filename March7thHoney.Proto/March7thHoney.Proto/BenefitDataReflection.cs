using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BenefitDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BenefitDataReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCZW5lZml0RGF0YS5wcm90bxoRRkhCRkZJRklQT0EucHJvdG8iZAoLQmVu" + "ZWZpdERhdGESDQoFbGV2ZWwYAiABKA0SIQoLT0RMQk9LSERBTkwYAyABKAsy" + "DC5GSEJGRklGSVBPQRIOCgZzdGF0dXMYBCABKA0SEwoLQ09PT0ZGS0lETUMY" + "ByABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { FHBFFIFIPOAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BenefitData), BenefitData.Parser, new string[4] { "Level", "ODLBOKHDANL", "Status", "COOOFFKIDMC" }, null, null, null, null)
		}));
	}
}
