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
		buffer[0] = "ChFBTklPTUtEQ09FUC5wcm90bxoRR0xBQUpLSEtNSEIucHJvdG8aEUpDRkRD";
		buffer[1] = "RUtMQkZILnByb3RvIr8BCgtBTklPTUtEQ09FUBIhCgtCRE1OSEZOS01EQRgG";
		buffer[2] = "IAMoCzIMLkdMQUFKS0hLTUhCEiUKD3Nob3BfZ29vZHNfbGlzdBgHIAMoCzIM";
		buffer[3] = "LkpDRkRDRUtMQkZIEhMKC0VCS0xQS05BTkxOGAggASgIEhIKCml0ZW1fdmFs";
		buffer[4] = "dWUYCSABKA0SEwoLRkRNRUZJSUpMQ0sYCyABKA0SEwoLQUFBQk9PRkFGTEoY";
		buffer[5] = "DiABKA0SEwoLR09DR0ZNQUxFT1AYDyABKAhCFqoCE01hcmNoN3RoSG9uZXku";
		buffer[6] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			GLAAJKHKMHBReflection.Descriptor,
			JCFDCEKLBFHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ANIOMKDCOEP), ANIOMKDCOEP.Parser, new string[7] { "BDMNHFNKMDA", "ShopGoodsList", "EBKLPKNANLN", "ItemValue", "FDMEFIIJLCK", "AAABOOFAFLJ", "GOCGFMALEOP" }, null, null, null, null)
		}));
	}
}
