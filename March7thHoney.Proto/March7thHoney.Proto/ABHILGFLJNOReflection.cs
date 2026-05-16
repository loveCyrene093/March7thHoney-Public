using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ABHILGFLJNOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ABHILGFLJNOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBQkhJTEdGTEpOTy5wcm90byJBCgtBQkhJTEdGTEpOTxIRCgljb25maWdf" + "aWQYASABKA0SEAoIZ3JvdXBfaWQYBSABKA0SDQoFc3RhdGUYCiABKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ABHILGFLJNO), ABHILGFLJNO.Parser, new string[3] { "ConfigId", "GroupId", "State" }, null, null, null, null)
		}));
	}
}
