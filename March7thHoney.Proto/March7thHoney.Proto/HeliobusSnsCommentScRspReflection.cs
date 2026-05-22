using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeliobusSnsCommentScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeliobusSnsCommentScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1IZWxpb2J1c1Nuc0NvbW1lbnRTY1JzcC5wcm90bxoRRExGT0dKR0NDR1Au" + "cHJvdG8iTQoXSGVsaW9idXNTbnNDb21tZW50U2NSc3ASDwoHcmV0Y29kZRgJ" + "IAEoDRIhCgtJR0lQQUtFTEpGRBgOIAEoCzIMLkRMRk9HSkdDQ0dQQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { DLFOGJGCCGPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HeliobusSnsCommentScRsp), HeliobusSnsCommentScRsp.Parser, new string[2] { "Retcode", "IGIPAKELJFD" }, null, null, null, null)
		}));
	}
}
