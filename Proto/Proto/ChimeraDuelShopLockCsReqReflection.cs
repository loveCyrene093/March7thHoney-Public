using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelShopLockCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelShopLockCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5DaGltZXJhRHVlbFNob3BMb2NrQ3NSZXEucHJvdG8iagoYQ2hpbWVyYUR1" + "ZWxTaG9wTG9ja0NzUmVxEhEKCWlzX2xvY2tlZBgPIAEoCBIVCgtIQ05LQUpO" + "S0dGSBgIIAEoDUgAEhUKC0RFQUtPT0VCTEpMGA0gASgNSABCDQoLQlBJSEZB" + "SkNMT0NCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelShopLockCsReq), ChimeraDuelShopLockCsReq.Parser, new string[3] { "IsLocked", "HCNKAJNKGFH", "DEAKOOEBLJL" }, new string[1] { "BPIHFAJCLOC" }, null, null, null)
		}));
	}
}
