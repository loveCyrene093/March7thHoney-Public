using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IEACMDFDLBFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IEACMDFDLBFReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFJRUFDTURGRExCRi5wcm90bxoRQlBITEVPQk1NS00ucHJvdG8aEUNMSkFJ";
		buffer[1] = "SE5CS0VNLnByb3RvGhFESEtGTElLTk1KTy5wcm90bxoRTUpFREFPUERJUE0u";
		buffer[2] = "cHJvdG8aEVBGSUZOTUlJT0hGLnByb3RvItABCgtJRUFDTURGRExCRhIeCgZs";
		buffer[3] = "aW5ldXAYCiABKAsyDC5ESEtGTElLTk1KT0gAEiMKC0NHQ0pMSEZMRVBOGAsg";
		buffer[4] = "ASgLMgwuQlBITEVPQk1NS01IABIjCgtQSklHSE5GSEZLRBgMIAEoCzIMLlBG";
		buffer[5] = "SUZOTUlJT0hGSAASIwoLS0ZQS0hIQU9HUFAYDSABKAsyDC5NSkVEQU9QRElQ";
		buffer[6] = "TUgAEiMKC0xFRk9JR0ZHSkdKGA4gASgLMgwuQ0xKQUlITkJLRU1IAEINCgtL";
		buffer[7] = "UFBOS0ZHUE5ITkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[5]
		{
			BPHLEOBMMKMReflection.Descriptor,
			CLJAIHNBKEMReflection.Descriptor,
			DHKFLIKNMJOReflection.Descriptor,
			MJEDAOPDIPMReflection.Descriptor,
			PFIFNMIIOHFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IEACMDFDLBF), IEACMDFDLBF.Parser, new string[5] { "Lineup", "CGCJLHFLEPN", "PJIGHNFHFKD", "KFPKHHAOGPP", "LEFOIGFGJGJ" }, new string[1] { "KPPNKFGPNHN" }, null, null, null)
		}));
	}
}
