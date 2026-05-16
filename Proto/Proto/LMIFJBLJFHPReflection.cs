using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LMIFJBLJFHPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LMIFJBLJFHPReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFMTUlGSkJMSkZIUC5wcm90bxoRT09CUE1BT0JQT0oucHJvdG8aF1JvZ3Vl";
		buffer[1] = "VGFsZW50U3RhdHVzLnByb3RvImkKC0xNSUZKQkxKRkhQEiIKBnN0YXR1cxgG";
		buffer[2] = "IAEoDjISLlJvZ3VlVGFsZW50U3RhdHVzEhMKC0tGSkVNSU9KTFBKGAsgASgN";
		buffer[3] = "EiEKC0dIRUNDUE5NQ01EGA8gAygLMgwuT09CUE1BT0JQT0pCFqoCE01hcmNo";
		buffer[4] = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			OOBPMAOBPOJReflection.Descriptor,
			RogueTalentStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LMIFJBLJFHP), LMIFJBLJFHP.Parser, new string[3] { "Status", "KFJEMIOJLPJ", "GHECCPNMCMD" }, null, null, null, null)
		}));
	}
}
