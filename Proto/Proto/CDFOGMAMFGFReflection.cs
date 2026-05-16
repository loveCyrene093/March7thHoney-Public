using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CDFOGMAMFGFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CDFOGMAMFGFReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFDREZPR01BTUZHRi5wcm90bxoRSEROT0ZGR01ETkoucHJvdG8aEU5FSUlE";
		buffer[1] = "REFNUEdMLnByb3RvIokBCgtDREZPR01BTUZHRhIhCgtDR0xJUE1JTU1KRxgB";
		buffer[2] = "IAMoCzIMLk5FSUlEREFNUEdMEiEKC1BMTUhBUFBLTEdBGAcgASgLMgwuSERO";
		buffer[3] = "T0ZGR01ETkoSEQoJY3VyX2luZGV4GAkgASgNEiEKC0JNTkRCS0JISU9DGA8g";
		buffer[4] = "ASgLMgwuSEROT0ZGR01ETkpCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[5] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			HDNOFFGMDNJReflection.Descriptor,
			NEIIDDAMPGLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CDFOGMAMFGF), CDFOGMAMFGF.Parser, new string[4] { "CGLIPMIMMJG", "PLMHAPPKLGA", "CurIndex", "BMNDBKBHIOC" }, null, null, null, null)
		}));
	}
}
