using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AlleyEventChangeNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AlleyEventChangeNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxBbGxleUV2ZW50Q2hhbmdlTm90aWZ5LnByb3RvGhFEQ01KQ05PS0tOTi5w" + "cm90byJQChZBbGxleUV2ZW50Q2hhbmdlTm90aWZ5EiEKC0dMTkpPQUhCQktL" + "GAcgASgLMgwuRENNSkNOT0tLTk4SEwoLTkRPUE1NQU1NT0QYCSABKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { DCMJCNOKKNNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AlleyEventChangeNotify), AlleyEventChangeNotify.Parser, new string[2] { "GLNJOAHBBKK", "NDOPMMAMMOD" }, null, null, null, null)
		}));
	}
}
