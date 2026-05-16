using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueWorkbenchReforgeBuffReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueWorkbenchReforgeBuffReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiJSb2d1ZVdvcmtiZW5jaFJlZm9yZ2VCdWZmUmVxLnByb3RvGhFQTkFNQ0pQ";
		buffer[1] = "TkNOQi5wcm90byJqChxSb2d1ZVdvcmtiZW5jaFJlZm9yZ2VCdWZmUmVxEiEK";
		buffer[2] = "C0pCR0ZQSkxNRkhIGAcgASgLMgwuUE5BTUNKUE5DTkISFgoOcHJvcF9lbnRp";
		buffer[3] = "dHlfaWQYCyABKA0SDwoHZnVuY19pZBgOIAEoDUIWqgITTWFyY2g3dGhIb25l";
		buffer[4] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { PNAMCJPNCNBReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueWorkbenchReforgeBuffReq), RogueWorkbenchReforgeBuffReq.Parser, new string[3] { "JBGFPJLMFHH", "PropEntityId", "FuncId" }, null, null, null, null)
		}));
	}
}
