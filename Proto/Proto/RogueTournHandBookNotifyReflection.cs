using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournHandBookNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournHandBookNotifyReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		buffer[0] = "Ch5Sb2d1ZVRvdXJuSGFuZEJvb2tOb3RpZnkucHJvdG8aEUFMQUJOREJNS0JJ";
		buffer[1] = "LnByb3RvGhFDR0NQSElQT0JKRi5wcm90bxoRRUhORU5DSkFKUEMucHJvdG8a";
		buffer[2] = "EUlBSk9LUE9QR0NKLnByb3RvGhFLR09BT0RERlBCUC5wcm90bxoRTENBTERQ";
		buffer[3] = "QUlKRE8ucHJvdG8ihwIKGFJvZ3VlVG91cm5IYW5kQm9va05vdGlmeRIjCgtC";
		buffer[4] = "QkZPTEZJSU5DTRgCIAEoCzIMLkFMQUJOREJNS0JJSAASIwoLUEpIR0dIQVBL";
		buffer[5] = "Q0sYBCABKAsyDC5DR0NQSElQT0JKRkgAEiMKC0hNTFBGS0FQRkpCGAcgASgL";
		buffer[6] = "MgwuRUhORU5DSkFKUENIABIjCgtCQUFBTkJFSVBCRxgIIAEoCzIMLkxDQUxE";
		buffer[7] = "UEFJSkRPSAASIwoLQUJJSkJHRU5LSEEYCSABKAsyDC5JQUpPS1BPUEdDSkgA";
		buffer[8] = "EiMKC0dMTkpPQUhCQktLGA0gASgLMgwuS0dPQU9EREZQQlBIAEINCgtCUElI";
		buffer[9] = "RkFKQ0xPQ0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[6]
		{
			ALABNDBMKBIReflection.Descriptor,
			CGCPHIPOBJFReflection.Descriptor,
			EHNENCJAJPCReflection.Descriptor,
			IAJOKPOPGCJReflection.Descriptor,
			KGOAODDFPBPReflection.Descriptor,
			LCALDPAIJDOReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournHandBookNotify), RogueTournHandBookNotify.Parser, new string[6] { "BBFOLFIINCM", "PJHGGHAPKCK", "HMLPFKAPFJB", "BAAANBEIPBG", "ABIJBGENKHA", "GLNJOAHBBKK" }, new string[1] { "BPIHFAJCLOC" }, null, null, null)
		}));
	}
}
