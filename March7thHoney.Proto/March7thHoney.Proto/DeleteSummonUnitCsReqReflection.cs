using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DeleteSummonUnitCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DeleteSummonUnitCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtEZWxldGVTdW1tb25Vbml0Q3NSZXEucHJvdG8iRAoVRGVsZXRlU3VtbW9u" + "VW5pdENzUmVxEhMKC2ludGVyYWN0X2lkGAYgASgEEhYKDmVudGl0eV9pZF9s" + "aXN0GAkgAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DeleteSummonUnitCsReq), DeleteSummonUnitCsReq.Parser, new string[2] { "InteractId", "EntityIdList" }, null, null, null, null)
		}));
	}
}
