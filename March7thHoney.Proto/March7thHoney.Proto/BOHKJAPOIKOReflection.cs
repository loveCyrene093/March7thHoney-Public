using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BOHKJAPOIKOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BOHKJAPOIKOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCT0hLSkFQT0lLTy5wcm90bxoRR0NESUxOTkVLTksucHJvdG8iLgoLQk9I" + "S0pBUE9JS08SHwoJYXJlYV9saXN0GAcgAygLMgwuR0NESUxOTkVLTktCFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { GCDILNNEKNKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BOHKJAPOIKO), BOHKJAPOIKO.Parser, new string[1] { "AreaList" }, null, null, null, null)
		}));
	}
}
