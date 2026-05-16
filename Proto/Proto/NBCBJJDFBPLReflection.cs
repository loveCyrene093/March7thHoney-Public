using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NBCBJJDFBPLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NBCBJJDFBPLReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFOQkNCSkpERkJQTC5wcm90bxoRTVBHSU9IRE1GQ0cucHJvdG8aEVBCS1BQ";
		buffer[1] = "RUFQQk9NLnByb3RvIssBCgtOQkNCSkpERkJQTBITCgtJSFBHQ0FBQUdCQxgB";
		buffer[2] = "IAEoDRIMCgRyYW5rGAIgASgNEhAKCHNjb3JlX2lkGAMgASgNEhMKC01DQ0xO";
		buffer[3] = "RENKQU1JGAQgASgNEh8KCWl0ZW1fbGlzdBgHIAMoCzIMLk1QR0lPSERNRkNH";
		buffer[4] = "EhMKC0pLUEdBQ0xLRUVDGAkgASgNEhsKBXN0YXRlGAsgASgOMgwuUEJLUFBF";
		buffer[5] = "QVBCT00SCgoCaHAYDSABKA0SEwoLR0ROSUhBTE9LSEMYDyABKAhCFqoCE01h";
		buffer[6] = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			MPGIOHDMFCGReflection.Descriptor,
			PBKPPEAPBOMReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NBCBJJDFBPL), NBCBJJDFBPL.Parser, new string[9] { "IHPGCAAAGBC", "Rank", "ScoreId", "MCCLNDCJAMI", "ItemList", "JKPGACLKEEC", "State", "Hp", "GDNIHALOKHC" }, null, null, null, null)
		}));
	}
}
