using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyInfoReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		buffer[0] = "ChRUcmFpblBhcnR5SW5mby5wcm90bxoRQ0JHQU9EQ0tBR0IucHJvdG8aEUND";
		buffer[1] = "QUlQRUJDSU1ILnByb3RvGhFHSExETkRERkVJRS5wcm90bxoRS0pHTUFFR05C";
		buffer[2] = "S0wucHJvdG8aFFRyYWluUGFydHlBcmVhLnByb3RvIv4CCg5UcmFpblBhcnR5";
		buffer[3] = "SW5mbxIhCgtITkZOS0xITEpMRxgBIAMoCzIMLkdITERORERGRUlFEhMKC0VL";
		buffer[4] = "TElBT0JDSFBJGAIgASgIEiEKC0ZDTEpFQUNLR0xFGAMgASgLMgwuS0pHTUFF";
		buffer[5] = "R05CS0wSEwoLTVBET05JS0hJT0IYBCADKA0SEwoLTk1CRk1ITE5QTE0YBSAB";
		buffer[6] = "KA0SFwoPZHluYW1pY19pZF9saXN0GAYgAygNEiEKC0dCREVHREdHS09MGAcg";
		buffer[7] = "AygLMgwuQ0NBSVBFQkNJTUgSEAoIY3VyX2Z1bmQYCSABKA0SEwoLT0JBTUhD";
		buffer[8] = "SUZGT0MYCiABKA0SEwoLQUxPREpGUERLQU0YCyABKA0SEwoLT0xIR01QQ0RE";
		buffer[9] = "S0EYDCABKA0SIQoLTU1GRVBFQkdBRkMYDSADKAsyDC5DQkdBT0RDS0FHQhIT";
		buffer[10] = "CgtISUhLR1BKQ0RQSxgOIAEoDRIiCglhcmVhX2xpc3QYDyADKAsyDy5UcmFp";
		buffer[11] = "blBhcnR5QXJlYUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[5]
		{
			CBGAODCKAGBReflection.Descriptor,
			CCAIPEBCIMHReflection.Descriptor,
			GHLDNDDFEIEReflection.Descriptor,
			KJGMAEGNBKLReflection.Descriptor,
			TrainPartyAreaReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyInfo), TrainPartyInfo.Parser, new string[14]
			{
				"HNFNKLHLJLG", "EKLIAOBCHPI", "FCLJEACKGLE", "MPDONIKHIOB", "NMBFMHLNPLM", "DynamicIdList", "GBDEGDGGKOL", "CurFund", "OBAMHCIFFOC", "ALODJFPDKAM",
				"OLHGMPCDDKA", "MMFEPEBGAFC", "HIHKGPJCDPK", "AreaList"
			}, null, null, null, null)
		}));
	}
}
