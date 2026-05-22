using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ENGOJBOMDAFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ENGOJBOMDAFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFTkdPSkJPTURBRi5wcm90bypHCgtFTkdPSkJPTURBRhIbChdFTkdPSkJP" + "TURBRl9QQ1BESEVMUEtFTRAAEhsKF0VOR09KQk9NREFGX09BR0FEQ09OSU5D" + "EAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(ENGOJBOMDAF) }, null, null));
	}
}
