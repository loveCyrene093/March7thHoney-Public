using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EDGGKGPFLNPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EDGGKGPFLNPReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFFREdHS0dQRkxOUC5wcm90bxoRTkxKTEhQRU9JT0MucHJvdG8aEU9NTkpO";
		buffer[1] = "S05NTEtMLnByb3RvIqcBCgtFREdHS0dQRkxOUBITCgtLT1BIT0hKRkNDSxgC";
		buffer[2] = "IAEoDRIhCgtKTENFRUVCTkVPTBgEIAMoCzIMLk5MSkxIUEVPSU9DEiEKC05D";
		buffer[3] = "SkhGRkRESExJGAcgASgLMgwuT01OSk5LTk1MS0wSEwoLTUpHTURNRkhLQkkY";
		buffer[4] = "CCABKA0SEwoLTkZKS0tLSklJUEYYDCABKA0SEwoLSEdJSk5HUE1DREgYDSAB";
		buffer[5] = "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			NLJLHPEOIOCReflection.Descriptor,
			OMNJNKNMLKLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EDGGKGPFLNP), EDGGKGPFLNP.Parser, new string[6] { "KOPHOHJFCCK", "JLCEEEBNEOL", "NCJHFFDDHLI", "MJGMDMFHKBI", "NFJKKKJIIPF", "HGIJNGPMCDH" }, null, null, null, null)
		}));
	}
}
