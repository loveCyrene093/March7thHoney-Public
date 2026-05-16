using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PFBKJICJGBIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PFBKJICJGBIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQRkJLSklDSkdCSS5wcm90bxoRRkNNQ0pBS0dQQ0cucHJvdG8iZgoLUEZC" + "S0pJQ0pHQkkSEQoJYXZhdGFyX2lkGAEgASgNEiEKC0dITUpDREFETklBGAIg" + "AygLMgwuRkNNQ0pBS0dQQ0cSDAoEc2xvdBgDIAEoDRITCgtNQU9OTEhCS09G" + "SxgEIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { FCMCJAKGPCGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PFBKJICJGBI), PFBKJICJGBI.Parser, new string[4] { "AvatarId", "GHMJCDADNIA", "Slot", "MAONLHBKOFK" }, null, null, null, null)
		}));
	}
}
