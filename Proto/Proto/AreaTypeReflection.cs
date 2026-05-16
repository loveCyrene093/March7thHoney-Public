using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AreaTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AreaTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg5BcmVhVHlwZS5wcm90bypxCghBcmVhVHlwZRINCglBUkVBX05PTkUQABIL" + "CgdBUkVBX0NOEAESCwoHQVJFQV9KUBACEg0KCUFSRUFfQVNJQRADEg0KCUFS" + "RUFfV0VTVBAEEgsKB0FSRUFfS1IQBRIRCg1BUkVBX09WRVJTRUFTEAZCFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(AreaType) }, null, null));
	}
}
