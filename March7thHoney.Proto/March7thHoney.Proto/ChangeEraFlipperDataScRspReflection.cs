using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChangeEraFlipperDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChangeEraFlipperDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9DaGFuZ2VFcmFGbGlwcGVyRGF0YVNjUnNwLnByb3RvGhhFcmFGbGlwcGVy" + "RGF0YUxpc3QucHJvdG8iTwoZQ2hhbmdlRXJhRmxpcHBlckRhdGFTY1JzcBIh" + "CgRkYXRhGAUgASgLMhMuRXJhRmxpcHBlckRhdGFMaXN0Eg8KB3JldGNvZGUY" + "CSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { EraFlipperDataListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChangeEraFlipperDataScRsp), ChangeEraFlipperDataScRsp.Parser, new string[2] { "Data", "Retcode" }, null, null, null, null)
		}));
	}
}
