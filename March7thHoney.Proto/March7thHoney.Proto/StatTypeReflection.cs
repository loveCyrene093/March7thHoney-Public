using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StatTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StatTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg5TdGF0VHlwZS5wcm90byp+CghTdGF0VHlwZRIbChdQT0hESUJBTkdFRl9Q" + "Q1BESEVMUEtFTRAAEhsKF1BPSERJQkFOR0VGX0dOUE5NR1BDSkREEAESGwoX" + "UE9IRElCQU5HRUZfTEpNSUNFTEVIQUwQAhIbChdQT0hESUJBTkdFRl9MRExG" + "RkpQT0VQSxADQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(StatType) }, null, null));
	}
}
