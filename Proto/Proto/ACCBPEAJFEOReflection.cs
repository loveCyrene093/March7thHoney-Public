using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ACCBPEAJFEOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ACCBPEAJFEOReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFBQ0NCUEVBSkZFTy5wcm90bxoRTEJNTExKSEZFSEIucHJvdG8aEU9GSFBL";
		buffer[1] = "SkRIT01GLnByb3RvGhFPSkVKQ0hCSENKTC5wcm90byKrAQoLQUNDQlBFQUpG";
		buffer[2] = "RU8SHAoGc3RhdHVzGAEgASgOMgwuTEJNTExKSEZFSEISEwoLS0VESU1NQUdG";
		buffer[3] = "Qk8YBCABKA0SEwoLTkxNTUZKT1BCRkMYBSABKA0SHAoGcmVhc29uGAggASgO";
		buffer[4] = "MgwuT0ZIUEtKREhPTUYSIQoLRkhMSkVIREhKTEkYDSADKAsyDC5PSkVKQ0hC";
		buffer[5] = "SENKTBITCgtBUE1JQUtEUEhKTBgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[6] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			LBMLLJHFEHBReflection.Descriptor,
			OFHPKJDHOMFReflection.Descriptor,
			OJEJCHBHCJLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ACCBPEAJFEO), ACCBPEAJFEO.Parser, new string[6] { "Status", "KEDIMMAGFBO", "NLMMFJOPBFC", "Reason", "FHLJEHDHJLI", "APMIAKDPHJL" }, null, null, null, null)
		}));
	}
}
