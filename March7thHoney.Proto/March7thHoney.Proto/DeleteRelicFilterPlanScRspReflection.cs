using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DeleteRelicFilterPlanScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DeleteRelicFilterPlanScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBEZWxldGVSZWxpY0ZpbHRlclBsYW5TY1JzcC5wcm90byJXChpEZWxldGVS" + "ZWxpY0ZpbHRlclBsYW5TY1JzcBIPCgdyZXRjb2RlGAIgASgNEhMKC0lCSk1C" + "SUFDRkVLGAQgAygNEhMKC0tJUEJJTkJJREFFGAogASgIQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DeleteRelicFilterPlanScRsp), DeleteRelicFilterPlanScRsp.Parser, new string[3] { "Retcode", "IBJMBIACFEK", "KIPBINBIDAE" }, null, null, null, null)
		}));
	}
}
