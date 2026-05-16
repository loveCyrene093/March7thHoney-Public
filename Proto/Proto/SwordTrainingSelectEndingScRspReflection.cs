using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingSelectEndingScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingSelectEndingScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRTd29yZFRyYWluaW5nU2VsZWN0RW5kaW5nU2NSc3AucHJvdG8iRgoeU3dv" + "cmRUcmFpbmluZ1NlbGVjdEVuZGluZ1NjUnNwEg8KB3JldGNvZGUYBSABKA0S" + "EwoLQUdNQUhJSUhKS00YBiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingSelectEndingScRsp), SwordTrainingSelectEndingScRsp.Parser, new string[2] { "Retcode", "AGMAHIIHJKM" }, null, null, null, null)
		}));
	}
}
