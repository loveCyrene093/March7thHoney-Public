using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AEKIPJMMGDEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AEKIPJMMGDEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBRUtJUEpNTUdERS5wcm90byJcCgtBRUtJUEpNTUdERRIPCgdpdGVtX2lk" + "GAEgASgNEhMKC09ESk5NTE1LS0ZFGAIgASgNEhAKCHNraWxsX2lkGAMgASgN" + "EhUKDWRpc3BsYXlfdmFsdWUYBCABKAVCFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AEKIPJMMGDE), AEKIPJMMGDE.Parser, new string[4] { "ItemId", "ODJNMLMKKFE", "SkillId", "DisplayValue" }, null, null, null, null)
		}));
	}
}
