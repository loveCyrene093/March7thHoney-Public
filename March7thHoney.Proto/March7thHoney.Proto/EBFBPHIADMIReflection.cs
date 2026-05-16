using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EBFBPHIADMIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EBFBPHIADMIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFQkZCUEhJQURNSS5wcm90byJHCgtFQkZCUEhJQURNSRISCgp2aXNpdG9y" + "X2lkGAEgASgNEg8KB2lzX21lZXQYAiABKAgSEwoLRkdDT0hBQUdJRUcYCyAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EBFBPHIADMI), EBFBPHIADMI.Parser, new string[3] { "VisitorId", "IsMeet", "FGCOHAAGIEG" }, null, null, null, null)
		}));
	}
}
