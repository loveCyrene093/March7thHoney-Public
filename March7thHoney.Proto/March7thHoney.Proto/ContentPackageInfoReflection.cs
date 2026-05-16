using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ContentPackageInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ContentPackageInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhDb250ZW50UGFja2FnZUluZm8ucHJvdG8aGkNvbnRlbnRQYWNrYWdlU3Rh" + "dHVzLnByb3RvIk8KEkNvbnRlbnRQYWNrYWdlSW5mbxISCgpjb250ZW50X2lk" + "GAEgASgNEiUKBnN0YXR1cxgPIAEoDjIVLkNvbnRlbnRQYWNrYWdlU3RhdHVz" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ContentPackageStatusReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ContentPackageInfo), ContentPackageInfo.Parser, new string[2] { "ContentId", "Status" }, null, null, null, null)
		}));
	}
}
