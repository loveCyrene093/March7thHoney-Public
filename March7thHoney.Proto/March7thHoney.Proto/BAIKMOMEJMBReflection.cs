using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BAIKMOMEJMBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BAIKMOMEJMBReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFCQUlLTU9NRUpNQi5wcm90bxoRSUxMQk5LRkJOQlAucHJvdG8aEkl0ZW1D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "b3N0RGF0YS5wcm90byKLAQoLQkFJS01PTUVKTUISIQoLRUlFTktKRkZGSkcY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "CSABKAsyDC5JTExCTktGQk5CUBIgCgljb3N0X2RhdGEYCyABKAsyDS5JdGVt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "Q29zdERhdGESEwoLS0xOSExFSktETUwYDSABKAgSIgoLRUtLSUFITk1ESE0Y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "DiABKAsyDS5JdGVtQ29zdERhdGFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			ILLBNKFBNBPReflection.Descriptor,
			ItemCostDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BAIKMOMEJMB), BAIKMOMEJMB.Parser, new string[4] { "EIENKJFFFJG", "CostData", "KLNHLEJKDML", "EKKIAHNMDHM" }, null, null, null, null)
		}));
	}
}
