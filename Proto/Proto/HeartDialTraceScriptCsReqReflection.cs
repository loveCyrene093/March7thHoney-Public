using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeartDialTraceScriptCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeartDialTraceScriptCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9IZWFydERpYWxUcmFjZVNjcmlwdENzUmVxLnByb3RvGhFQSUNJTElJRktC" + "RS5wcm90byI+ChlIZWFydERpYWxUcmFjZVNjcmlwdENzUmVxEiEKC0dBSVBM" + "UEhFRkZLGAogASgLMgwuUElDSUxJSUZLQkVCFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { PICILIIFKBEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeartDialTraceScriptCsReq), HeartDialTraceScriptCsReq.Parser, new string[1] { "GAIPLPHEFFK" }, null, null, null, null)
		}));
	}
}
