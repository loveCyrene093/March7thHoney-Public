using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GNKDJFAGCBCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GNKDJFAGCBCReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFHTktESkZBR0NCQy5wcm90byrYAQoLR05LREpGQUdDQkMSGwoXR05LREpG";
		buffer[1] = "QUdDQkNfS0dQQUhPQ0RHSU4QABIbChdHTktESkZBR0NCQ19MUE9PTERJRkVE";
		buffer[2] = "QhABEhsKF0dOS0RKRkFHQ0JDX0ZCS0ZKRU5ORUJEEAISGwoXR05LREpGQUdD";
		buffer[3] = "QkNfTENMQUVCR0pQRUQQAxIbChdHTktESkZBR0NCQ19DRkVETklBSUpQUBAE";
		buffer[4] = "EhsKF0dOS0RKRkFHQ0JDX0ROQkxLQVBDRUNBEAUSGwoXR05LREpGQUdDQkNf";
		buffer[5] = "R0RLRUhCQ0RBQkoQBkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GNKDJFAGCBC) }, null, null));
	}
}
