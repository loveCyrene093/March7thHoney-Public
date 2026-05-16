using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ActiveTraitSourceListReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ActiveTraitSourceListReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtBY3RpdmVUcmFpdFNvdXJjZUxpc3QucHJvdG8aEUFQSExKUExCT0lGLnBy" + "b3RvIkIKFUFjdGl2ZVRyYWl0U291cmNlTGlzdBILCgNjbnQYBiABKA0SHAoG" + "c291cmNlGA4gASgLMgwuQVBITEpQTEJPSUZCFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { APHLJPLBOIFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ActiveTraitSourceList), ActiveTraitSourceList.Parser, new string[2] { "Cnt", "Source" }, null, null, null, null)
		}));
	}
}
