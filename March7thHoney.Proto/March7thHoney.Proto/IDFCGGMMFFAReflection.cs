using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IDFCGGMMFFAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IDFCGGMMFFAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJREZDR0dNTUZGQS5wcm90bypHCgtJREZDR0dNTUZGQRIbChdJREZDR0dN" + "TUZGQV9BUExISkZES0VDRhAAEhsKF0lERkNHR01NRkZBX0lMRktCT0JOT0VM" + "EAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(IDFCGGMMFFA) }, null, null));
	}
}
