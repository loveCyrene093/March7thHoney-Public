using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PCDAHKGMGNBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PCDAHKGMGNBReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFQQ0RBSEtHTUdOQi5wcm90byrYAQoLUENEQUhLR01HTkISGwoXUENEQUhL";
		buffer[1] = "R01HTkJfUENQREhFTFBLRU0QABIbChdQQ0RBSEtHTUdOQl9HR0ZKS0dGRk9C";
		buffer[2] = "RRABEhsKF1BDREFIS0dNR05CX0pQTEhNTERQSU1BEAISGwoXUENEQUhLR01H";
		buffer[3] = "TkJfQkZKSEtBRURORkMQAxIbChdQQ0RBSEtHTUdOQl9EUEJNTUJLQ1BETxAE";
		buffer[4] = "EhsKF1BDREFIS0dNR05CX0lMQ0hEQktMTEZBEAUSGwoXUENEQUhLR01HTkJf";
		buffer[5] = "RkJIS0FGUE9OTEIQBkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(PCDAHKGMGNB) }, null, null));
	}
}
