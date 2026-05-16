using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KNFLEFIFKMNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KNFLEFIFKMNReflection()
	{
		_003C_003Ey__InlineArray30<string> buffer = default(_003C_003Ey__InlineArray30<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 0) = "ChFLTkZMRUZJRktNTi5wcm90bxoRQURMRERNQUlGQUkucHJvdG8aEUFMRU9Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 1) = "Q05ITlBELnByb3RvGhFBT0FHSkJPS0tGTS5wcm90bxoRQktGQUtQSE5FUFAu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 2) = "cHJvdG8aEUJOUEpDTkRJUE9NLnByb3RvGhFCT0NOREVKRkNHQy5wcm90bxoR";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 3) = "REdCUFBISkFPQUYucHJvdG8aEURORkNBTUlJQUtKLnByb3RvGhFETkZORUlO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 4) = "RU9FTi5wcm90bxoRRUNNRkRDSUlJSEoucHJvdG8aEUVNTUlCTE9IT0tBLnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 5) = "b3RvGhFHQ09CQ0dERE5JSS5wcm90bxoRSElLQ0RLTVBESEwucHJvdG8aEUlJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 6) = "SkRQRk9HQ0lOLnByb3RvGhFLSEFIS0RMSVBLRi5wcm90bxoRS0lKS1BDRUhF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 7) = "S0MucHJvdG8aEUtOT0NLQUVDS0lJLnByb3RvGhFMQk1ER05KUFBLTy5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 8) = "bxoRTUJJTkVJSE5PR0MucHJvdG8aEU1MTElETVBFRk9ELnByb3RvGhFPQlBP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 9) = "QkVFT0RBRi5wcm90bxoRT0RFR0ZPUE9LQUQucHJvdG8i0QYKC0tORkxFRklG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 10) = "S01OEiMKC0xERUVOS0RNREpLGAEgASgLMgwuRUNNRkRDSUlJSEpIABIjCgtE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 11) = "Rk9LUEtPS0ZPSxgCIAEoCzIMLklJSkRQRk9HQ0lOSAASIwoLSkRGR0ZQR0FH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 12) = "UEcYAyABKAsyDC5BTEVPUENOSE5QREgAEiMKC05FSEpQSEdBTEVLGAQgASgL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 13) = "MgwuS0hBSEtETElQS0ZIABIjCgtCTU9MSUVKRk1HQhgFIAEoCzIMLkJOUEpD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 14) = "TkRJUE9NSAASIwoLRk9HTEFMS0hBR0IYBiABKAsyDC5CS0ZBS1BITkVQUEgA";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 15) = "EiMKC05HTEZGS0FKQUFEGAcgASgLMgwuS0lKS1BDRUhFS0NIABIjCgtFSENO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 16) = "REZFUExPTRgIIAEoCzIMLk9ERUdGT1BPS0FESAASIwoLSE5EQ0NGTU1OT0gY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 17) = "CSABKAsyDC5NQklORUlITk9HQ0gAEiMKC0tPREpQS1BJSEJIGAogASgLMgwu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 18) = "T0JQT0JFRU9EQUZIABIjCgtDRk1EQUZLR0RIThgLIAEoCzIMLkFPQUdKQk9L";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 19) = "S0ZNSAASIwoLRkhHSE9FRkNBR0cYDCABKAsyDC5ETkZORUlORU9FTkgAEiMK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 20) = "C0dGTUNJT0RGT0RCGA0gASgLMgwuQURMRERNQUlGQUlIABIjCgtKTUdFUERF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 21) = "S0dJSBgOIAEoCzIMLkxCTURHTkpQUEtPSAASIwoLRE5JQkdER0ZNR0oYDyAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 22) = "KAsyDC5ER0JQUEhKQU9BRkgAEiQKC05IQk1GRkFHTExLGIMCIAEoCzIMLkJP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 23) = "Q05ERUpGQ0dDSAASJAoLTkNDTU5QR0ZBR0sY9wQgASgLMgwuRU1NSUJMT0hP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 24) = "S0FIABIkCgtQRk9JTE1IS0pKTRjSByABKAsyDC5ETkZDQU1JSUFLSkgAEiQK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 25) = "C0ZMSUFMS0VJREtEGLkJIAEoCzIMLkhJS0NES01QREhMSAASJAoLQ0JJRkFL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 26) = "UERORUkY3wogASgLMgwuR0NPQkNHREROSUlIABIkCgtQQUtGSEJMQkNPTRi8";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 27) = "DCABKAsyDC5LTk9DS0FFQ0tJSUgAEiQKC0pITEJEQU1FTkFHGMUNIAEoCzIM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 28) = "Lk1MTElETVBFRk9ESABCDQoLTkxQUFBDSEdHUEZCFqoCE01hcmNoN3RoSG9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray30<string>, string>(ref buffer, 29) = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray30<string>, string>(in buffer, 30))), new FileDescriptor[22]
		{
			ADLDDMAIFAIReflection.Descriptor,
			ALEOPCNHNPDReflection.Descriptor,
			AOAGJBOKKFMReflection.Descriptor,
			BKFAKPHNEPPReflection.Descriptor,
			BNPJCNDIPOMReflection.Descriptor,
			BOCNDEJFCGCReflection.Descriptor,
			DGBPPHJAOAFReflection.Descriptor,
			DNFCAMIIAKJReflection.Descriptor,
			DNFNEINEOENReflection.Descriptor,
			ECMFDCIIIHJReflection.Descriptor,
			EMMIBLOHOKAReflection.Descriptor,
			GCOBCGDDNIIReflection.Descriptor,
			HIKCDKMPDHLReflection.Descriptor,
			IIJDPFOGCINReflection.Descriptor,
			KHAHKDLIPKFReflection.Descriptor,
			KIJKPCEHEKCReflection.Descriptor,
			KNOCKAECKIIReflection.Descriptor,
			LBMDGNJPPKOReflection.Descriptor,
			MBINEIHNOGCReflection.Descriptor,
			MLLIDMPEFODReflection.Descriptor,
			OBPOBEEODAFReflection.Descriptor,
			ODEGFOPOKADReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KNFLEFIFKMN), KNFLEFIFKMN.Parser, new string[22]
			{
				"LDEENKDMDJK", "DFOKPKOKFOK", "JDFGFPGAGPG", "NEHJPHGALEK", "BMOLIEJFMGB", "FOGLALKHAGB", "NGLFFKAJAAD", "EHCNDFEPLOM", "HNDCCFMMNOH", "KODJPKPIHBH",
				"CFMDAFKGDHN", "FHGHOEFCAGG", "GFMCIODFODB", "JMGEPDEKGIH", "DNIBGDGFMGJ", "NHBMFFAGLLK", "NCCMNPGFAGK", "PFOILMHKJJM", "FLIALKEIDKD", "CBIFAKPDNEI",
				"PAKFHBLBCOM", "JHLBDAMENAG"
			}, new string[1] { "NLPPPCHGGPF" }, null, null, null)
		}));
	}
}
