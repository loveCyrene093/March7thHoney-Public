using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MazeKillDirectCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MazeKillDirectCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlNYXplS2lsbERpcmVjdENzUmVxLnByb3RvGhFFQktPTEhKSU9GTi5wcm90" + "byJiChNNYXplS2lsbERpcmVjdENzUmVxEhMKC2VudGl0eV9saXN0GAQgAygN" + "EhMKC0dKS0dQREhOS0hFGAggASgNEiEKC0FMRkhORUhPQkpBGAkgASgOMgwu" + "RUJLT0xISklPRk5CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { EBKOLHJIOFNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MazeKillDirectCsReq), MazeKillDirectCsReq.Parser, new string[3] { "EntityList", "GJKGPDHNKHE", "ALFHNEHOBJA" }, null, null, null, null)
		}));
	}
}
