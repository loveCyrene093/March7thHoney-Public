using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JDKAJMEPECFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JDKAJMEPECFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKREtBSk1FUEVDRi5wcm90bxobQWN0aXZlVHJhaXRTb3VyY2VMaXN0LnBy" + "b3RvIkwKC0pES0FKTUVQRUNGEisKC0VGT0xFTk1PRktQGAcgAygLMhYuQWN0" + "aXZlVHJhaXRTb3VyY2VMaXN0EhAKCHRyYWl0X2lkGAkgASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ActiveTraitSourceListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JDKAJMEPECF), JDKAJMEPECF.Parser, new string[2] { "EFOLENMOFKP", "TraitId" }, null, null, null, null)
		}));
	}
}
