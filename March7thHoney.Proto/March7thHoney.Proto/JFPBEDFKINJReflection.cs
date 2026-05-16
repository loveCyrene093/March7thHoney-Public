using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JFPBEDFKINJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JFPBEDFKINJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKRlBCRURGS0lOSi5wcm90bxoRS0dDTE5NSEFBTU0ucHJvdG8iVgoLSkZQ" + "QkVERktJTkoSIQoLTUJMUEhLRkdPSkIYAiABKAsyDC5LR0NMTk1IQUFNTRIP" + "CgdpdGVtX2lkGAcgASgNEhMKC0ZCQ0pDS0VBSENNGA8gASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { KGCLNMHAAMMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JFPBEDFKINJ), JFPBEDFKINJ.Parser, new string[3] { "MBLPHKFGOJB", "ItemId", "FBCJCKEAHCM" }, null, null, null, null)
		}));
	}
}
