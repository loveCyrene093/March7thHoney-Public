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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "Cg1Qcm9kdWN0LnByb3RvGhVQcm9kdWN0R2lmdFR5cGUucHJvdG8i0gEKB1By";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "b2R1Y3QSEgoKYmVnaW5fdGltZRgBIAEoAxISCgpwcmljZV90aWVyGAMgASgJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "EhMKC01FTU5DSkxLQUVFGAUgASgNEiMKCWdpZnRfdHlwZRgHIAEoDjIQLlBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "b2R1Y3RHaWZ0VHlwZRISCgpwcm9kdWN0X2lkGAggASgJEhAKCGVuZF90aW1l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "GAkgASgDEhUKDWRvdWJsZV9yZXdhcmQYDCABKAgSEwoLRUVGSEVCS0hLQUIY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "DiABKA0SEwoLSkNKR0hDT0VPT0oYDyABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[1] { ProductGiftTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Product), Product.Parser, new string[9] { "BeginTime", "PriceTier", "MEMNCJLKAEE", "GiftType", "ProductId", "EndTime", "DoubleReward", "EEFHEBKHKAB", "JCJGHCOEOOJ" }, null, null, null, null)
		}));
	}
}
