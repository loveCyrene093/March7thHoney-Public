using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NOJLPMLALPIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NOJLPMLALPIReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFOT0pMUE1MQUxQSS5wcm90bxoRQkVPUERNTEtHTFAucHJvdG8aEURBUERP";
		buffer[1] = "SE9BRERCLnByb3RvGhFHS0RFS0pLT0lKTi5wcm90byLmAQoLTk9KTFBNTEFM";
		buffer[2] = "UEkSEwoLRk9PTE1JQURNTUgYASABKA0SIQoLS0xLT01MUEFMRUIYAyADKAsy";
		buffer[3] = "DC5HS0RFS0pLT0lKThITCgtBTUdNQUROQkZJRhgJIAEoDRIhCgtFUE1GREdQ";
		buffer[4] = "S1BIShgKIAMoCzIMLkJFT1BETUxLR0xQEiEKC0RFRE5ITEROS0FHGAsgAygL";
		buffer[5] = "MgwuR0tERUtKS09JSk4SIQoLTENFSERHQkJESkwYDiADKAsyDC5EQVBET0hP";
		buffer[6] = "QUREQhIhCgtERURGSEVMRkFLRhgPIAMoCzIMLkdLREVLSktPSUpOQhaqAhNN";
		buffer[7] = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			BEOPDMLKGLPReflection.Descriptor,
			DAPDOHOADDBReflection.Descriptor,
			GKDEKJKOIJNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NOJLPMLALPI), NOJLPMLALPI.Parser, new string[7] { "FOOLMIADMMH", "KLKOMLPALEB", "AMGMADNBFIF", "EPMFDGPKPHJ", "DEDNHLDNKAG", "LCEHDGBBDJL", "DEDFHELFAKF" }, null, null, null, null)
		}));
	}
}
