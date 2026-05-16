using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ElationActivityLevelDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ElationActivityLevelDataReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch5FbGF0aW9uQWN0aXZpdHlMZXZlbERhdGEucHJvdG8ifwoYRWxhdGlvbkFj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dGl2aXR5TGV2ZWxEYXRhEhAKCGxldmVsX2lkGAEgASgNEhMKC0JMRU5NR0pE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "S0VQGAIgASgNEhMKC0RIUEhMQ0hQS0ZMGAcgASgNEhIKCmlzX3BlcmZlY3QY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "CyABKAgSEwoLT0pPSUpFR05GRU8YDSABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ElationActivityLevelData), ElationActivityLevelData.Parser, new string[5] { "LevelId", "BLENMGJDKEP", "DHPHLCHPKFL", "IsPerfect", "OJOIJEGNFEO" }, null, null, null, null)
		}));
	}
}
