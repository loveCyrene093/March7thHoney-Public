using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HandlePendingEquipScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HandlePendingEquipScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1IYW5kbGVQZW5kaW5nRXF1aXBTY1JzcC5wcm90bxoRSUpQRklISEdOR1Au" + "cHJvdG8iYAoXSGFuZGxlUGVuZGluZ0VxdWlwU2NSc3ASDwoHcmV0Y29kZRgB" + "IAEoDRIhCgtER0tFRU9FSU9CQhgDIAEoCzIMLklKUEZJSEhHTkdQEhEKCURp" + "c2NhcmRlZBgNIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { IJPFIHHGNGPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HandlePendingEquipScRsp), HandlePendingEquipScRsp.Parser, new string[3] { "Retcode", "DGKEEOEIOBB", "Discarded" }, null, null, null, null)
		}));
	}
}
