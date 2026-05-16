using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JCFPONBDCLGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JCFPONBDCLGReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 0) = "ChFKQ0ZQT05CRENMRy5wcm90bxoRR1BGTUVETExLR0gucHJvdG8aEUtHTkxI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 1) = "UEZPSERLLnByb3RvGhFMUEhKS0dMTEpJUC5wcm90bxoRT0tJQkZLT09FS0ou";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 2) = "cHJvdG8i+gEKC0pDRlBPTkJEQ0xHEhMKC0VET0lJR0pKQ0lGGAEgAygNEhQK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 3) = "DHBsYXllcl9sZXZlbBgDIAEoDRIhCgtOSk1BUEZNUFBOQRgFIAMoCzIMLk9L";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 4) = "SUJGS09PRUtKEhIKCml0ZW1fdmFsdWUYByABKA0SCwoDZXhwGAkgASgNEhMK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 5) = "C0hBRk1BTk9MTUVEGAwgAygNEiEKC1BNQ0JCTUtNSE5JGA0gAygLMgwuR1BG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 6) = "TUVETExLR0gSIQoLSENFSE9IRENDRkUYDiADKAsyDC5MUEhKS0dMTEpJUBIh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 7) = "CgtFR0xQTkRITEhQQRgPIAMoCzIMLktHTkxIUEZPSERLQhaqAhNNYXJjaDd0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 8) = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray9<string>, string>(in buffer, 9))), new FileDescriptor[4]
		{
			GPFMEDLLKGHReflection.Descriptor,
			KGNLHPFOHDKReflection.Descriptor,
			LPHJKGLLJIPReflection.Descriptor,
			OKIBFKOOEKJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JCFPONBDCLG), JCFPONBDCLG.Parser, new string[9] { "EDOIIGJJCIF", "PlayerLevel", "NJMAPFMPPNA", "ItemValue", "Exp", "HAFMANOLMED", "PMCBBMKMHNI", "HCEHOHDCCFE", "EGLPNDHLHPA" }, null, null, null, null)
		}));
	}
}
