using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NOAMCBLCAMHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NOAMCBLCAMHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOT0FNQ0JMQ0FNSC5wcm90bxoRR0NBQ0hKRkxHSEgucHJvdG8aEU9IQU9G" + "TEFMSEJMLnByb3RvIlIKC05PQU1DQkxDQU1IEiEKC0NDQUhHTERNSEdJGAIg" + "ASgLMgwuT0hBT0ZMQUxIQkwSIAoKcXVlc3RfbGlzdBgMIAMoCzIMLkdDQUNI" + "SkZMR0hIQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[2]
		{
			GCACHJFLGHHReflection.Descriptor,
			OHAOFLALHBLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NOAMCBLCAMH), NOAMCBLCAMH.Parser, new string[2] { "CCAHGLDMHGI", "QuestList" }, null, null, null, null)
		}));
	}
}
