using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PDAMBCFFPDIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PDAMBCFFPDIReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChFQREFNQkNGRlBESS5wcm90bxoRR0NJTU1JSEtQRUkucHJvdG8aEUhDR0VH";
		buffer[1] = "R0dMT0ZJLnByb3RvGhFIR09JTENHSEtOTS5wcm90bxoRSUNIQkdMQ0hMRFAu";
		buffer[2] = "cHJvdG8iwwEKC1BEQU1CQ0ZGUERJEiEKC0VQS0VOREVBSlBCGAMgASgLMgwu";
		buffer[3] = "SUNIQkdMQ0hMRFASEwoLSkhDTUVBTFBERUIYBCADKA0SIQoLdGFsZW50X2lu";
		buffer[4] = "Zm8YBSABKAsyDC5IQ0dFR0dHTE9GSRIhCgtCT0NJUFBCRUJFQRgGIAEoCzIM";
		buffer[5] = "LkhHT0lMQ0dIS05NEiEKC0JESkRCTUlDS0tQGA0gASgLMgwuR0NJTU1JSEtQ";
		buffer[6] = "RUkSEwoLSkxES0tFREVLSU0YDiADKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[7] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			GCIMMIHKPEIReflection.Descriptor,
			HCGEGGGLOFIReflection.Descriptor,
			HGOILCGHKNMReflection.Descriptor,
			ICHBGLCHLDPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PDAMBCFFPDI), PDAMBCFFPDI.Parser, new string[6] { "EPKENDEAJPB", "JHCMEALPDEB", "TalentInfo", "BOCIPPBEBEA", "BDJDBMICKKP", "JLDKKEDEKIM" }, null, null, null, null)
		}));
	}
}
