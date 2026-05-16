using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetSignatureCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetSignatureCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdTZXRTaWduYXR1cmVDc1JlcS5wcm90byImChFTZXRTaWduYXR1cmVDc1Jl" + "cRIRCglzaWduYXR1cmUYDSABKAlCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetSignatureCsReq), SetSignatureCsReq.Parser, new string[1] { "Signature" }, null, null, null, null)
		}));
	}
}
