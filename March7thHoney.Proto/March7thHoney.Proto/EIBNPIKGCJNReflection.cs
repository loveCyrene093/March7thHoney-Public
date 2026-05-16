using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EIBNPIKGCJNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EIBNPIKGCJNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFSUJOUElLR0NKTi5wcm90bxoQTW90aW9uSW5mby5wcm90byI2CgtFSUJO" + "UElLR0NKThIbCgZtb3Rpb24YAyABKAsyCy5Nb3Rpb25JbmZvEgoKAmlkGAYg" + "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { MotionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EIBNPIKGCJN), EIBNPIKGCJN.Parser, new string[2] { "Motion", "Id" }, null, null, null, null)
		}));
	}
}
