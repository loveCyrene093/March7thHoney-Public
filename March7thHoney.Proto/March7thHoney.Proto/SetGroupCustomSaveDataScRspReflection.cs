using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetGroupCustomSaveDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetGroupCustomSaveDataScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFTZXRHcm91cEN1c3RvbVNhdmVEYXRhU2NSc3AucHJvdG8iUgobU2V0R3Jv" + "dXBDdXN0b21TYXZlRGF0YVNjUnNwEg8KB3JldGNvZGUYBiABKA0SEAoIZ3Jv" + "dXBfaWQYDSABKA0SEAoIZW50cnlfaWQYDyABKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetGroupCustomSaveDataScRsp), SetGroupCustomSaveDataScRsp.Parser, new string[3] { "Retcode", "GroupId", "EntryId" }, null, null, null, null)
		}));
	}
}
