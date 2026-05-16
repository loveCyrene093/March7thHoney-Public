using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OFAFDPGCEPOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OFAFDPGCEPOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPRkFGRFBHQ0VQTy5wcm90byIgCgtPRkFGRFBHQ0VQTxIRCgl1bmlxdWVf" + "aWQYBiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OFAFDPGCEPO), OFAFDPGCEPO.Parser, new string[1] { "UniqueId" }, null, null, null, null)
		}));
	}
}
