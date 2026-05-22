using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EraFlipperDataChangeScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EraFlipperDataChangeScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJFcmFGbGlwcGVyRGF0YUNoYW5nZVNjTm90aWZ5LnByb3RvGhhFcmFGbGlw" + "cGVyRGF0YUxpc3QucHJvdG8iUwocRXJhRmxpcHBlckRhdGFDaGFuZ2VTY05v" + "dGlmeRIhCgRkYXRhGAIgASgLMhMuRXJhRmxpcHBlckRhdGFMaXN0EhAKCGZs" + "b29yX2lkGAMgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { EraFlipperDataListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EraFlipperDataChangeScNotify), EraFlipperDataChangeScNotify.Parser, new string[2] { "Data", "FloorId" }, null, null, null, null)
		}));
	}
}
