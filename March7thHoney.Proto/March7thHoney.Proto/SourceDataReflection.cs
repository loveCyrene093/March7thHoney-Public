using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SourceDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SourceDataReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChBTb3VyY2VEYXRhLnByb3RvGhFCS0FDQkdGREREQS5wcm90bxoRQ09PQ0xJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "UEdDRUgucHJvdG8idgoKU291cmNlRGF0YRIhCgtOSUhBSk1IS09CQxgBIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "DjIMLkJLQUNCR0ZERERBEg0KA3VpZBgLIAEoDUgAEicKD3JvbGVfZ29vZHNf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "aW5mbxgMIAEoDjIMLkNPT0NMSVBHQ0VISABCDQoLRlBDRFBEUEhLSkpCFqoC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			BKACBGFDDDAReflection.Descriptor,
			COOCLIPGCEHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SourceData), SourceData.Parser, new string[3] { "NIHAJMHKOBC", "Uid", "RoleGoodsInfo" }, new string[1] { "FPCDPDPHKJJ" }, null, null, null)
		}));
	}
}
