using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MEHAOMGBOMCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MEHAOMGBOMCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNRUhBT01HQk9NQy5wcm90bxoRRExHRUdHQ0hDSUQucHJvdG8iMQoLTUVI" + "QU9NR0JPTUMSIgoLQUZDTU9PRkdCUEsY/QMgASgLMgwuRExHRUdHQ0hDSURC" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { DLGEGGCHCIDReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MEHAOMGBOMC), MEHAOMGBOMC.Parser, new string[1] { "AFCMOOFGBPK" }, null, null, null, null)
		}));
	}
}
