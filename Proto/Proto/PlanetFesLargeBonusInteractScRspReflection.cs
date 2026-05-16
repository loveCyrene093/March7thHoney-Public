using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesLargeBonusInteractScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesLargeBonusInteractScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiZQbGFuZXRGZXNMYXJnZUJvbnVzSW50ZXJhY3RTY1JzcC5wcm90bxoRRUZF";
		buffer[1] = "R0tESEVNRk4ucHJvdG8aEUpJUEFDREVKS0pDLnByb3RvIo4BCiBQbGFuZXRG";
		buffer[2] = "ZXNMYXJnZUJvbnVzSW50ZXJhY3RTY1JzcBIhCgtESUhFQ0lJS0VMRRgGIAEo";
		buffer[3] = "CzIMLkpJUEFDREVKS0pDEiEKC0xBTUZNRUxDRU1EGAcgASgLMgwuRUZFR0tE";
		buffer[4] = "SEVNRk4SDwoHcmV0Y29kZRgKIAEoDRITCgtIR0lBR0pNSERPQhgPIAEoDUIW";
		buffer[5] = "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			EFEGKDHEMFNReflection.Descriptor,
			JIPACDEJKJCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesLargeBonusInteractScRsp), PlanetFesLargeBonusInteractScRsp.Parser, new string[4] { "DIHECIIKELE", "LAMFMELCEMD", "Retcode", "HGIAGJMHDOB" }, null, null, null, null)
		}));
	}
}
