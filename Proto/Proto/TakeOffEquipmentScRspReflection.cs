using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeOffEquipmentScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeOffEquipmentScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtUYWtlT2ZmRXF1aXBtZW50U2NSc3AucHJvdG8iKAoVVGFrZU9mZkVxdWlw" + "bWVudFNjUnNwEg8KB3JldGNvZGUYBSABKA1CFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeOffEquipmentScRsp), TakeOffEquipmentScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
