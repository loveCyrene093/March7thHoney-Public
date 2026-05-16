using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FeatureSwitchClosedScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FeatureSwitchClosedScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFGZWF0dXJlU3dpdGNoQ2xvc2VkU2NOb3RpZnkucHJvdG8aF0ZlYXR1cmVT" + "d2l0Y2hUeXBlLnByb3RvIkYKG0ZlYXR1cmVTd2l0Y2hDbG9zZWRTY05vdGlm" + "eRInCgtPRkRGS01MT0dLTxgEIAEoDjISLkZlYXR1cmVTd2l0Y2hUeXBlQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { FeatureSwitchTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FeatureSwitchClosedScNotify), FeatureSwitchClosedScNotify.Parser, new string[1] { "OFDFKMLOGKO" }, null, null, null, null)
		}));
	}
}
