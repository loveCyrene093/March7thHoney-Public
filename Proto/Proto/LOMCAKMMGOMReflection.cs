using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LOMCAKMMGOMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LOMCAKMMGOMReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFMT01DQUtNTUdPTS5wcm90bxoOSXRlbUxpc3QucHJvdG8aEUtLS09HR0JG";
		buffer[1] = "TUlQLnByb3RvIngKC0xPTUNBS01NR09NEhMKC0hKTUpJQURCQU9DGAYgASgN";
		buffer[2] = "EiAKC0ZOTERGR0xHRU9BGAggASgLMgkuSXRlbUxpc3RIABIjCgtHRUZNTU9P";
		buffer[3] = "RURKSRgJIAEoCzIMLktLS09HR0JGTUlQSABCDQoLRk5KSk5BT0NPSUlCFqoC";
		buffer[4] = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ItemListReflection.Descriptor,
			KKKOGGBFMIPReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LOMCAKMMGOM), LOMCAKMMGOM.Parser, new string[3] { "HJMJIADBAOC", "FNLDFGLGEOA", "GEFMMOOEDJI" }, new string[1] { "FNJJNAOCOII" }, null, null, null)
		}));
	}
}
