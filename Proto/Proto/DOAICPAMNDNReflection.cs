using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DOAICPAMNDNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DOAICPAMNDNReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		buffer[0] = "ChFET0FJQ1BBTU5ETi5wcm90bxoRQ0lQQkJQSEdFS0oucHJvdG8aEUNLSERO";
		buffer[1] = "SkdNRUpDLnByb3RvGhFHREtQQkRBQUtCSC5wcm90bxoRR1BPTkFLTkhMSkcu";
		buffer[2] = "cHJvdG8aEUtBQ09PRklLSE9HLnByb3RvGhFQQk5MS0pJRUZQTS5wcm90bxoR";
		buffer[3] = "UE9OUEhIREJFSkoucHJvdG8ivgIKC0RPQUlDUEFNTkROEiEKC0RFUExMSlBL";
		buffer[4] = "S0dEGAIgAygLMgwuQ0tIRE5KR01FSkMSEAoIc2NvcmVfaWQYAyABKA0SIQoL";
		buffer[5] = "RkhLRU1DTEZCT04YBCABKAsyDC5HREtQQkRBQUtCSBITCgtFUExCQ05GTUxJ";
		buffer[6] = "TBgGIAEoDRIhCgtORU5QTkRLTUhPTRgIIAMoCzIMLktBQ09PRklLSE9HEiEK";
		buffer[7] = "C0JIQUJHQVBKQUhGGAkgAygLMgwuQ0lQQkJQSEdFS0oSEwoLRklITE5PSkFL";
		buffer[8] = "Q0gYCiABKA0SIQoLQkhER1BMUEpLQUEYCyADKAsyDC5HUE9OQUtOSExKRxIh";
		buffer[9] = "CgtESkVIRENDQUpDSxgNIAEoCzIMLlBCTkxLSklFRlBNEiEKC0xKQkhISURJ";
		buffer[10] = "TE9OGA4gASgOMgwuUE9OUEhIREJFSkpCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[11] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[7]
		{
			CIPBBPHGEKJReflection.Descriptor,
			CKHDNJGMEJCReflection.Descriptor,
			GDKPBDAAKBHReflection.Descriptor,
			GPONAKNHLJGReflection.Descriptor,
			KACOOFIKHOGReflection.Descriptor,
			PBNLKJIEFPMReflection.Descriptor,
			PONPHHDBEJJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DOAICPAMNDN), DOAICPAMNDN.Parser, new string[10] { "DEPLLJPKKGD", "ScoreId", "FHKEMCLFBON", "EPLBCNFMLIL", "NENPNDKMHOM", "BHABGAPJAHF", "FIHLNOJAKCH", "BHDGPLPJKAA", "DJEHDCCAJCK", "LJBHHIDILON" }, null, null, null, null)
		}));
	}
}
