using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JPFGHCPGHGOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JPFGHCPGHGOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKUEZHSENQR0hHTy5wcm90bxoRSUlNSUZBQU9MR0cucHJvdG8aEVBHTkVG" + "S0RMUEtOLnByb3RvIlgKC0pQRkdIQ1BHSEdPEiUKDnJvZ3VlX2dldF9pbmZv" + "GMsBIAEoCzIMLklJTUlGQUFPTEdHEiIKC09JQVBIQkJEUEhMGIQHIAEoCzIM" + "LlBHTkVGS0RMUEtOQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[2]
		{
			IIMIFAAOLGGReflection.Descriptor,
			PGNEFKDLPKNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JPFGHCPGHGO), JPFGHCPGHGO.Parser, new string[2] { "RogueGetInfo", "OIAPHBBDPHL" }, null, null, null, null)
		}));
	}
}
