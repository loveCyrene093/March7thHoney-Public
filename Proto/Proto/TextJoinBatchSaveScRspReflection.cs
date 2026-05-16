using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TextJoinBatchSaveScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TextJoinBatchSaveScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxUZXh0Sm9pbkJhdGNoU2F2ZVNjUnNwLnByb3RvGhFDRURHTklJRUlNQy5w" + "cm90byJPChZUZXh0Sm9pbkJhdGNoU2F2ZVNjUnNwEiQKDnRleHRfam9pbl9s" + "aXN0GAIgAygLMgwuQ0VER05JSUVJTUMSDwoHcmV0Y29kZRgMIAEoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { CEDGNIIEIMCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TextJoinBatchSaveScRsp), TextJoinBatchSaveScRsp.Parser, new string[2] { "TextJoinList", "Retcode" }, null, null, null, null)
		}));
	}
}
