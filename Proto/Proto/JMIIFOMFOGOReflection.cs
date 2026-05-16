using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JMIIFOMFOGOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JMIIFOMFOGOReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChFKTUlJRk9NRk9HTy5wcm90bxoRQkdLSU5DRkdLR0kucHJvdG8aDkl0ZW1M";
		buffer[1] = "aXN0LnByb3RvGhFQSENDRERLR0JIQy5wcm90byKRAgoLSk1JSUZPTUZPR08S";
		buffer[2] = "EwoLRURJR0ZORlBCS0EYASABKA0SDgoGaXNfd2luGAIgASgIEhMKC0dHTE9D";
		buffer[3] = "UEpNRUhJGAMgASgNEiEKC0lDT0FMR0tBTkxCGAQgASgLMgwuQkdLSU5DRkdL";
		buffer[4] = "R0kSHgoLQUVGRU1NSVBPQUYYCCABKAsyCS5JdGVtTGlzdBIhCgtyZWNvcmRf";
		buffer[5] = "aW5mbxgKIAEoCzIMLlBIQ0NEREtHQkhDEhAKCHNjb3JlX2lkGAsgASgNEhMK";
		buffer[6] = "C0FNS0ZLRENGTUlNGA0gASgNEhMKC0dMRUVOT0tOR0NJGA8gASgNEhQKC0RD";
		buffer[7] = "QktKT0NFRk5GGOoBIAEoDRIQCgdhcmVhX2lkGPsFIAEoDUIWqgITTWFyY2g3";
		buffer[8] = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			BGKINCFGKGIReflection.Descriptor,
			ItemListReflection.Descriptor,
			PHCCDDKGBHCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JMIIFOMFOGO), JMIIFOMFOGO.Parser, new string[11]
			{
				"EDIGFNFPBKA", "IsWin", "GGLOCPJMEHI", "ICOALGKANLB", "AEFEMMIPOAF", "RecordInfo", "ScoreId", "AMKFKDCFMIM", "GLEENOKNGCI", "DCBKJOCEFNF",
				"AreaId"
			}, null, null, null, null)
		}));
	}
}
