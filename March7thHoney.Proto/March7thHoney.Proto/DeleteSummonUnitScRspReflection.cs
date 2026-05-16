using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DeleteSummonUnitScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DeleteSummonUnitScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtEZWxldGVTdW1tb25Vbml0U2NSc3AucHJvdG8iQAoVRGVsZXRlU3VtbW9u" + "VW5pdFNjUnNwEhYKDmVudGl0eV9pZF9saXN0GAMgAygNEg8KB3JldGNvZGUY" + "CyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DeleteSummonUnitScRsp), DeleteSummonUnitScRsp.Parser, new string[2] { "EntityIdList", "Retcode" }, null, null, null, null)
		}));
	}
}
