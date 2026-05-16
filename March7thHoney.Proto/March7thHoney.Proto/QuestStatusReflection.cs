using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class QuestStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static QuestStatusReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFRdWVzdFN0YXR1cy5wcm90bypjCgtRdWVzdFN0YXR1cxIOCgpRVUVTVF9O" + "T05FEAASDwoLUVVFU1RfRE9JTkcQARIQCgxRVUVTVF9GSU5JU0gQAhIPCgtR" + "VUVTVF9DTE9TRRADEhAKDFFVRVNUX0RFTEVURRAEQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(QuestStatus) }, null, null));
	}
}
