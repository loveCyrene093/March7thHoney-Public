using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MatchPlayDataChangeNtfReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MatchPlayDataChangeNtfReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxNYXRjaFBsYXlEYXRhQ2hhbmdlTnRmLnByb3RvGhFCUEpET0VNQk5NRC5w" + "cm90byI7ChZNYXRjaFBsYXlEYXRhQ2hhbmdlTnRmEiEKC1BBQUdLQkZOSEtL" + "GAogASgLMgwuQlBKRE9FTUJOTURCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[1] { BPJDOEMBNMDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MatchPlayDataChangeNtf), MatchPlayDataChangeNtf.Parser, new string[1] { "PAAGKBFNHKK" }, null, null, null, null)
		}));
	}
}
