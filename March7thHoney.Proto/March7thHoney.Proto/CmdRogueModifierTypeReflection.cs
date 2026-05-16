using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdRogueModifierTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdRogueModifierTypeReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChpDbWRSb2d1ZU1vZGlmaWVyVHlwZS5wcm90byqJAgoUQ21kUm9ndWVNb2Rp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "ZmllclR5cGUSGwoXTEtPS05ITExPTUZfUENQREhFTFBLRU0QABIhChxDbWRS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "b2d1ZU1vZGlmaWVyVXBkYXRlTm90aWZ5EJYqEh4KGUNtZFJvZ3VlTW9kaWZp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "ZXJBZGROb3RpZnkQkioSJAofQ21kUm9ndWVNb2RpZmllclNlbGVjdENlbGxT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "Y1JzcBDCKRIeChlDbWRSb2d1ZU1vZGlmaWVyRGVsTm90aWZ5EPMpEiQKH0Nt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "ZFJvZ3VlTW9kaWZpZXJTZWxlY3RDZWxsQ3NSZXEQkyoSJQogQ21kUm9ndWVN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "b2RpZmllclN0YWdlU3RhcnROb3RpZnkQzilCFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdRogueModifierType) }, null, null));
	}
}
