using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PHMBJKMKMDKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PHMBJKMKMDKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQSE1CSktNS01ESy5wcm90bxoRRElNQkFBSk5FQUYucHJvdG8iLgoLUEhN" + "QkpLTUtNREsSHwoJYnVmZl9saXN0GAkgAygLMgwuRElNQkFBSk5FQUZCFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { DIMBAAJNEAFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PHMBJKMKMDK), PHMBJKMKMDK.Parser, new string[1] { "BuffList" }, null, null, null, null)
		}));
	}
}
