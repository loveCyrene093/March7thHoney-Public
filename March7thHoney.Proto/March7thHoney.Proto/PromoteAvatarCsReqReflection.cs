using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PromoteAvatarCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PromoteAvatarCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhQcm9tb3RlQXZhdGFyQ3NSZXEucHJvdG8aDkl0ZW1Db3N0LnByb3RvIkoK" + "ElByb21vdGVBdmF0YXJDc1JlcRIcCglpdGVtX2xpc3QYASADKAsyCS5JdGVt" + "Q29zdBIWCg5iYXNlX2F2YXRhcl9pZBgPIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemCostReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PromoteAvatarCsReq), PromoteAvatarCsReq.Parser, new string[2] { "ItemList", "BaseAvatarId" }, null, null, null, null)
		}));
	}
}
