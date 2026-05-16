using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AreaStepInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AreaStepInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJBcmVhU3RlcEluZm8ucHJvdG8aEUlESE5KRlBBRUdQLnByb3RvIkYKDEFy" + "ZWFTdGVwSW5mbxIhCgtHTk1PT0lPSUlBUBgJIAMoCzIMLklESE5KRlBBRUdQ" + "EhMKC09JR0hCT01GR0dEGAogASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[1] { IDHNJFPAEGPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AreaStepInfo), AreaStepInfo.Parser, new string[2] { "GNMOOIOIIAP", "OIGHBOMFGGD" }, null, null, null, null)
		}));
	}
}
