using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IJOKCGLBBMIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IJOKCGLBBMIReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFJSk9LQ0dMQkJNSS5wcm90bxoRR0tERUtKS09JSk4ucHJvdG8aEU1MT0ZK";
		buffer[1] = "RkJIR0xHLnByb3RvIrwBCgtJSk9LQ0dMQkJNSRITCgtORUtKS01LRUpMShgB";
		buffer[2] = "IAMoDRITCgtKS1BHQUNMS0VFQxgFIAEoDRITCgtOSEdQSU1PRkVLQhgHIAEo";
		buffer[3] = "DRIhCgtCSUNCSk1QQUFBThgJIAEoDjIMLk1MT0ZKRkJIR0xHEhMKC0RIRktP";
		buffer[4] = "S0pJQk5FGAogASgNEhMKC0VKR05HTElMRkNQGA0gAygNEiEKC0VMR09JQ0hB";
		buffer[5] = "Q0ROGA8gAygLMgwuR0tERUtKS09JSk5CFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[6] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			GKDEKJKOIJNReflection.Descriptor,
			MLOFJFBHGLGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IJOKCGLBBMI), IJOKCGLBBMI.Parser, new string[7] { "NEKJKMKEJLJ", "JKPGACLKEEC", "NHGPIMOFEKB", "BICBJMPAAAN", "DHFKOKJIBNE", "EJGNGLILFCP", "ELGOICHACDN" }, null, null, null, null)
		}));
	}
}
