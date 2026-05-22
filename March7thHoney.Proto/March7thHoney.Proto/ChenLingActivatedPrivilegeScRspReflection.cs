using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChenLingActivatedPrivilegeScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChenLingActivatedPrivilegeScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVDaGVuTGluZ0FjdGl2YXRlZFByaXZpbGVnZVNjUnNwLnByb3RvIkcKH0No" + "ZW5MaW5nQWN0aXZhdGVkUHJpdmlsZWdlU2NSc3ASDwoHcmV0Y29kZRgDIAEo" + "DRITCgtIQ0VPTUJLQ0RETRgFIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChenLingActivatedPrivilegeScRsp), ChenLingActivatedPrivilegeScRsp.Parser, new string[2] { "Retcode", "HCEOMBKCDDM" }, null, null, null, null)
		}));
	}
}
