using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ReportRelicBoxActionCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ReportRelicBoxActionCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9SZXBvcnRSZWxpY0JveEFjdGlvbkNzUmVxLnByb3RvIjAKGVJlcG9ydFJl" + "bGljQm94QWN0aW9uQ3NSZXESEwoLQ0VESVBFR0JOREgYBSABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ReportRelicBoxActionCsReq), ReportRelicBoxActionCsReq.Parser, new string[1] { "CEDIPEGBNDH" }, null, null, null, null)
		}));
	}
}
