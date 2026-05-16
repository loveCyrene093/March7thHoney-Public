using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesUpgradeSkillLevelCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesUpgradeSkillLevelCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVQbGFuZXRGZXNVcGdyYWRlU2tpbGxMZXZlbENzUmVxLnByb3RvIkgKH1Bs" + "YW5ldEZlc1VwZ3JhZGVTa2lsbExldmVsQ3NSZXESEwoLT0RBREpJTE9FS08Y" + "AiABKA0SEAoIc2tpbGxfaWQYDCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesUpgradeSkillLevelCsReq), PlanetFesUpgradeSkillLevelCsReq.Parser, new string[2] { "ODADJILOEKO", "SkillId" }, null, null, null, null)
		}));
	}
}
