using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DNJHMKINPBKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DNJHMKINPBKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFETkpITUtJTlBCSy5wcm90bxoRTEdPUExJQUZMQ0sucHJvdG8iKQoLRE5K" + "SE1LSU5QQksSGgoEZGF0YRgIIAEoCzIMLkxHT1BMSUFGTENLQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { LGOPLIAFLCKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DNJHMKINPBK), DNJHMKINPBK.Parser, new string[1] { "Data" }, null, null, null, null)
		}));
	}
}
