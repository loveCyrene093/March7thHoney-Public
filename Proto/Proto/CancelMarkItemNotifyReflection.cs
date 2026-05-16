using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CancelMarkItemNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CancelMarkItemNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpDYW5jZWxNYXJrSXRlbU5vdGlmeS5wcm90byInChRDYW5jZWxNYXJrSXRl" + "bU5vdGlmeRIPCgdpdGVtX2lkGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CancelMarkItemNotify), CancelMarkItemNotify.Parser, new string[1] { "ItemId" }, null, null, null, null)
		}));
	}
}
