using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournRenameArchiveScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournRenameArchiveScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSb2d1ZVRvdXJuUmVuYW1lQXJjaGl2ZVNjUnNwLnByb3RvIlIKHFJvZ3Vl" + "VG91cm5SZW5hbWVBcmNoaXZlU2NSc3ASEwoLS0tHSUVFTkNPSUMYBSABKA0S" + "DAoEbmFtZRgHIAEoCRIPCgdyZXRjb2RlGA8gASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournRenameArchiveScRsp), RogueTournRenameArchiveScRsp.Parser, new string[3] { "KKGIEENCOIC", "Name", "Retcode" }, null, null, null, null)
		}));
	}
}
