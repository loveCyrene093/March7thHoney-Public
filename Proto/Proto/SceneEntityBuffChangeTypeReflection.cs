using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneEntityBuffChangeTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneEntityBuffChangeTypeReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "Ch9TY2VuZUVudGl0eUJ1ZmZDaGFuZ2VUeXBlLnByb3RvKqoBChlTY2VuZUVu";
		buffer[1] = "dGl0eUJ1ZmZDaGFuZ2VUeXBlEikKJVNDRU5FX0VOVElUWV9CVUZGX0NIQU5H";
		buffer[2] = "RV9UWVBFX0RFRkFVTFQQABIuCipTQ0VORV9FTlRJVFlfQlVGRl9DSEFOR0Vf";
		buffer[3] = "VFlQRV9BRERfTUFaRUJVRkYQARIyCi5TQ0VORV9FTlRJVFlfQlVGRl9DSEFO";
		buffer[4] = "R0VfVFlQRV9BRERfQURWX01PRElGSUVSEAJCFqoCE01hcmNoN3RoSG9uZXku";
		buffer[5] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(SceneEntityBuffChangeType) }, null, null));
	}
}
