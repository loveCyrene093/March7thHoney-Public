using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DCIEAIDBBCIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DCIEAIDBBCIReflection()
	{
		InlineArray16<string> buffer = default(InlineArray16<string>);
		buffer[0] = "ChFEQ0lFQUlEQkJDSS5wcm90bxoRQUlMR0dJRERMQ08ucHJvdG8aEUFQQUVQ";
		buffer[1] = "TkNKRElFLnByb3RvGhFBUFBFRkJMTFBHSy5wcm90bxoRQ01QSURHQ0pITEku";
		buffer[2] = "cHJvdG8aEUZPSVBPQ05FUExOLnByb3RvGhFHRkxHTUNESEFGTS5wcm90bxoR";
		buffer[3] = "SUhGREJDSkRIRUoucHJvdG8aEUtCTklKRkVNQlBKLnByb3RvGhFNS1BDTkdO";
		buffer[4] = "SUZESy5wcm90bxoRTUxHQUxMRUFFSUMucHJvdG8aEU5BQ0NEREZDSUtBLnBy";
		buffer[5] = "b3RvIrADCgtEQ0lFQUlEQkJDSRIZCgNzcmMYAyABKA4yDC5BUEFFUE5DSkRJ";
		buffer[6] = "RRIjCgtQUEdJTURMSEtHQRgRIAEoCzIMLkNNUElER0NKSExJSAASIwoLSkZH";
		buffer[7] = "SkFGSVBDREkYXSABKAsyDC5NTEdBTExFQUVJQ0gAEiMKC09NTENQTk1NQ0lN";
		buffer[8] = "GHAgASgLMgwuTUtQQ05HTklGREtIABIkCgtEUEhDSktFRkJMThjRBCABKAsy";
		buffer[9] = "DC5GT0lQT0NORVBMTkgAEiQKC09ER05BSktCR0ROGNIEIAEoCzIMLkFQUEVG";
		buffer[10] = "QkxMUEdLSAASJAoLT01QR0ZBREJHS0gYoAUgASgLMgwuR0ZMR01DREhBRk1I";
		buffer[11] = "ABIkCgtGQVBCUEdNUE5JThjCByABKAsyDC5OQUNDRERGQ0lLQUgAEiQKC0xK";
		buffer[12] = "T0hET0RFRUlMGO4KIAEoCzIMLkFJTEdHSURETENPSAASJAoLT0FHTUFFTE1E";
		buffer[13] = "QUUYkQsgASgLMgwuS0JOSUpGRU1CUEpIABIkCgtHRk5QQUZITU9CTRi+DSAB";
		buffer[14] = "KAsyDC5JSEZEQkNKREhFSkgAQg0KC0tDT0NDR0VPRUNPQhaqAhNNYXJjaDd0";
		buffer[15] = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[11]
		{
			AILGGIDDLCOReflection.Descriptor,
			APAEPNCJDIEReflection.Descriptor,
			APPEFBLLPGKReflection.Descriptor,
			CMPIDGCJHLIReflection.Descriptor,
			FOIPOCNEPLNReflection.Descriptor,
			GFLGMCDHAFMReflection.Descriptor,
			IHFDBCJDHEJReflection.Descriptor,
			KBNIJFEMBPJReflection.Descriptor,
			MKPCNGNIFDKReflection.Descriptor,
			MLGALLEAEICReflection.Descriptor,
			NACCDDFCIKAReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DCIEAIDBBCI), DCIEAIDBBCI.Parser, new string[11]
			{
				"Src", "PPGIMDLHKGA", "JFGJAFIPCDI", "OMLCPNMMCIM", "DPHCJKEFBLN", "ODGNAJKBGDN", "OMPGFADBGKH", "FAPBPGMPNIN", "LJOHDODEEIL", "OAGMAELMDAE",
				"GFNPAFHMOBM"
			}, new string[1] { "KCOCCGEOECO" }, null, null, null)
		}));
	}
}
