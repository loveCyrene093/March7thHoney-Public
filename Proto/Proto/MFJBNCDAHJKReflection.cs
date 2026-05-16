using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MFJBNCDAHJKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MFJBNCDAHJKReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFNRkpCTkNEQUhKSy5wcm90byq7AQoLTUZKQk5DREFISksSGwoXTUZKQk5D";
		buffer[1] = "REFISktfTEVDTkZBR0NGTkgQABIbChdNRkpCTkNEQUhKS19NQU9ER1BERU1E";
		buffer[2] = "ShABEhsKF01GSkJOQ0RBSEpLX09KQUZFSE1PTERQEAISGwoXTUZKQk5DREFI";
		buffer[3] = "SktfREtQSUdERUVIQ08QAxIbChdNRkpCTkNEQUhKS19DT0JDSk9ERklJRhAE";
		buffer[4] = "EhsKF01GSkJOQ0RBSEpLX01KQU5GQk1GQk5BEAVCFqoCE01hcmNoN3RoSG9u";
		buffer[5] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(MFJBNCDAHJK) }, null, null));
	}
}
