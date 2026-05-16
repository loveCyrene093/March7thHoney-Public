using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EndDrinkMakerSequenceScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EndDrinkMakerSequenceScRspReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "CiBFbmREcmlua01ha2VyU2VxdWVuY2VTY1JzcC5wcm90bxoOSXRlbUxpc3Qu";
		buffer[1] = "cHJvdG8aEUpMTUNOSktNQ0ZHLnByb3RvGhFQT0hJRUtQSE1HSC5wcm90byLU";
		buffer[2] = "AQoaRW5kRHJpbmtNYWtlclNlcXVlbmNlU2NSc3ASCwoDZXhwGAEgASgNEg0K";
		buffer[3] = "BWxldmVsGAIgASgNEhkKBnJld2FyZBgDIAEoCzIJLkl0ZW1MaXN0EiEKC0RB";
		buffer[4] = "TkZJQk1ITU5EGAUgAygLMgwuSkxNQ05KS01DRkcSEwoLTFBETVBOQUJCRU4Y";
		buffer[5] = "BiABKA0SEwoLRURCT0hESkRKQUEYByABKA0SDwoHcmV0Y29kZRgIIAEoDRIh";
		buffer[6] = "CgtQRFBNTERNT01QSBgLIAEoCzIMLlBPSElFS1BITUdIQhaqAhNNYXJjaDd0";
		buffer[7] = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			ItemListReflection.Descriptor,
			JLMCNJKMCFGReflection.Descriptor,
			POHIEKPHMGHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EndDrinkMakerSequenceScRsp), EndDrinkMakerSequenceScRsp.Parser, new string[8] { "Exp", "Level", "Reward", "DANFIBMHMND", "LPDMPNABBEN", "EDBOHDJDJAA", "Retcode", "PDPMLDMOMPH" }, null, null, null, null)
		}));
	}
}
