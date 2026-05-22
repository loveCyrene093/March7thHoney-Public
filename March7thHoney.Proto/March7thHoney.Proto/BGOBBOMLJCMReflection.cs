using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BGOBBOMLJCMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BGOBBOMLJCMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCR09CQk9NTEpDTS5wcm90bypHCgtCR09CQk9NTEpDTRIbChdCR09CQk9N" + "TEpDTV9QQ1BESEVMUEtFTRAAEhsKF0JHT0JCT01MSkNNX0lNSUJGRUhQRERJ" + "EAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(BGOBBOMLJCM) }, null, null));
	}
}
