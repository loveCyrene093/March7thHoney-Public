using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TarotBookFinishStoryCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TarotBookFinishStoryCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9UYXJvdEJvb2tGaW5pc2hTdG9yeUNzUmVxLnByb3RvIjAKGVRhcm90Qm9v" + "a0ZpbmlzaFN0b3J5Q3NSZXESEwoLTUFGTUNJUEFJS0sYCyABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TarotBookFinishStoryCsReq), TarotBookFinishStoryCsReq.Parser, new string[1] { "MAFMCIPAIKK" }, null, null, null, null)
		}));
	}
}
