using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TechTreeChangeNodeStateCsRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TechTreeChangeNodeStateCsRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiJUZWNoVHJlZUNoYW5nZU5vZGVTdGF0ZUNzUnNwLnByb3RvGhFKREtKUEZH";
		buffer[1] = "Sk9CSS5wcm90byJjChxUZWNoVHJlZUNoYW5nZU5vZGVTdGF0ZUNzUnNwEg8K";
		buffer[2] = "B3JldGNvZGUYAyABKA0SHQoHb3BfdHlwZRgFIAEoDjIMLkpES0pQRkdKT0JJ";
		buffer[3] = "EhMKC05MR05BS0tDREdPGAYgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[4] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { JDKJPFGJOBIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TechTreeChangeNodeStateCsRsp), TechTreeChangeNodeStateCsRsp.Parser, new string[3] { "Retcode", "OpType", "NLGNAKKCDGO" }, null, null, null, null)
		}));
	}
}
