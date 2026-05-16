using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ICOMMCAJDLIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ICOMMCAJDLIReflection()
	{
		_003C_003Ey__InlineArray41<string> buffer = default(_003C_003Ey__InlineArray41<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 0) = "ChFJQ09NTUNBSkRMSS5wcm90bxoRQUZDQlBLT0FDSkQucHJvdG8aEUJJQkhQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 1) = "RU9BQU5ELnByb3RvGhFDQkpBRUpBRkNLRy5wcm90bxoRQ0NKQUlNS05JTkwu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 2) = "cHJvdG8aEUNMSUJNRENPRkVGLnByb3RvGhFEREVKSEJKQk1CSC5wcm90bxoR";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 3) = "RExLSUxHTUhQRk0ucHJvdG8aEUVCQ0ZCS0hDSEpFLnByb3RvGhFGQ0ZGSkFQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 4) = "SUlGTC5wcm90bxoRR0ZQUEtHR0NPSUoucHJvdG8aEUhDSkROS0JHREZBLnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 5) = "b3RvGhFISktHQk9LS05PUC5wcm90bxoRSExPS0FPTExITVAucHJvdG8aEUhO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 6) = "Q0tHRkdISkFDLnByb3RvGhFJREhDS0NEQUVCQS5wcm90bxoRSkZQS0NHRkxK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 7) = "SUcucHJvdG8aEUtER0NHREdETEFLLnByb3RvGhFLRkNPTkpLSENCTi5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 8) = "bxoRTEJMTU5CT0FGQ0oucHJvdG8aEUxFRERGT0dMTUpELnByb3RvGhFMR0pE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 9) = "T0tGSENISS5wcm90bxoRTEhMS0tNRkNGSEYucHJvdG8aEUxMRkFGQkpCQ09M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 10) = "LnByb3RvGhFNQUtNREFJSERNTi5wcm90bxoRTUROSUVKRU5OSUkucHJvdG8a";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 11) = "EU5MSElKUEVBTVBKLnByb3RvGhFPRUJFS0lFQUxGSC5wcm90byLaCQoLSUNP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 12) = "TU1DQUpETEkSIwoLSE1FRklNS0ZKSkIYXSABKAsyDC5MR0pET0tGSENISUgA";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 13) = "EiMKC0VGQ0VJQ1BMT1BCGHIgASgLMgwuRERFSkhCSkJNQkhIABIkCgtOSUpH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 14) = "Q0ZQSE9PQRijASABKAsyDC5BRkNCUEtPQUNKREgAEiQKC0VBRk1FREFQQkNE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 15) = "GKkBIAEoCzIMLkxCTE1OQk9BRkNKSAASJAoLS0FDTE5DSEZKQk4YzgEgASgL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 16) = "MgwuTEVEREZPR0xNSkRIABIkCgtPSUNHREpJRkRISBiBAiABKAsyDC5HRlBQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 17) = "S0dHQ09JSkgAEiQKC0VET0ZOQ0tESURGGIgCIAEoCzIMLk1BS01EQUlIRE1O";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 18) = "SAASJAoLS05OTEhFTUZLQk4YxgIgASgLMgwuTExGQUZCSkJDT0xIABIkCgtI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 19) = "T05LSU9KR01ETRjlAyABKAsyDC5DTElCTURDT0ZFRkgAEiQKC05HRElGT0xC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 20) = "TEJCGMUEIAEoCzIMLkxITEtLTUZDRkhGSAASJAoLRUdMT01OT0NPQUoYzgQg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 21) = "ASgLMgwuSkZQS0NHRkxKSUdIABIkCgtIRU9KTUlNR0hGThiJBSABKAsyDC5L";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 22) = "REdDR0RHRExBS0gAEiQKC01LTUtJR0tNUEZQGN4FIAEoCzIMLk9FQkVLSUVB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 23) = "TEZISAASJAoLUExPSEpKSkZOTkoY/QUgASgLMgwuQklCSFBFT0FBTkRIABIk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 24) = "CgtBR05IRk1HSUlBTxiJBiABKAsyDC5ISktHQk9LS05PUEgAEiQKC1BGQkJI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 25) = "QU1PQUdCGLIGIAEoCzIMLkhOQ0tHRkdISkFDSAASJAoLRUJBTEROQk9IREMY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 26) = "3gYgASgLMgwuRUJDRkJLSENISkVIABIkCgtNTEhBT0dNTlBDShidCCABKAsy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 27) = "DC5HRlBQS0dHQ09JSkgAEiQKC0pMTEJIRVBMS0tQGKgIIAEoCzIMLktGQ09O";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 28) = "SktIQ0JOSAASJAoLQUJGSURJSEpMSEUYygggASgLMgwuQ0NKQUlNS05JTkxI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 29) = "ABIkCgtGSURMSUtOSUpBSxjjCSABKAsyDC5GQ0ZGSkFQSUlGTEgAEiQKC0tJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 30) = "T0JPQ01PT05IGP0JIAEoCzIMLk1ETklFSkVOTklJSAASJAoLQ0xPTEhJSUpN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 31) = "UEgYkQogASgLMgwuR0ZQUEtHR0NPSUpIABIkCgtLTUtHSEpKSUpDThiACyAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 32) = "KAsyDC5DQkpBRUpBRkNLR0gAEiQKC0JDRkVKQUZNTlBGGNMMIAEoCzIMLkdG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 33) = "UFBLR0dDT0lKSAASJAoLUEZNQklHT0xIQkwYkw0gASgLMgwuTkxISUpQRUFN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 34) = "UEpIABIkCgtPSUVJQkJJSUFNSRjwDSABKAsyDC5IQ0pETktCR0RGQUgAEiQK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 35) = "C0FMTFBKS0hETElCGPENIAEoCzIMLkhMT0tBT0xMSE1QSAASJAoLT0RJT01E";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 36) = "SURKSUsYmg4gASgLMgwuRExLSUxHTUhQRk1IABIkCgtGT0FCREREREZCUBjG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 37) = "DiABKAsyDC5PRUJFS0lFQUxGSEgAEiQKC05BTE5OQkVDQlBBGPkPIAEoCzIM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 38) = "LklESENLQ0RBRUJBSAASJAoLQ0RKTERORURBREcY/Q8gASgLMgwuT0VCRUtJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 39) = "RUFMRkhIAEINCgtCUElIRkFKQ0xPQ0IWqgITTWFyY2g3dGhIb25leS5Qcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray41<string>, string>(ref buffer, 40) = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray41<string>, string>(in buffer, 41))), new FileDescriptor[27]
		{
			AFCBPKOACJDReflection.Descriptor,
			BIBHPEOAANDReflection.Descriptor,
			CBJAEJAFCKGReflection.Descriptor,
			CCJAIMKNINLReflection.Descriptor,
			CLIBMDCOFEFReflection.Descriptor,
			DDEJHBJBMBHReflection.Descriptor,
			DLKILGMHPFMReflection.Descriptor,
			EBCFBKHCHJEReflection.Descriptor,
			FCFFJAPIIFLReflection.Descriptor,
			GFPPKGGCOIJReflection.Descriptor,
			HCJDNKBGDFAReflection.Descriptor,
			HJKGBOKKNOPReflection.Descriptor,
			HLOKAOLLHMPReflection.Descriptor,
			HNCKGFGHJACReflection.Descriptor,
			IDHCKCDAEBAReflection.Descriptor,
			JFPKCGFLJIGReflection.Descriptor,
			KDGCGDGDLAKReflection.Descriptor,
			KFCONJKHCBNReflection.Descriptor,
			LBLMNBOAFCJReflection.Descriptor,
			LEDDFOGLMJDReflection.Descriptor,
			LGJDOKFHCHIReflection.Descriptor,
			LHLKKMFCFHFReflection.Descriptor,
			LLFAFBJBCOLReflection.Descriptor,
			MAKMDAIHDMNReflection.Descriptor,
			MDNIEJENNIIReflection.Descriptor,
			NLHIJPEAMPJReflection.Descriptor,
			OEBEKIEALFHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ICOMMCAJDLI), ICOMMCAJDLI.Parser, new string[32]
			{
				"HMEFIMKFJJB", "EFCEICPLOPB", "NIJGCFPHOOA", "EAFMEDAPBCD", "KACLNCHFJBN", "OICGDJIFDHH", "EDOFNCKDIDF", "KNNLHEMFKBN", "HONKIOJGMDM", "NGDIFOLBLBB",
				"EGLOMNOCOAJ", "HEOJMIMGHFN", "MKMKIGKMPFP", "PLOHJJJFNNJ", "AGNHFMGIIAO", "PFBBHAMOAGB", "EBALDNBOHDC", "MLHAOGMNPCJ", "JLLBHEPLKKP", "ABFIDIHJLHE",
				"FIDLIKNIJAK", "KIOBOCMOONH", "CLOLHIIJMPH", "KMKGHJJIJCN", "BCFEJAFMNPF", "PFMBIGOLHBL", "OIEIBBIIAMI", "ALLPJKHDLIB", "ODIOMDIDJIK", "FOABDDDDFBP",
				"NALNNBECBPA", "CDJLDNEDADG"
			}, new string[1] { "BPIHFAJCLOC" }, null, null, null)
		}));
	}
}
