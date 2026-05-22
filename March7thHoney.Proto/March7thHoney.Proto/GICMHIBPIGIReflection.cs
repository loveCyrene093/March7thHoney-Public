using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GICMHIBPIGIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GICMHIBPIGIReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 0) = "ChFHSUNNSElCUElHSS5wcm90bxoRSkVFSEJKUElBS0UucHJvdG8aEUpGUEJF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 1) = "REZLSU5KLnByb3RvGhFKSUtEQ0NQREpQRy5wcm90bxoRTUxLQktOTktGRUEu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 2) = "cHJvdG8aEU9QR0pQTEtITEtKLnByb3RvIu8BCgtHSUNNSElCUElHSRITCgtQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 3) = "RkNNQkRDRkZNRxgMIAEoDRIkCgtMTENIRUFNR0ZCThiTASABKAsyDC5KRlBC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 4) = "RURGS0lOSkgAEiQKC0xDSEFPSEVKQk9DGLoEIAEoCzIMLkpFRUhCSlBJQUtF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 5) = "SAASJAoLS0hIS0pLQURBQ0IY3QkgASgLMgwuT1BHSlBMS0hMS0pIABIkCgtm";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 6) = "aW5pc2hfaW5mbxiBDCABKAsyDC5KSUtEQ0NQREpQR0gAEiQKC0tHS09ITkFB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 7) = "Q0VOGPYMIAEoCzIMLk1MS0JLTk5LRkVBSABCDQoLT0dKRElPSE5GREVCFqoC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 8) = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray9<string>, string>(in buffer, 9))), new FileDescriptor[5]
		{
			JEEHBJPIAKEReflection.Descriptor,
			JFPBEDFKINJReflection.Descriptor,
			JIKDCCPDJPGReflection.Descriptor,
			MLKBKNNKFEAReflection.Descriptor,
			OPGJPLKHLKJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GICMHIBPIGI), GICMHIBPIGI.Parser, new string[6] { "PFCMBDCFFMG", "LLCHEAMGFBN", "LCHAOHEJBOC", "KHHKJKADACB", "FinishInfo", "KGKOHNAACEN" }, new string[1] { "OGJDIOHNFDE" }, null, null, null)
		}));
	}
}
