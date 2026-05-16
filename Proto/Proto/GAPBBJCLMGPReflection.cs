using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GAPBBJCLMGPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GAPBBJCLMGPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHQVBCQkpDTE1HUC5wcm90bypkCgtHQVBCQkpDTE1HUBIbChdHQVBCQkpD" + "TE1HUF9GSE1JR0pCSUdGQxAAEhsKF0dBUEJCSkNMTUdQX0RHRUNHQUFGREpN" + "EAESGwoXR0FQQkJKQ0xNR1BfRkpJR0hFQ0FOT04QAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GAPBBJCLMGP) }, null, null));
	}
}
