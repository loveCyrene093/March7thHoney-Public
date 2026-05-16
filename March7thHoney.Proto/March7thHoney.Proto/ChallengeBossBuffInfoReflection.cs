using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeBossBuffInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeBossBuffInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtDaGFsbGVuZ2VCb3NzQnVmZkluZm8ucHJvdG8iOwoVQ2hhbGxlbmdlQm9z" + "c0J1ZmZJbmZvEhAKCGJ1ZmZfdHdvGAMgASgNEhAKCGJ1ZmZfb25lGAggASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeBossBuffInfo), ChallengeBossBuffInfo.Parser, new string[2] { "BuffTwo", "BuffOne" }, null, null, null, null)
		}));
	}
}
