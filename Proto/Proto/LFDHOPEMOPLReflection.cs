using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LFDHOPEMOPLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LFDHOPEMOPLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMRkRIT1BFTU9QTC5wcm90byI1CgtMRkRIT1BFTU9QTBIRCgl1bmlxdWVf" + "aWQYBiABKA0SEwoLSU9HREJDUE1QTEgYCCABKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LFDHOPEMOPL), LFDHOPEMOPL.Parser, new string[2] { "UniqueId", "IOGDBCPMPLH" }, null, null, null, null)
		}));
	}
}
