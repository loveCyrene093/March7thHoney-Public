using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class INDJDBNFNIMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static INDJDBNFNIMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJTkRKREJORk5JTS5wcm90bxoRTEdPUExJQUZMQ0sucHJvdG8iUwoLSU5E" + "SkRCTkZOSU0SIQoLTExJQUpITUVKS0kYDiABKAsyDC5MR09QTElBRkxDSxIh" + "CgtCREJJTElCQkhNUBgPIAEoCzIMLkxHT1BMSUFGTENLQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { LGOPLIAFLCKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(INDJDBNFNIM), INDJDBNFNIM.Parser, new string[2] { "LLIAJHMEJKI", "BDBILIBBHMP" }, null, null, null, null)
		}));
	}
}
