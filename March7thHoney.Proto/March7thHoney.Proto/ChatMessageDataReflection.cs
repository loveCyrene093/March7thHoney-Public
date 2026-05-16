using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChatMessageDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChatMessageDataReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChVDaGF0TWVzc2FnZURhdGEucHJvdG8aFU1lc3NhZ2VDaGF0RGF0YS5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "bxoQU291cmNlRGF0YS5wcm90bxoWQ2hhdE1lc3NhZ2VFeHRyYS5wcm90byK4";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "AQoPQ2hhdE1lc3NhZ2VEYXRhEhMKC2NyZWF0ZV90aW1lGAQgASgEEh8KClNv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "dXJjZURhdGEYCCABKAsyCy5Tb3VyY2VEYXRhEicKDW1lc3NhZ2VfZGF0YXMY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "CSADKAsyEC5NZXNzYWdlQ2hhdERhdGESIgoHZXh0cmFfYRgKIAEoCzIRLkNo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "YXRNZXNzYWdlRXh0cmESIgoHZXh0cmFfYhgLIAEoCzIRLkNoYXRNZXNzYWdl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "RXh0cmFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[3]
		{
			MessageChatDataReflection.Descriptor,
			SourceDataReflection.Descriptor,
			ChatMessageExtraReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChatMessageData), ChatMessageData.Parser, new string[5] { "CreateTime", "SourceData", "MessageDatas", "ExtraA", "ExtraB" }, null, null, null, null)
		}));
	}
}
