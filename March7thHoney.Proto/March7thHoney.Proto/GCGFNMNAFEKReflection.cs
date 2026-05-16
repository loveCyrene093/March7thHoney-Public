using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GCGFNMNAFEKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GCGFNMNAFEKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHQ0dGTk1OQUZFSy5wcm90byIiCgtHQ0dGTk1OQUZFSxITCgtQTEZKQkhP" + "R0NBRhgKIAEoBEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GCGFNMNAFEK), GCGFNMNAFEK.Parser, new string[1] { "PLFJBHOGCAF" }, null, null, null, null)
		}));
	}
}
