using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BPNPHGLDIMIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BPNPHGLDIMIReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		buffer[0] = "ChFCUE5QSEdMRElNSS5wcm90bxoRQkNJTEtFR09CQUEucHJvdG8aEUVLSExJ";
		buffer[1] = "S1BLQU9JLnByb3RvGhFFS0hOTVBBTEJMRC5wcm90bxoRSUZHRktKTUlBSUgu";
		buffer[2] = "cHJvdG8aEUxHSkhQRU9QQkpCLnByb3RvGhFMS05BSEdNSkZCSy5wcm90bxoR";
		buffer[3] = "T0JQTkdDUEVDT04ucHJvdG8iywIKC0JQTlBIR0xESU1JEhMKC05ORkFNT0pB";
		buffer[4] = "SENIGAUgASgNEiMKC0ZGRE1ISUtKR0pPGAQgASgLMgwuSUZHRktKTUlBSUhI";
		buffer[5] = "ABIjCgtBQkVBR0hLSUdHSRgGIAEoCzIMLkVLSE5NUEFMQkxESAASIwoLRUxJ";
		buffer[6] = "QkRKT0RBSEMYByABKAsyDC5MR0pIUEVPUEJKQkgAEiMKC1BDT01BS0hET0dN";
		buffer[7] = "GAggASgLMgwuRUtITElLUEtBT0lIABIjCgtKTUdDR0ZGTktCTBgJIAEoCzIM";
		buffer[8] = "LkJDSUxLRUdPQkFBSAASIwoLSk5GQkRIRkxLRkUYCiABKAsyDC5MS05BSEdN";
		buffer[9] = "SkZCS0gAEhUKC0ROQ01LSUpFTklIGAwgASgISAASIwoLSUVQUEVFR01OTkEY";
		buffer[10] = "DiABKAsyDC5PQlBOR0NQRUNPTkgAQg0KC0hQSktMQ0FMTEJJQhaqAhNNYXJj";
		buffer[11] = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[7]
		{
			BCILKEGOBAAReflection.Descriptor,
			EKHLIKPKAOIReflection.Descriptor,
			EKHNMPALBLDReflection.Descriptor,
			IFGFKJMIAIHReflection.Descriptor,
			LGJHPEOPBJBReflection.Descriptor,
			LKNAHGMJFBKReflection.Descriptor,
			OBPNGCPECONReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BPNPHGLDIMI), BPNPHGLDIMI.Parser, new string[9] { "NNFAMOJAHCH", "FFDMHIKJGJO", "ABEAGHKIGGI", "ELIBDJODAHC", "PCOMAKHDOGM", "JMGCGFFNKBL", "JNFBDHFLKFE", "DNCMKIJENIH", "IEPPEEGMNNA" }, new string[1] { "HPJKLCALLBI" }, null, null, null)
		}));
	}
}
