using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AHMMECMMPBLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AHMMECMMPBLReflection()
	{
		_003C_003Ey__InlineArray21<string> buffer = default(_003C_003Ey__InlineArray21<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 0) = "ChFBSE1NRUNNTVBCTC5wcm90bxoRQU9JS0hQT0JER0sucHJvdG8aEUFQRUpN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 1) = "QkJCTEdGLnByb3RvGhFDR0lETk9DRkVPSC5wcm90bxoRRENEQ0dFSUVMSkku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 2) = "cHJvdG8aEURDTElGUE9GRkxJLnByb3RvGhFES0JDREdGSkFETS5wcm90bxoR";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 3) = "RFBMRFBQUE1NR0gucHJvdG8aEUdMUEpPRERKQ0NELnByb3RvGhFIS0xDRUVF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 4) = "SklHTy5wcm90bxoRSk1DSkJERUxPS0oucHJvdG8aEUtKSEZHUEFOTUZILnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 5) = "b3RvGhFLTkdMTUtFSkJBQi5wcm90bxoRTEtCSVBLREtETlAucHJvdG8aEU9E";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 6) = "REdHTUFBQkJELnByb3RvItoECgtBSE1NRUNNTVBCTBITCgtLSEFKREtESFBH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 7) = "RBgBIAEoBBITCgtQRkNNQkRDRkZNRxgLIAEoDRIkCgtPRUNMR0tCTUJBTRjN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 8) = "ASABKAsyDC5LTkdMTUtFSkJBQkgAEiQKC01BTElJSE1NREZQGMsCIAEoCzIM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 9) = "LkxLQklQS0RLRE5QSAASJAoLUEJQQUNMRE5KSkwYvwMgASgLMgwuREtCQ0RH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 10) = "RkpBRE1IABIkCgtGRUlJSEhCREhBQxjKAyABKAsyDC5PRERHR01BQUJCREgA";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 11) = "EiQKC0tHTkRIR0tLT01NGJgEIAEoCzIMLkFQRUpNQkJCTEdGSAASJAoLQUNI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 12) = "TkRNTUFESE0YkQYgASgLMgwuRENMSUZQT0ZGTElIABIkCgtMSk1MSUtBSUJE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 13) = "QxiUBiABKAsyDC5EQ0RDR0VJRUxKSUgAEiQKC1BKRklOR0lPRkhKGI8IIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 14) = "CzIMLkNHSUROT0NGRU9ISAASJAoLSE1OSE5BSkpDS0UYxgggASgLMgwuQU9J";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 15) = "S0hQT0JER0tIABIkCgtKTk1HTkVBS0hDRxjECSABKAsyDC5KTUNKQkRFTE9L";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 16) = "SkgAEiQKC05QTkJOTk5JTk9IGIAOIAEoCzIMLkhLTENFRUVKSUdPSAASJAoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 17) = "RE5ER0pKSUlORE4Ygg4gASgLMgwuRFBMRFBQUE1NR0hIABIkCgtLR0tPSE5B";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 18) = "QUNFThiaDiABKAsyDC5LSkhGR1BBTk1GSEgAEiQKC0xGTE5JRkZBTkRNGNEO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 19) = "IAEoCzIMLkdMUEpPRERKQ0NESABCDQoLT0dKRElPSE5GREVCFqoCE01hcmNo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 20) = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray21<string>, string>(in buffer, 21))), new FileDescriptor[14]
		{
			AOIKHPOBDGKReflection.Descriptor,
			APEJMBBBLGFReflection.Descriptor,
			CGIDNOCFEOHReflection.Descriptor,
			DCDCGEIELJIReflection.Descriptor,
			DCLIFPOFFLIReflection.Descriptor,
			DKBCDGFJADMReflection.Descriptor,
			DPLDPPPMMGHReflection.Descriptor,
			GLPJODDJCCDReflection.Descriptor,
			HKLCEEEJIGOReflection.Descriptor,
			JMCJBDELOKJReflection.Descriptor,
			KJHFGPANMFHReflection.Descriptor,
			KNGLMKEJBABReflection.Descriptor,
			LKBIPKDKDNPReflection.Descriptor,
			ODDGGMAABBDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AHMMECMMPBL), AHMMECMMPBL.Parser, new string[16]
			{
				"KHAJDKDHPGD", "PFCMBDCFFMG", "OECLGKBMBAM", "MALIIHMMDFP", "PBPACLDNJJL", "FEIIHHBDHAC", "KGNDHGKKOMM", "ACHNDMMADHM", "LJMLIKAIBDC", "PJFINGIOFHJ",
				"HMNHNAJJCKE", "JNMGNEAKHCG", "NPNBNNNINOH", "DNDGJJIINDN", "KGKOHNAACEN", "LFLNIFFANDM"
			}, new string[1] { "OGJDIOHNFDE" }, null, null, null)
		}));
	}
}
