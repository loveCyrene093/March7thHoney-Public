using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NOFMHNNIJANReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NOFMHNNIJANReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOT0ZNSE5OSUpBTi5wcm90bypHCgtOT0ZNSE5OSUpBThIbChdOT0ZNSE5O" + "SUpBTl9MSEJLQUVQTklEQRAAEhsKF05PRk1ITk5JSkFOX09KREFHTUVITElJ" + "EAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(NOFMHNNIJAN) }, null, null));
	}
}
