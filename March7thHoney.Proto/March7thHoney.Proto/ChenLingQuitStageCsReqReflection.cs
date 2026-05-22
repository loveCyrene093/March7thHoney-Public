using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChenLingQuitStageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChenLingQuitStageCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxDaGVuTGluZ1F1aXRTdGFnZUNzUmVxLnByb3RvIi0KFkNoZW5MaW5nUXVp" + "dFN0YWdlQ3NSZXESEwoLUEpMQURHT09GS0UYCCABKA1CFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChenLingQuitStageCsReq), ChenLingQuitStageCsReq.Parser, new string[1] { "PJLADGOOFKE" }, null, null, null, null)
		}));
	}
}
