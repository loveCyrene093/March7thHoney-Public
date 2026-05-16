using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class InteractChargerCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static InteractChargerCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpJbnRlcmFjdENoYXJnZXJDc1JlcS5wcm90bxoRQ2hhcmdlckluZm8ucHJv" + "dG8iOgoUSW50ZXJhY3RDaGFyZ2VyQ3NSZXESIgoMY2hhcmdlcl9pbmZvGAog" + "ASgLMgwuQ2hhcmdlckluZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[1] { ChargerInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(InteractChargerCsReq), InteractChargerCsReq.Parser, new string[1] { "ChargerInfo" }, null, null, null, null)
		}));
	}
}
