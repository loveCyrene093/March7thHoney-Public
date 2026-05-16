using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UpdateServerPrefsDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UpdateServerPrefsDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBVcGRhdGVTZXJ2ZXJQcmVmc0RhdGFDc1JlcS5wcm90bxoRU2VydmVyUHJl" + "ZnMucHJvdG8iQAoaVXBkYXRlU2VydmVyUHJlZnNEYXRhQ3NSZXESIgoMc2Vy" + "dmVyX3ByZWZzGA0gASgLMgwuU2VydmVyUHJlZnNCFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ServerPrefsReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UpdateServerPrefsDataCsReq), UpdateServerPrefsDataCsReq.Parser, new string[1] { "ServerPrefs" }, null, null, null, null)
		}));
	}
}
