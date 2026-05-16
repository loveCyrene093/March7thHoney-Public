using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateBuffDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateBuffDataReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJGYXRlQnVmZkRhdGEucHJvdG8iLAoMRmF0ZUJ1ZmZEYXRhEg8KB2J1ZmZf" + "aWQYBiABKA0SCwoDY250GAggASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateBuffData), FateBuffData.Parser, new string[2] { "BuffId", "Cnt" }, null, null, null, null)
		}));
	}
}
