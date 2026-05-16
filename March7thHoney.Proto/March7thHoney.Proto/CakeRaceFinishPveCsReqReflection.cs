using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CakeRaceFinishPveCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CakeRaceFinishPveCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxDYWtlUmFjZUZpbmlzaFB2ZUNzUmVxLnByb3RvIj8KFkNha2VSYWNlRmlu" + "aXNoUHZlQ3NSZXESEwoLTERKS0VFUE5KREMYAyABKAgSEAoIc2NvcmVfaWQY" + "DCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CakeRaceFinishPveCsReq), CakeRaceFinishPveCsReq.Parser, new string[2] { "LDJKEEPNJDC", "ScoreId" }, null, null, null, null)
		}));
	}
}
