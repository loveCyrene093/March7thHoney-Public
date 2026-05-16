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
		buffer[0] = "ChFKQ0ZQT05CRENMRy5wcm90bxoRR1BGTUVETExLR0gucHJvdG8aEUtHTkxI";
		buffer[1] = "UEZPSERLLnByb3RvGhFMUEhKS0dMTEpJUC5wcm90bxoRT0tJQkZLT09FS0ou";
		buffer[2] = "cHJvdG8i+gEKC0pDRlBPTkJEQ0xHEhMKC0VET0lJR0pKQ0lGGAEgAygNEhQK";
		buffer[3] = "DHBsYXllcl9sZXZlbBgDIAEoDRIhCgtOSk1BUEZNUFBOQRgFIAMoCzIMLk9L";
		buffer[4] = "SUJGS09PRUtKEhIKCml0ZW1fdmFsdWUYByABKA0SCwoDZXhwGAkgASgNEhMK";
		buffer[5] = "C0hBRk1BTk9MTUVEGAwgAygNEiEKC1BNQ0JCTUtNSE5JGA0gAygLMgwuR1BG";
		buffer[6] = "TUVETExLR0gSIQoLSENFSE9IRENDRkUYDiADKAsyDC5MUEhKS0dMTEpJUBIh";
		buffer[7] = "CgtFR0xQTkRITEhQQRgPIAMoCzIMLktHTkxIUEZPSERLQhaqAhNNYXJjaDd0";
		buffer[8] = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
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
