using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishedMissionScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishedMissionScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1GaW5pc2hlZE1pc3Npb25TY05vdGlmeS5wcm90byI2ChdGaW5pc2hlZE1p" + "c3Npb25TY05vdGlmeRIbChNmaW5pc2hlZF9taXNzaW9uX2lkGAUgAygNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishedMissionScNotify), FinishedMissionScNotify.Parser, new string[1] { "FinishedMissionId" }, null, null, null, null)
		}));
	}
}
