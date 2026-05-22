using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetClientPausedScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetClientPausedScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTZXRDbGllbnRQYXVzZWRTY1JzcC5wcm90byI3ChRTZXRDbGllbnRQYXVz" + "ZWRTY1JzcBIOCgZwYXVzZWQYBiABKAgSDwoHcmV0Y29kZRgKIAEoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetClientPausedScRsp), SetClientPausedScRsp.Parser, new string[2] { "Paused", "Retcode" }, null, null, null, null)
		}));
	}
}
