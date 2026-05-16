using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LOINGBNGDFOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LOINGBNGDFOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMT0lOR0JOR0RGTy5wcm90byIzCgtMT0lOR0JOR0RGTxITCgtDR0tQSUJO" + "QkZKRRgDIAEoDRIPCgdyZXRjb2RlGAggASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LOINGBNGDFO), LOINGBNGDFO.Parser, new string[2] { "CGKPIBNBFJE", "Retcode" }, null, null, null, null)
		}));
	}
}
