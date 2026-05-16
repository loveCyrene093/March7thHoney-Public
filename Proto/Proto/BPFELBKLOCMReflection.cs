using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BPFELBKLOCMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BPFELBKLOCMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCUEZFTEJLTE9DTS5wcm90bxocR3JpZEZpZ2h0Rm9yZ2VSb2xlSW5mby5w" + "cm90byJgCgtCUEZFTEJLTE9DTRIOCgRnb2xkGAQgASgNSAASMgoPcm9sZV9n" + "b29kc19pbmZvGAkgASgLMhcuR3JpZEZpZ2h0Rm9yZ2VSb2xlSW5mb0gAQg0K" + "C0NLTUVBSURLT0lBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { GridFightForgeRoleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BPFELBKLOCM), BPFELBKLOCM.Parser, new string[2] { "Gold", "RoleGoodsInfo" }, new string[1] { "CKMEAIDKOIA" }, null, null, null)
		}));
	}
}
