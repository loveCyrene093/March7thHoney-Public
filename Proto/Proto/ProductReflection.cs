using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ProductReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ProductReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "Cg1Qcm9kdWN0LnByb3RvGhVQcm9kdWN0R2lmdFR5cGUucHJvdG8i0gEKB1By";
		buffer[1] = "b2R1Y3QSEgoKYmVnaW5fdGltZRgBIAEoAxISCgpwcmljZV90aWVyGAMgASgJ";
		buffer[2] = "EhMKC01FTU5DSkxLQUVFGAUgASgNEiMKCWdpZnRfdHlwZRgHIAEoDjIQLlBy";
		buffer[3] = "b2R1Y3RHaWZ0VHlwZRISCgpwcm9kdWN0X2lkGAggASgJEhAKCGVuZF90aW1l";
		buffer[4] = "GAkgASgDEhUKDWRvdWJsZV9yZXdhcmQYDCABKAgSEwoLRUVGSEVCS0hLQUIY";
		buffer[5] = "DiABKA0SEwoLSkNKR0hDT0VPT0oYDyABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		buffer[6] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ProductGiftTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Product), Product.Parser, new string[9] { "BeginTime", "PriceTier", "MEMNCJLKAEE", "GiftType", "ProductId", "EndTime", "DoubleReward", "EEFHEBKHKAB", "JCJGHCOEOOJ" }, null, null, null, null)
		}));
	}
}
