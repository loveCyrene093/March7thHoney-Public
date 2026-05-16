using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OMPODELCHFDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OMPODELCHFDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPTVBPREVMQ0hGRC5wcm90byI1CgtPTVBPREVMQ0hGRBITCgtBTEdESEFQ" + "TkpITxgCIAEoDRIRCglhdmF0YXJfaWQYCiABKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OMPODELCHFD), OMPODELCHFD.Parser, new string[2] { "ALGDHAPNJHO", "AvatarId" }, null, null, null, null)
		}));
	}
}
