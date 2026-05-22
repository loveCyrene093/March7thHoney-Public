using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TutorialFinishTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TutorialFinishTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhUdXRvcmlhbEZpbmlzaFR5cGUucHJvdG8qawoSVHV0b3JpYWxGaW5pc2hU" + "eXBlEhsKF0dDUEpMRU5ERklDX1BDUERIRUxQS0VNEAASGwoXR0NQSkxFTkRG" + "SUNfR0tPQkJBRUpOTkMQARIbChdHQ1BKTEVOREZJQ19JRkdESEtOR0NESRAC" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(TutorialFinishType) }, null, null));
	}
}
