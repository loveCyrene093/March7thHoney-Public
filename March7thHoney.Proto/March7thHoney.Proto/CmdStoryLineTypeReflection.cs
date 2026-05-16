using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdStoryLineTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdStoryLineTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChZDbWRTdG9yeUxpbmVUeXBlLnByb3RvKtUBChBDbWRTdG9yeUxpbmVUeXBl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "EhsKF0FISkhBTU9LTUtIX1BDUERIRUxQS0VNEAASKgolQ21kU3RvcnlMaW5l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "VHJpYWxBdmF0YXJDaGFuZ2VTY05vdGlmeRDBMBIdChhDbWRTdG9yeUxpbmVJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "bmZvU2NOb3RpZnkQljESJQogQ21kQ2hhbmdlU3RvcnlMaW5lRmluaXNoU2NO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "b3RpZnkQyjASEwoOQ21kRURJSEVBRkxGQU8QwjASHQoYQ21kR2V0U3RvcnlM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "aW5lSW5mb0NzUmVxEJMxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdStoryLineType) }, null, null));
	}
}
