using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PBPIOFGODHCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PBPIOFGODHCReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFQQlBJT0ZHT0RIQy5wcm90bxoRQ05BQkdPUEtOSkQucHJvdG8aEURLSEFQ";
		buffer[1] = "REhCSUZDLnByb3RvGhFIQURJQkVNRkRNTC5wcm90byKgAQoLUEJQSU9GR09E";
		buffer[2] = "SEMSEwoLRElDRVBDR0ZCTk8YBCABKA0SIQoLTU1GSkdMT0ZMS0wYCSADKAsy";
		buffer[3] = "DC5DTkFCR09QS05KRBITCgtIQkNKUENNSlBIRRgNIAEoDRIhCgtNT0pCSEtD";
		buffer[4] = "UExETRgOIAEoDjIMLkhBRElCRU1GRE1MEiEKC01QTkNQTklMTEpIGA8gASgO";
		buffer[5] = "MgwuREtIQVBESEJJRkNCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[6] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			CNABGOPKNJDReflection.Descriptor,
			DKHAPDHBIFCReflection.Descriptor,
			HADIBEMFDMLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PBPIOFGODHC), PBPIOFGODHC.Parser, new string[5] { "DICEPCGFBNO", "MMFJGLOFLKL", "HBCJPCMJPHE", "MOJBHKCPLDM", "MPNCPNILLJH" }, null, null, null, null)
		}));
	}
}
