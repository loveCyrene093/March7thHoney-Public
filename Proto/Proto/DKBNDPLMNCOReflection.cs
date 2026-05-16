using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DKBNDPLMNCOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DKBNDPLMNCOReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFES0JORFBMTU5DTy5wcm90bxoRT0xDUElDREFPS0kucHJvdG8aEU9PQ0NM";
		buffer[1] = "Qk1MRUNFLnByb3RvIrwBCgtES0JORFBMTU5DTxIhCgtKUE9OTEREREVNSRgB";
		buffer[2] = "IAMoCzIMLk9MQ1BJQ0RBT0tJEhMKC0JFUEtCTUdLQ0dCGAIgASgIEhMKC0NP";
		buffer[3] = "RE9GREVISkNKGAMgASgNEhMKC0lQQUNHQkRLRk5BGAQgASgIEhMKC0ZLRkhN";
		buffer[4] = "TUhCSUtDGAUgAygNEhMKC09FRE1DTEJQQURHGAogASgNEiEKC0NQSkRIRkpP";
		buffer[5] = "SUFMGA4gAygLMgwuT09DQ0xCTUxFQ0VCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[6] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			OLCPICDAOKIReflection.Descriptor,
			OOCCLBMLECEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DKBNDPLMNCO), DKBNDPLMNCO.Parser, new string[7] { "JPONLDDDEMI", "BEPKBMGKCGB", "CODOFDEHJCJ", "IPACGBDKFNA", "FKFHMMHBIKC", "OEDMCLBPADG", "CPJDHFJOIAL" }, null, null, null, null)
		}));
	}
}
