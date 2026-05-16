using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DOGGIDNINJPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DOGGIDNINJPReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFET0dHSUROSU5KUC5wcm90bxoRQU1LREVLTURFTkcucHJvdG8aEUVJUFBH";
		buffer[1] = "RkNGSkVPLnByb3RvGhFJTExCTktGQk5CUC5wcm90byLeAQoLRE9HR0lETklO";
		buffer[2] = "SlASIQoLSU1QT0VISU9DQkMYAiABKAsyDC5JTExCTktGQk5CUBIhCgtORU5D";
		buffer[3] = "TEZKRENEQRgGIAMoCzIMLkFNS0RFS01ERU5HEjIKC05NSE5HSU5LT0tOGAkg";
		buffer[4] = "AygLMh0uRE9HR0lETklOSlAuTk1ITkdJTktPS05FbnRyeRIhCgtJRUtPQkRH";
		buffer[5] = "SE5QShgPIAMoCzIMLkVJUFBHRkNGSkVPGjIKEE5NSE5HSU5LT0tORW50cnkS";
		buffer[6] = "CwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AUIWqgITTWFyY2g3dGhI";
		buffer[7] = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			AMKDEKMDENGReflection.Descriptor,
			EIPPGFCFJEOReflection.Descriptor,
			ILLBNKFBNBPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DOGGIDNINJP), DOGGIDNINJP.Parser, new string[4] { "IMPOEHIOCBC", "NENCLFJDCDA", "NMHNGINKOKN", "IEKOBDGHNPJ" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
