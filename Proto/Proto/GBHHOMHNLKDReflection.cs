using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GBHHOMHNLKDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GBHHOMHNLKDReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFHQkhIT01ITkxLRC5wcm90bxoRSUZKRURKQUZDSk4ucHJvdG8aEUpLSUNM";
		buffer[1] = "RkJJTkhOLnByb3RvIqQBCgtHQkhIT01ITkxLRBIOCgZhcmdfaWQYAiABKA0S";
		buffer[2] = "EwoLTklLRUVETEpIUEQYBSABKAgSEwoLQ0hDR01BTU9CTUgYByABKAgSEwoL";
		buffer[3] = "QU1BREZKTkhNRkYYCCABKA0SIwoNZGlzcGxheV92YWx1ZRgKIAEoCzIMLkpL";
		buffer[4] = "SUNMRkJJTkhOEiEKC0tESURORUxFREpEGA4gAygLMgwuSUZKRURKQUZDSk5C";
		buffer[5] = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			IFJEDJAFCJNReflection.Descriptor,
			JKICLFBINHNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GBHHOMHNLKD), GBHHOMHNLKD.Parser, new string[6] { "ArgId", "NIKEEDLJHPD", "CHCGMAMOBMH", "AMADFJNHMFF", "DisplayValue", "KDIDNELEDJD" }, null, null, null, null)
		}));
	}
}
