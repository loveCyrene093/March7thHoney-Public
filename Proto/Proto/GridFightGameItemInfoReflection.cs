using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightGameItemInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightGameItemInfoReflection()
	{
		_003C_003Ey__InlineArray45<string> buffer = default(_003C_003Ey__InlineArray45<string>);
		buffer[0] = "ChtHcmlkRmlnaHRHYW1lSXRlbUluZm8ucHJvdG8aEUFDQkJMREpOT0ZFLnBy";
		buffer[1] = "b3RvGhFBQ0RHTUxCREpKTi5wcm90bxoRQUZPRE1IR05JS0YucHJvdG8aEUFP";
		buffer[2] = "SEFQTUpJTEJHLnByb3RvGhFCRkJOTUhFRktJRy5wcm90bxoRQklNUENNRkRP";
		buffer[3] = "TUUucHJvdG8aEUJMS0VFR0JJRElJLnByb3RvGhFDRUVMTExFSUpCTC5wcm90";
		buffer[4] = "bxoRRENBRFBKS0ZBSksucHJvdG8aEURDR0lOT09OR0xILnByb3RvGhFETENP";
		buffer[5] = "SUVJRFBLQi5wcm90bxoRRURDRkJPTUtMTFAucHJvdG8aEUVORk5MQ0NPTEVG";
		buffer[6] = "LnByb3RvGhFGRERORFBPUE9JQS5wcm90bxoRR0VCTk5MRE5LR0cucHJvdG8a";
		buffer[7] = "EUdGRkhKSUhPSkZMLnByb3RvGhFIRkJGRkVCT0FITC5wcm90bxoRSEpKSE5O";
		buffer[8] = "REFFUEYucHJvdG8aEUhNTEFQREdCS0pPLnByb3RvGhFKSEtCUElFT0xGQi5w";
		buffer[9] = "cm90bxoRS0NFQklPSFBGQlAucHJvdG8aEUtNTkFLT0JLUEZGLnByb3RvGhFL";
		buffer[10] = "UE5KTU1QSkRLRy5wcm90bxoRTEZGSE9QT1BGSkQucHJvdG8aEU1FUExGQkFL";
		buffer[11] = "RUZDLnByb3RvGhFNT09NUERNS0tBSi5wcm90bxoRTkJDS0tQRUdMTk0ucHJv";
		buffer[12] = "dG8aEU5CS0xITEpHTkdQLnByb3RvGhFPQkFFR0FHTkdLQS5wcm90bxoRT0RH";
		buffer[13] = "TkJEREZFUEQucHJvdG8aEU9LUElDSktGSUxOLnByb3RvGhFPT0pLTktET0VD";
		buffer[14] = "UC5wcm90bxoRUENFSkdCREJFREgucHJvdG8ingoKFUdyaWRGaWdodEdhbWVJ";
		buffer[15] = "dGVtSW5mbxIRCgl1bmlxdWVfaWQYAyABKA0SIwoLQU5BRUVIQ0ROT0sYTSAB";
		buffer[16] = "KAsyDC5BQ0RHTUxCREpKTkgAEiQKC09OSkZBSk9BRk9HGNcBIAEoCzIMLktQ";
		buffer[17] = "TkpNTVBKREtHSAASJAoLQkpMTUNJSkhHTEgY3QEgASgLMgwuUENFSkdCREJF";
		buffer[18] = "REhIABIkCgtMSkdFR0NKR0JOUBiRAiABKAsyDC5PT0pLTktET0VDUEgAEiQK";
		buffer[19] = "C0JDQ0xQRENMRE1OGKICIAEoCzIMLkxGRkhPUE9QRkpESAASJAoLR0lQSk9H";
		buffer[20] = "T09OTkcYwAIgASgLMgwuRkRETkRQT1BPSUFIABIkCgtFR0lFTUZCTExEQxjV";
		buffer[21] = "AyABKAsyDC5KSEtCUElFT0xGQkgAEiQKC0ZMUEtGR0lBSkpBGKUFIAEoCzIM";
		buffer[22] = "LkRMQ09JRUlEUEtCSAASJAoLQk9BSUdBSUVPTkkYqAUgASgLMgwuT0tQSUNK";
		buffer[23] = "S0ZJTE5IABIkCgtNR0VNUEtMQ0RCSRixBSABKAsyDC5BRk9ETUhHTklLRkgA";
		buffer[24] = "EiQKC0tOQUFFSUhMTVBIGO4FIAEoCzIMLk9ER05CRERGRVBESAASJAoLRUJL";
		buffer[25] = "TEdMSUVDQUwYmwYgASgLMgwuSEZCRkZFQk9BSExIABIkCgtNRU5DSkxJRUlK";
		buffer[26] = "SxjaBiABKAsyDC5PQkFFR0FHTkdLQUgAEiQKC0lGR1BHSUxNQ0FHGKMHIAEo";
		buffer[27] = "CzIMLk1FUExGQkFLRUZDSAASJAoLT09QUENERkZDS0MYnAkgASgLMgwuRURD";
		buffer[28] = "RkJPTUtMTFBIABIkCgtPSk5ORkVLTk1HQRj7CSABKAsyDC5LTU5BS09CS1BG";
		buffer[29] = "RkgAEiQKC0NNS1BHT0lJRkhFGJUKIAEoCzIMLkVORk5MQ0NPTEVGSAASJAoL";
		buffer[30] = "S0FGQk9GUEtNRk0YmgogASgLMgwuQklNUENNRkRPTUVIABIkCgtMTUdMUEdO";
		buffer[31] = "QUNMUBimCiABKAsyDC5EQ0dJTk9PTkdMSEgAEiQKC01ERkdNQkpPTkFNGJ8L";
		buffer[32] = "IAEoCzIMLkhKSkhOTkRBRVBGSAASJAoLRUhNSERLRkpPRUQYwgsgASgLMgwu";
		buffer[33] = "QUNCQkxESk5PRkVIABIkCgtDS0dLQkRQREhHTRj5DCABKAsyDC5OQkNLS1BF";
		buffer[34] = "R0xOTUgAEiQKC0FMUE1DRkZGTEJGGI0NIAEoCzIMLk1PT01QRE1LS0FKSAAS";
		buffer[35] = "JAoLR0lISENMS0hQQkwYrg0gASgLMgwuTkJLTEhMSkdOR1BIABIkCgtLTENK";
		buffer[36] = "QlBLTEpEThjwDSABKAsyDC5BT0hBUE1KSUxCR0gAEiQKC0xDRE5BUEdPSkxK";
		buffer[37] = "GKsOIAEoCzIMLkhNTEFQREdCS0pPSAASJAoLUE9CRkNPSExPR0EYvQ4gASgL";
		buffer[38] = "MgwuR0ZGSEpJSE9KRkxIABIkCgtDTUtPTURBRkZOUBi+DiABKAsyDC5LQ0VC";
		buffer[39] = "SU9IUEZCUEgAEiQKC0NKUE1HUEVJRkdHGL8OIAEoCzIMLkJGQk5NSEVGS0lH";
		buffer[40] = "SAASJAoLSUNIR01HSURISEMY0g4gASgLMgwuQ0VFTExMRUlKQkxIABIkCgtE";
		buffer[41] = "SUZLQUNPTEFGSxiHDyABKAsyDC5HRUJOTkxETktHR0gAEiQKC0JHSklGRUlO";
		buffer[42] = "SUFPGM8PIAEoCzIMLkRDQURQSktGQUpLSAASJAoLQkNNR01NSkNFSkMY2Q8g";
		buffer[43] = "ASgLMgwuQkxLRUVHQklESUlIAEINCgtISUlJTUdESkVMSkIWqgITTWFyY2g3";
		buffer[44] = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[33]
		{
			ACBBLDJNOFEReflection.Descriptor,
			ACDGMLBDJJNReflection.Descriptor,
			AFODMHGNIKFReflection.Descriptor,
			AOHAPMJILBGReflection.Descriptor,
			BFBNMHEFKIGReflection.Descriptor,
			BIMPCMFDOMEReflection.Descriptor,
			BLKEEGBIDIIReflection.Descriptor,
			CEELLLEIJBLReflection.Descriptor,
			DCADPJKFAJKReflection.Descriptor,
			DCGINOONGLHReflection.Descriptor,
			DLCOIEIDPKBReflection.Descriptor,
			EDCFBOMKLLPReflection.Descriptor,
			ENFNLCCOLEFReflection.Descriptor,
			FDDNDPOPOIAReflection.Descriptor,
			GEBNNLDNKGGReflection.Descriptor,
			GFFHJIHOJFLReflection.Descriptor,
			HFBFFEBOAHLReflection.Descriptor,
			HJJHNNDAEPFReflection.Descriptor,
			HMLAPDGBKJOReflection.Descriptor,
			JHKBPIEOLFBReflection.Descriptor,
			KCEBIOHPFBPReflection.Descriptor,
			KMNAKOBKPFFReflection.Descriptor,
			KPNJMMPJDKGReflection.Descriptor,
			LFFHOPOPFJDReflection.Descriptor,
			MEPLFBAKEFCReflection.Descriptor,
			MOOMPDMKKAJReflection.Descriptor,
			NBCKKPEGLNMReflection.Descriptor,
			NBKLHLJGNGPReflection.Descriptor,
			OBAEGAGNGKAReflection.Descriptor,
			ODGNBDDFEPDReflection.Descriptor,
			OKPICJKFILNReflection.Descriptor,
			OOJKNKDOECPReflection.Descriptor,
			PCEJGBDBEDHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightGameItemInfo), GridFightGameItemInfo.Parser, new string[34]
			{
				"UniqueId", "ANAEEHCDNOK", "ONJFAJOAFOG", "BJLMCIJHGLH", "LJGEGCJGBNP", "BCCLPDCLDMN", "GIPJOGOONNG", "EGIEMFBLLDC", "FLPKFGIAJJA", "BOAIGAIEONI",
				"MGEMPKLCDBI", "KNAAEIHLMPH", "EBKLGLIECAL", "MENCJLIEIJK", "IFGPGILMCAG", "OOPPCDFFCKC", "OJNNFEKNMGA", "CMKPGOIIFHE", "KAFBOFPKMFM", "LMGLPGNACLP",
				"MDFGMBJONAM", "EHMHDKFJOED", "CKGKBDPDHGM", "ALPMCFFFLBF", "GIHHCLKHPBL", "KLCJBPKLJDN", "LCDNAPGOJLJ", "POBFCOHLOGA", "CMKOMDAFFNP", "CJPMGPEIFGG",
				"ICHGMGIDHHC", "DIFKACOLAFK", "BGJIFEINIAO", "BCMGMMJCEJC"
			}, new string[1] { "HIIIMGDJELJ" }, null, null, null)
		}));
	}
}
