using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MainMissionReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MainMissionReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFNYWluTWlzc2lvbi5wcm90bxoYTWlzc2lvbkN1c3RvbVZhbHVlLnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "GhNNaXNzaW9uU3RhdHVzLnByb3RvImkKC01haW5NaXNzaW9uEgoKAmlkGAIg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "ASgNEh4KBnN0YXR1cxgFIAEoDjIOLk1pc3Npb25TdGF0dXMSLgoRY3VzdG9t";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "X3ZhbHVlX2xpc3QYDCADKAsyEy5NaXNzaW9uQ3VzdG9tVmFsdWVCFqoCE01h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			MissionCustomValueReflection.Descriptor,
			MissionStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MainMission), MainMission.Parser, new string[3] { "Id", "Status", "CustomValueList" }, null, null, null, null)
		}));
	}
}
