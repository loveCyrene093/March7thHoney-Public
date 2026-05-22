using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightGetDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightGetDataScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChtHcmlkRmlnaHRHZXREYXRhU2NSc3AucHJvdG8aGkdyaWRGaWdodEN1cnJl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "bnRJbmZvLnByb3RvGhlHcmlkRmlnaHRTeXN0ZW1JbmZvLnByb3RvIokBChVH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "cmlkRmlnaHRHZXREYXRhU2NSc3ASDwoHcmV0Y29kZRgCIAEoDRIsCg5yb2d1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "ZV9nZXRfaW5mbxgEIAEoCzIULkdyaWRGaWdodFN5c3RlbUluZm8SMQoSZmln";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "aHRfY3VycmVudF9pbmZvGA0gASgLMhUuR3JpZEZpZ2h0Q3VycmVudEluZm9C";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			GridFightCurrentInfoReflection.Descriptor,
			GridFightSystemInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightGetDataScRsp), GridFightGetDataScRsp.Parser, new string[3] { "Retcode", "RogueGetInfo", "FightCurrentInfo" }, null, null, null, null)
		}));
	}
}
