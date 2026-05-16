using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DLCCOJPHBCBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DLCCOJPHBCBReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFETENDT0pQSEJDQi5wcm90bxoRR0lHQUtDT01LT0cucHJvdG8aEUhORENL";
		buffer[1] = "TUlBTE9HLnByb3RvGhFKQU1MSE9IQklHQi5wcm90byK1AQoLRExDQ09KUEhC";
		buffer[2] = "Q0ISIQoLS0dLT0hOQUFDRU4YASABKAsyDC5KQU1MSE9IQklHQhIhCgtJUExF";
		buffer[3] = "T09MQ0FDSRgCIAEoDjIMLkhORENLTUlBTE9HEhMKC0xIS0REQkJJS09CGAYg";
		buffer[4] = "ASgFEhMKC0pLTFBOT0ZETkFMGAogASgEEhMKC0xGQklFTEJIT0JLGAwgASgN";
		buffer[5] = "EiEKC0ROTk9GR0pKTUNQGA8gAygLMgwuR0lHQUtDT01LT0dCFqoCE01hcmNo";
		buffer[6] = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			GIGAKCOMKOGReflection.Descriptor,
			HNDCKMIALOGReflection.Descriptor,
			JAMLHOHBIGBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DLCCOJPHBCB), DLCCOJPHBCB.Parser, new string[6] { "KGKOHNAACEN", "IPLEOOLCACI", "LHKDDBBIKOB", "JKLPNOFDNAL", "LFBIELBHOBK", "DNNOFGJJMCP" }, null, null, null, null)
		}));
	}
}
