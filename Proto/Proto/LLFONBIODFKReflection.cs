using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LLFONBIODFKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LLFONBIODFKReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChFMTEZPTkJJT0RGSy5wcm90bxoRSUFNQUxNTEJPRUkucHJvdG8aEUlGTE9H";
		buffer[1] = "SkJPTkhJLnByb3RvGhFNTE9GSkZCSEdMRy5wcm90byKZAgoLTExGT05CSU9E";
		buffer[2] = "RksSIQoLSUNITUtGTUFJQkIYASADKAsyDC5JQU1BTE1MQk9FSRIhCgtCSUNC";
		buffer[3] = "Sk1QQUFBThgCIAEoDjIMLk1MT0ZKRkJIR0xHEhMKC09NRktJRkFERk9DGAMg";
		buffer[4] = "ASgIEiEKC0pNSUtQQ1BJRkNEGAUgAygLMgwuSUZMT0dKQk9OSEkSDgoGZGFt";
		buffer[5] = "YWdlGAYgASgNEhMKC0JFRU1KRUNETUdCGAcgASgNEhMKC0xOT1BLTU1FTEND";
		buffer[6] = "GAkgASgNEhMKC0lIT05ESk9BUEJNGAsgASgNEhMKC0pLUEdBQ0xLRUVDGA0g";
		buffer[7] = "ASgEEhMKC0lJQUpQQURPTE1DGA4gASgNEhMKC0JJT0RBSkxMSU5PGA8gASgI";
		buffer[8] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			IAMALMLBOEIReflection.Descriptor,
			IFLOGJBONHIReflection.Descriptor,
			MLOFJFBHGLGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LLFONBIODFK), LLFONBIODFK.Parser, new string[11]
			{
				"ICHMKFMAIBB", "BICBJMPAAAN", "OMFKIFADFOC", "JMIKPCPIFCD", "Damage", "BEEMJECDMGB", "LNOPKMMELCC", "IHONDJOAPBM", "JKPGACLKEEC", "IIAJPADOLMC",
				"BIODAJLLINO"
			}, null, null, null, null)
		}));
	}
}
