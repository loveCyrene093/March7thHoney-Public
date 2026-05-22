using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyCheatDiceCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyCheatDiceCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxNb25vcG9seUNoZWF0RGljZUNzUmVxLnByb3RvIi0KFk1vbm9wb2x5Q2hl" + "YXREaWNlQ3NSZXESEwoLTUZIS0dQSkpHQk4YCyABKA1CFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyCheatDiceCsReq), MonopolyCheatDiceCsReq.Parser, new string[1] { "MFHKGPJJGBN" }, null, null, null, null)
		}));
	}
}
