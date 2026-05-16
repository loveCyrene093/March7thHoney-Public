using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChangeEraFlipperDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChangeEraFlipperDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9DaGFuZ2VFcmFGbGlwcGVyRGF0YUNzUmVxLnByb3RvGhhFcmFGbGlwcGVy" + "RGF0YUxpc3QucHJvdG8iPgoZQ2hhbmdlRXJhRmxpcHBlckRhdGFDc1JlcRIh" + "CgRkYXRhGAwgASgLMhMuRXJhRmxpcHBlckRhdGFMaXN0QhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { EraFlipperDataListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChangeEraFlipperDataCsReq), ChangeEraFlipperDataCsReq.Parser, new string[1] { "Data" }, null, null, null, null)
		}));
	}
}
