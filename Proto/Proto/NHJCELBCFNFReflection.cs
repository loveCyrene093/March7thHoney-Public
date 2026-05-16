using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NHJCELBCFNFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NHJCELBCFNFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOSEpDRUxCQ0ZORi5wcm90byJHCgtOSEpDRUxCQ0ZORhITCgtCSktOTEdJ" + "QkNHQhgIIAMoDRIRCgllZmZlY3RfaWQYCSABKA0SEAoIdHJhaXRfaWQYDSAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NHJCELBCFNF), NHJCELBCFNF.Parser, new string[3] { "BJKNLGIBCGB", "EffectId", "TraitId" }, null, null, null, null)
		}));
	}
}
