using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DAHJGDGPMHIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DAHJGDGPMHIReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFEQUhKR0RHUE1ISS5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvItIBCgtE";
		buffer[1] = "QUhKR0RHUE1ISRIiCgtJQUdNTkhQUExHQhgIIAEoCzINLkl0ZW1Db3N0RGF0";
		buffer[2] = "YRITCgtQSUdESUZBS0lHTRgLIAEoBRIyCgtLQUxISlBESEJKQxgMIAMoCzId";
		buffer[3] = "LkRBSEpHREdQTUhJLktBTEhKUERIQkpDRW50cnkSEwoLSktJTUxJUE1LRkgY";
		buffer[4] = "DiABKA0aQQoQS0FMSEpQREhCSkNFbnRyeRILCgNrZXkYASABKA0SHAoFdmFs";
		buffer[5] = "dWUYAiABKAsyDS5JdGVtQ29zdERhdGE6AjgBQhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[6] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DAHJGDGPMHI), DAHJGDGPMHI.Parser, new string[4] { "IAGMNHPPLGB", "PIGDIFAKIGM", "KALHJPDHBJC", "JKIMLIPMKFH" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
