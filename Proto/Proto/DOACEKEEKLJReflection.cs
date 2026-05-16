using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DOACEKEEKLJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DOACEKEEKLJReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFET0FDRUtFRUtMSi5wcm90byKfAQoLRE9BQ0VLRUVLTEoSEwoLRENLRUVB";
		buffer[1] = "S0VPTEMYASABKA0SEwoLTlBITEVQRUNNQUgYBCABKA0SEwoLUE5GQk9HS0NN";
		buffer[2] = "Q0UYByABKAgSEgoKaGFzX3Bhc3NlZBgKIAEoCBITCgt0YXJnZXRfc2lkZRgL";
		buffer[3] = "IAEoDRITCgtNQ0VLTUlOTUpLRhgNIAEoDRITCgtKREZESkFDUENLQxgPIAEo";
		buffer[4] = "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DOACEKEEKLJ), DOACEKEEKLJ.Parser, new string[7] { "DCKEEAKEOLC", "NPHLEPECMAH", "PNFBOGKCMCE", "HasPassed", "TargetSide", "MCEKMINMJKF", "JDFDJACPCKC" }, null, null, null, null)
		}));
	}
}
