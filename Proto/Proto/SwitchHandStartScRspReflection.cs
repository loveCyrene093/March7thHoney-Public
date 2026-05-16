using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwitchHandStartScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwitchHandStartScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTd2l0Y2hIYW5kU3RhcnRTY1JzcC5wcm90byI6ChRTd2l0Y2hIYW5kU3Rh" + "cnRTY1JzcBIPCgdyZXRjb2RlGAMgASgNEhEKCWNvbmZpZ19pZBgKIAEoDUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwitchHandStartScRsp), SwitchHandStartScRsp.Parser, new string[2] { "Retcode", "ConfigId" }, null, null, null, null)
		}));
	}
}
