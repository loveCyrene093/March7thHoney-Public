using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KEEDJBIEJOFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KEEDJBIEJOFReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFLRUVESkJJRUpPRi5wcm90bxoQTGluZXVwSW5mby5wcm90bxoRTUFERUVO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "QUJPS0UucHJvdG8aD1NjZW5lSW5mby5wcm90byJoCgtLRUVESkJJRUpPRhIZ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "CgVzY2VuZRgBIAEoCzIKLlNjZW5lSW5mbxIbCgZsaW5ldXAYBCABKAsyCy5M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "aW5ldXBJbmZvEiEKC0VOUEFJQ05MQ01LGAcgASgLMgwuTUFERUVOQUJPS0VC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[3]
		{
			LineupInfoReflection.Descriptor,
			MADEENABOKEReflection.Descriptor,
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KEEDJBIEJOF), KEEDJBIEJOF.Parser, new string[3] { "Scene", "Lineup", "ENPAICNLCMK" }, null, null, null, null)
		}));
	}
}
