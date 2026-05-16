using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TutorialStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TutorialStatusReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRUdXRvcmlhbFN0YXR1cy5wcm90bypNCg5UdXRvcmlhbFN0YXR1cxIRCg1U" + "VVRPUklBTF9OT05FEAASEwoPVFVUT1JJQUxfVU5MT0NLEAESEwoPVFVUT1JJ" + "QUxfRklOSVNIEAJCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(TutorialStatus) }, null, null));
	}
}
