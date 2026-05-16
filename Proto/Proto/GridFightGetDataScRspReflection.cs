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
		buffer[0] = "ChtHcmlkRmlnaHRHZXREYXRhU2NSc3AucHJvdG8aGkdyaWRGaWdodEN1cnJl";
		buffer[1] = "bnRJbmZvLnByb3RvGhlHcmlkRmlnaHRTeXN0ZW1JbmZvLnByb3RvIokBChVH";
		buffer[2] = "cmlkRmlnaHRHZXREYXRhU2NSc3ASDwoHcmV0Y29kZRgCIAEoDRIsCg5yb2d1";
		buffer[3] = "ZV9nZXRfaW5mbxgEIAEoCzIULkdyaWRGaWdodFN5c3RlbUluZm8SMQoSZmln";
		buffer[4] = "aHRfY3VycmVudF9pbmZvGA0gASgLMhUuR3JpZEZpZ2h0Q3VycmVudEluZm9C";
		buffer[5] = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			GridFightCurrentInfoReflection.Descriptor,
			GridFightSystemInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightGetDataScRsp), GridFightGetDataScRsp.Parser, new string[3] { "Retcode", "RogueGetInfo", "FightCurrentInfo" }, null, null, null, null)
		}));
	}
}
