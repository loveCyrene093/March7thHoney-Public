using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LockEquipmentScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LockEquipmentScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhMb2NrRXF1aXBtZW50U2NSc3AucHJvdG8iJQoSTG9ja0VxdWlwbWVudFNj" + "UnNwEg8KB3JldGNvZGUYASABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LockEquipmentScRsp), LockEquipmentScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
