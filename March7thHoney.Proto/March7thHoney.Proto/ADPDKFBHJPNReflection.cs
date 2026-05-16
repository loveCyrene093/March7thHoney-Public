using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ADPDKFBHJPNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ADPDKFBHJPNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBRFBES0ZCSEpQTi5wcm90bxoRTEZHTUFERkFLSEsucHJvdG8iUgoLQURQ" + "REtGQkhKUE4SEwoLREdGTk9BSExDTUsYByABKA0SHAoGc3RhdHVzGAggASgO" + "MgwuTEZHTUFERkFLSEsSEAoIcHJvZ3Jlc3MYDCABKA1CFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { LFGMADFAKHKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ADPDKFBHJPN), ADPDKFBHJPN.Parser, new string[3] { "DGFNOAHLCMK", "Status", "Progress" }, null, null, null, null)
		}));
	}
}
