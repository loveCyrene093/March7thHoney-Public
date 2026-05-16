using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournLeaveScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournLeaveScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpSb2d1ZVRvdXJuTGVhdmVTY1JzcC5wcm90bxoRQkZFSVBFTEZDREYucHJv" + "dG8iSgoUUm9ndWVUb3VybkxlYXZlU2NSc3ASDwoHcmV0Y29kZRgIIAEoDRIh" + "CgtBRkxKSkpGQ0JJThgOIAEoCzIMLkJGRUlQRUxGQ0RGQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { BFEIPELFCDFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournLeaveScRsp), RogueTournLeaveScRsp.Parser, new string[2] { "Retcode", "AFLJJJFCBIN" }, null, null, null, null)
		}));
	}
}
