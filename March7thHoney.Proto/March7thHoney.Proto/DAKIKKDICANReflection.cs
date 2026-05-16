using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DAKIKKDICANReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DAKIKKDICANReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFEQUtJS0tESUNBTi5wcm90byI2CgtEQUtJS0tESUNBThITCgtBR0dMQkRF" + "SEhHTxgMIAEoDRISCgptb25zdGVyX2lkGA4gASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DAKIKKDICAN), DAKIKKDICAN.Parser, new string[2] { "AGGLBDEHHGO", "MonsterId" }, null, null, null, null)
		}));
	}
}
