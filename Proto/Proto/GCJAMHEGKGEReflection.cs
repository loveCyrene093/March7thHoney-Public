using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GCJAMHEGKGEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GCJAMHEGKGEReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFHQ0pBTUhFR0tHRS5wcm90bxoWRGljZUNvbWJhdEF2YXRhci5wcm90bxoR";
		buffer[1] = "S0tKSE9PQkpDR0cucHJvdG8aEU5JR0JCSkdPSk1MLnByb3RvIs8BCgtHQ0pB";
		buffer[2] = "TUhFR0tHRRImCgthdmF0YXJfbGlzdBgBIAMoCzIRLkRpY2VDb21iYXRBdmF0";
		buffer[3] = "YXISIQoLR0VQSEZPS0JJRU8YAiABKAsyDC5LS0pIT09CSkNHRxIhCgtNR0dD";
		buffer[4] = "Tk1MRkNCSRgDIAEoCzIMLk5JR0JCSkdPSk1MEhMKC0ZPT0xNSUFETU1IGAQg";
		buffer[5] = "ASgNEhMKC0VCQ0FGTUdNRkVPGAUgASgNEhMKC1BJRUJMSkpHQ01LGAYgASgN";
		buffer[6] = "EhMKC01IS0FLQktNTkZKGAcgASgIQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[7] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			DiceCombatAvatarReflection.Descriptor,
			KKJHOOBJCGGReflection.Descriptor,
			NIGBBJGOJMLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GCJAMHEGKGE), GCJAMHEGKGE.Parser, new string[7] { "AvatarList", "GEPHFOKBIEO", "MGGCNMLFCBI", "FOOLMIADMMH", "EBCAFMGMFEO", "PIEBLJJGCMK", "MHKAKBKMNFJ" }, null, null, null, null)
		}));
	}
}
