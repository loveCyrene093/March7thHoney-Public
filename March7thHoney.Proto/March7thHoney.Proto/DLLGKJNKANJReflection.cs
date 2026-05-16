using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DLLGKJNKANJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DLLGKJNKANJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFETExHS0pOS0FOSi5wcm90bxoRQUNQTUtQTE9CRUYucHJvdG8aEU1GSkJO" + "Q0RBSEpLLnByb3RvIkcKC0RMTEdLSk5LQU5KEhwKBnJlYXNvbhgFIAEoDjIM" + "Lk1GSkJOQ0RBSEpLEhoKBGRhdGEYCCABKAsyDC5BQ1BNS1BMT0JFRkIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[2]
		{
			ACPMKPLOBEFReflection.Descriptor,
			MFJBNCDAHJKReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DLLGKJNKANJ), DLLGKJNKANJ.Parser, new string[2] { "Reason", "Data" }, null, null, null, null)
		}));
	}
}
