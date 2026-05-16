using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateStartCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateStartCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRGYXRlU3RhcnRDc1JlcS5wcm90bxoRSEFKQU9HR1BDSkMucHJvdG8iXgoO" + "RmF0ZVN0YXJ0Q3NSZXESIQoLYXZhdGFyX2xpc3QYASADKAsyDC5IQUpBT0dH" + "UENKQxIPCgdhcmVhX2lkGAkgASgNEhgKEGRpZmZpY3VsdHlfbGV2ZWwYDyAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { HAJAOGGPCJCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateStartCsReq), FateStartCsReq.Parser, new string[3] { "AvatarList", "AreaId", "DifficultyLevel" }, null, null, null, null)
		}));
	}
}
