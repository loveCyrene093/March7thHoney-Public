using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ClientMailReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ClientMailReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChBDbGllbnRNYWlsLnByb3RvGg5JdGVtTGlzdC5wcm90bxoOTWFpbFR5cGUu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "cHJvdG8i4QEKCkNsaWVudE1haWwSDAoEdGltZRgBIAEoAxIKCgJpZBgCIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "DRIPCgdpc19yZWFkGAMgASgIEg8KB2NvbnRlbnQYBCABKAkSEQoJcGFyYV9s";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "aXN0GAYgAygJEhMKC2V4cGlyZV90aW1lGAcgASgDEhwKCW1haWxfdHlwZRgJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "IAEoDjIJLk1haWxUeXBlEhMKC3RlbXBsYXRlX2lkGAogASgNEg4KBnNlbmRl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "chgLIAEoCRINCgV0aXRsZRgMIAEoCRIdCgphdHRhY2htZW50GA8gASgLMgku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "SXRlbUxpc3RCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			ItemListReflection.Descriptor,
			MailTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ClientMail), ClientMail.Parser, new string[11]
			{
				"Time", "Id", "IsRead", "Content", "ParaList", "ExpireTime", "MailType", "TemplateId", "Sender", "Title",
				"Attachment"
			}, null, null, null, null)
		}));
	}
}
