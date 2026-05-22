using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MarkReadMailCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MarkReadMailCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdNYXJrUmVhZE1haWxDc1JlcS5wcm90byIfChFNYXJrUmVhZE1haWxDc1Jl" + "cRIKCgJpZBgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MarkReadMailCsReq), MarkReadMailCsReq.Parser, new string[1] { "Id" }, null, null, null, null)
		}));
	}
}
