using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetTrainWorldIdScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetTrainWorldIdScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTZXRUcmFpbldvcmxkSWRTY1JzcC5wcm90byI8ChRTZXRUcmFpbldvcmxk" + "SWRTY1JzcBITCgtMTE9MT0VIUEZIQRgHIAEoDRIPCgdyZXRjb2RlGAogASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetTrainWorldIdScRsp), SetTrainWorldIdScRsp.Parser, new string[2] { "LLOLOEHPFHA", "Retcode" }, null, null, null, null)
		}));
	}
}
