using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IFGDFHLNPGDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IFGDFHLNPGDReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		buffer[0] = "ChFJRkdERkhMTlBHRC5wcm90bxoRQUJJTlBCS0hMUEMucHJvdG8aEUZOQktQ";
		buffer[1] = "SUhCREZHLnByb3RvGhFHRE1GRExCUEZOTi5wcm90bxoRT0RMS09GT1BCSUgu";
		buffer[2] = "cHJvdG8aEVBNQklISkxBSVBMLnByb3RvGhFQTU5JSUxOUE9CTy5wcm90byL6";
		buffer[3] = "AQoLSUZHREZITE5QR0QSIwoLTU5BSUdCQ09KREsYAiABKAsyDC5QTU5JSUxO";
		buffer[4] = "UE9CT0gAEiMKC0VERE9BSUpJT0NDGAMgASgLMgwuRk5CS1BJSEJERkdIABIj";
		buffer[5] = "CgtNQ0tMTkdQQ0pJShgJIAEoCzIMLkdETUZETEJQRk5OSAASIwoLS0tMT05K";
		buffer[6] = "UEtMRVAYDCABKAsyDC5BQklOUEJLSExQQ0gAEiMKC0xKSkFMS0lKT05DGA0g";
		buffer[7] = "ASgLMgwuT0RMS09GT1BCSUhIABIjCgtERFBKRUFJT0lMRBgOIAEoCzIMLlBN";
		buffer[8] = "QklISkxBSVBMSABCDQoLSklQQkVBQkdPQUtCFqoCE01hcmNoN3RoSG9uZXku";
		buffer[9] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[6]
		{
			ABINPBKHLPCReflection.Descriptor,
			FNBKPIHBDFGReflection.Descriptor,
			GDMFDLBPFNNReflection.Descriptor,
			ODLKOFOPBIHReflection.Descriptor,
			PMBIHJLAIPLReflection.Descriptor,
			PMNIILNPOBOReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IFGDFHLNPGD), IFGDFHLNPGD.Parser, new string[6] { "MNAIGBCOJDK", "EDDOAIJIOCC", "MCKLNGPCJIJ", "KKLONJPKLEP", "LJJALKIJONC", "DDPJEAIOILD" }, new string[1] { "JIPBEABGOAK" }, null, null, null)
		}));
	}
}
