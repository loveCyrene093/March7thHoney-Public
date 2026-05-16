using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NIGPFJAEPGFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NIGPFJAEPGFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOSUdQRkpBRVBHRi5wcm90bxoRS0dDTE5NSEFBTU0ucHJvdG8iQQoLTklH" + "UEZKQUVQR0YSIQoLTUJMUEhLRkdPSkIYAyABKAsyDC5LR0NMTk1IQUFNTRIP" + "CgdpdGVtX2lkGAsgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { KGCLNMHAAMMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NIGPFJAEPGF), NIGPFJAEPGF.Parser, new string[2] { "MBLPHKFGOJB", "ItemId" }, null, null, null, null)
		}));
	}
}
