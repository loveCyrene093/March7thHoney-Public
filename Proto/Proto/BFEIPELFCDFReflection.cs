using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BFEIPELFCDFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BFEIPELFCDFReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFCRkVJUEVMRkNERi5wcm90bxoQTGluZXVwSW5mby5wcm90bxoRTUFERUVO";
		buffer[1] = "QUJPS0UucHJvdG8aD1NjZW5lSW5mby5wcm90byJoCgtCRkVJUEVMRkNERhIZ";
		buffer[2] = "CgVzY2VuZRgCIAEoCzIKLlNjZW5lSW5mbxIbCgZsaW5ldXAYCCABKAsyCy5M";
		buffer[3] = "aW5ldXBJbmZvEiEKC0VOUEFJQ05MQ01LGA4gASgLMgwuTUFERUVOQUJPS0VC";
		buffer[4] = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			LineupInfoReflection.Descriptor,
			MADEENABOKEReflection.Descriptor,
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BFEIPELFCDF), BFEIPELFCDF.Parser, new string[3] { "Scene", "Lineup", "ENPAICNLCMK" }, null, null, null, null)
		}));
	}
}
