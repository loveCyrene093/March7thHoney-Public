using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CADKBOKEJMDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CADKBOKEJMDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDQURLQk9LRUpNRC5wcm90bxoRSEpHRkRJS0RJSE8ucHJvdG8iLgoLQ0FE" + "S0JPS0VKTUQSHwoJYnVmZl9saXN0GAUgAygLMgwuSEpHRkRJS0RJSE9CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { HJGFDIKDIHOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CADKBOKEJMD), CADKBOKEJMD.Parser, new string[1] { "BuffList" }, null, null, null, null)
		}));
	}
}
