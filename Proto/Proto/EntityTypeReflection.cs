using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EntityTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EntityTypeReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChBFbnRpdHlUeXBlLnByb3RvKqEBCgpFbnRpdHlUeXBlEg8KC0VOVElUWV9O";
		buffer[1] = "T05FEAASEQoNRU5USVRZX0FWQVRBUhABEhIKDkVOVElUWV9NT05TVEVSEAIS";
		buffer[2] = "DgoKRU5USVRZX05QQxADEg8KC0VOVElUWV9QUk9QEAQSEgoORU5USVRZX1RS";
		buffer[3] = "SUdHRVIQBRIOCgpFTlRJVFlfRU5WEAYSFgoSRU5USVRZX1NVTU1PTl9VTklU";
		buffer[4] = "EAdCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(EntityType) }, null, null));
	}
}
