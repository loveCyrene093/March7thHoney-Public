using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PDANOHBKBBFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PDANOHBKBBFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQREFOT0hCS0JCRi5wcm90byIzCgtQREFOT0hCS0JCRhITCgtJRUtQT01P" + "TU9QSBgBIAEoCRIPCgdyZXRjb2RlGAMgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PDANOHBKBBF), PDANOHBKBBF.Parser, new string[2] { "IEKPOMOMOPH", "Retcode" }, null, null, null, null)
		}));
	}
}
