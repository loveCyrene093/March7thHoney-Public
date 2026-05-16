using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UnlockSkilltreeScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UnlockSkilltreeScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpVbmxvY2tTa2lsbHRyZWVTY1JzcC5wcm90byJIChRVbmxvY2tTa2lsbHRy" + "ZWVTY1JzcBIQCghwb2ludF9pZBgDIAEoDRINCgVsZXZlbBgIIAEoDRIPCgdy" + "ZXRjb2RlGAsgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UnlockSkilltreeScRsp), UnlockSkilltreeScRsp.Parser, new string[3] { "PointId", "Level", "Retcode" }, null, null, null, null)
		}));
	}
}
