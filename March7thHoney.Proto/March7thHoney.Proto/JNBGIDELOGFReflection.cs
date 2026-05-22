using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JNBGIDELOGFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JNBGIDELOGFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKTkJHSURFTE9HRi5wcm90bxoRRkJCTURGRE9FRUYucHJvdG8aEUZJR0ZE" + "TkJJSENGLnByb3RvIlgKC0pOQkdJREVMT0dGEigKEnRyYW5zZmVyX2l0ZW1f" + "bGlzdBgBIAMoCzIMLkZJR0ZETkJJSENGEh8KCWl0ZW1fbGlzdBgPIAMoCzIM" + "LkZCQk1ERkRPRUVGQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[2]
		{
			FBBMDFDOEEFReflection.Descriptor,
			FIGFDNBIHCFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JNBGIDELOGF), JNBGIDELOGF.Parser, new string[2] { "TransferItemList", "ItemList" }, null, null, null, null)
		}));
	}
}
