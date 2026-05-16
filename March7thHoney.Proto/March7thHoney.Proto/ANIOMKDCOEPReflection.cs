using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ANIOMKDCOEPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ANIOMKDCOEPReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChFBTklPTUtEQ09FUC5wcm90bxoRR0xBQUpLSEtNSEIucHJvdG8aEUpDRkRD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "RUtMQkZILnByb3RvIr8BCgtBTklPTUtEQ09FUBIhCgtCRE1OSEZOS01EQRgG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "IAMoCzIMLkdMQUFKS0hLTUhCEiUKD3Nob3BfZ29vZHNfbGlzdBgHIAMoCzIM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "LkpDRkRDRUtMQkZIEhMKC0VCS0xQS05BTkxOGAggASgIEhIKCml0ZW1fdmFs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "dWUYCSABKA0SEwoLRkRNRUZJSUpMQ0sYCyABKA0SEwoLQUFBQk9PRkFGTEoY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "DiABKA0SEwoLR09DR0ZNQUxFT1AYDyABKAhCFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			GLAAJKHKMHBReflection.Descriptor,
			JCFDCEKLBFHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ANIOMKDCOEP), ANIOMKDCOEP.Parser, new string[7] { "BDMNHFNKMDA", "ShopGoodsList", "EBKLPKNANLN", "ItemValue", "FDMEFIIJLCK", "AAABOOFAFLJ", "GOCGFMALEOP" }, null, null, null, null)
		}));
	}
}
