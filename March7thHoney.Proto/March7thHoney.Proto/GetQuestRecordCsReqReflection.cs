using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetQuestRecordCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetQuestRecordCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHZXRRdWVzdFJlY29yZENzUmVxLnByb3RvIhUKE0dldFF1ZXN0UmVjb3Jk" + "Q3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetQuestRecordCsReq), GetQuestRecordCsReq.Parser, null, null, null, null, null)
		}));
	}
}
