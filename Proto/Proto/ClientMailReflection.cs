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
		buffer[0] = "ChBDbGllbnRNYWlsLnByb3RvGg5JdGVtTGlzdC5wcm90bxoOTWFpbFR5cGUu";
		buffer[1] = "cHJvdG8i4QEKCkNsaWVudE1haWwSDAoEdGltZRgBIAEoAxIKCgJpZBgCIAEo";
		buffer[2] = "DRIPCgdpc19yZWFkGAMgASgIEg8KB2NvbnRlbnQYBCABKAkSEQoJcGFyYV9s";
		buffer[3] = "aXN0GAYgAygJEhMKC2V4cGlyZV90aW1lGAcgASgDEhwKCW1haWxfdHlwZRgJ";
		buffer[4] = "IAEoDjIJLk1haWxUeXBlEhMKC3RlbXBsYXRlX2lkGAogASgNEg4KBnNlbmRl";
		buffer[5] = "chgLIAEoCRINCgV0aXRsZRgMIAEoCRIdCgphdHRhY2htZW50GA8gASgLMgku";
		buffer[6] = "SXRlbUxpc3RCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
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
