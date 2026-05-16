using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdateGroupPropertyScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdateGroupPropertyScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "Ch5VcGRhdGVHcm91cFByb3BlcnR5U2NSc3AucHJvdG8ipAEKGFVwZGF0ZUdy";
		buffer[1] = "b3VwUHJvcGVydHlTY1JzcBIQCghncm91cF9pZBgCIAEoDRIUCgxkaW1lbnNp";
		buffer[2] = "b25faWQYAyABKA0SEwoLRUxLT0NJSk5BQksYBSABKAUSEAoIZmxvb3JfaWQY";
		buffer[3] = "BiABKA0SDwoHcmV0Y29kZRgIIAEoDRITCgtFTE5DSkZGSkZJSBgKIAEoCRIT";
		buffer[4] = "CgtGTkFPRE5HSkFNTRgMIAEoBUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[5] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdateGroupPropertyScRsp), UpdateGroupPropertyScRsp.Parser, new string[7] { "GroupId", "DimensionId", "ELKOCIJNABK", "FloorId", "Retcode", "ELNCJFFJFIH", "FNAODNGJAMM" }, null, null, null, null)
		}));
	}
}
