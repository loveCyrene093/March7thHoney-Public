using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class APAEPNCJDIEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static APAEPNCJDIEReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFBUEFFUE5DSkRJRS5wcm90byq7AQoLQVBBRVBOQ0pESUUSGwoXQVBBRVBO";
		buffer[1] = "Q0pESUVfS1BNTE5QSkZITkwQABIbChdBUEFFUE5DSkRJRV9GS0NDTkJESElQ";
		buffer[2] = "TxABEhsKF0FQQUVQTkNKRElFX0dETkpOR0pHTkRDEAISGwoXQVBBRVBOQ0pE";
		buffer[3] = "SUVfTUZBR0lJSEVGSEYQAxIbChdBUEFFUE5DSkRJRV9CQ0NIUEdJUEhCSRAE";
		buffer[4] = "EhsKF0FQQUVQTkNKRElFX0xHRE9OS0FCQkdHEAVCFqoCE01hcmNoN3RoSG9u";
		buffer[5] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(APAEPNCJDIE) }, null, null));
	}
}
