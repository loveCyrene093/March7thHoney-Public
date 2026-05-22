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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChFQQlBJT0ZHT0RIQy5wcm90bxoRQ05BQkdPUEtOSkQucHJvdG8aEURLSEFQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "REhCSUZDLnByb3RvGhFIQURJQkVNRkRNTC5wcm90byKgAQoLUEJQSU9GR09E";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "SEMSEwoLRElDRVBDR0ZCTk8YBCABKA0SIQoLTU1GSkdMT0ZMS0wYCSADKAsy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "DC5DTkFCR09QS05KRBITCgtIQkNKUENNSlBIRRgNIAEoDRIhCgtNT0pCSEtD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "UExETRgOIAEoDjIMLkhBRElCRU1GRE1MEiEKC01QTkNQTklMTEpIGA8gASgO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "MgwuREtIQVBESEJJRkNCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[3]
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
