using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KGNLHPFOHDKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KGNLHPFOHDKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLR05MSFBGT0hESy5wcm90byJHCgtLR05MSFBGT0hESxITCgtMQU5ISk9N" + "Q0tOShgFIAEoDRIRCgltYXhfc2NvcmUYCCABKA0SEAoIbGV2ZWxfaWQYCSAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KGNLHPFOHDK), KGNLHPFOHDK.Parser, new string[3] { "LANHJOMCKNJ", "MaxScore", "LevelId" }, null, null, null, null)
		}));
	}
}
