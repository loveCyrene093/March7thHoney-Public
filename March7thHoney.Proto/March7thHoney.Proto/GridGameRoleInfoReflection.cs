using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridGameRoleInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridGameRoleInfoReflection()
	{
		InlineArray11<string> buffer = default(InlineArray11<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 0) = "ChZHcmlkR2FtZVJvbGVJbmZvLnByb3RvIq0DChBHcmlkR2FtZVJvbGVJbmZv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 1) = "EgoKAmlkGAEgASgNEgsKA3BvcxgCIAEoDRJWChxjb252ZXJ0X3Byb3BlcnR5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 2) = "X3RvX2ZpeHBvaW50GAYgAygLMjAuR3JpZEdhbWVSb2xlSW5mby5Db252ZXJ0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 3) = "UHJvcGVydHlUb0ZpeHBvaW50RW50cnkSHwoXdXBkYXRlX2VxdWlwc19jb21w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 4) = "b25lbnQYByADKA0SWwofZ3JpZF9maWdodF92YWx1ZV9pbml0X2NvbXBvbmVu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 5) = "dBgKIAMoCzIyLkdyaWRHYW1lUm9sZUluZm8uR3JpZEZpZ2h0VmFsdWVJbml0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 6) = "Q29tcG9uZW50RW50cnkSEQoJcm9sZV9zdGFyGAsgASgNEhEKCXVuaXF1ZV9p";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 7) = "ZBgMIAEoDRpACh5Db252ZXJ0UHJvcGVydHlUb0ZpeHBvaW50RW50cnkSCwoD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 8) = "a2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4ARpCCiBHcmlkRmlnaHRWYWx1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 9) = "ZUluaXRDb21wb25lbnRFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray11<string>, string>(ref buffer, 10) = "KA06AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray11<string>, string>(in buffer, 11))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridGameRoleInfo), GridGameRoleInfo.Parser, new string[7] { "Id", "Pos", "ConvertPropertyToFixpoint", "UpdateEquipsComponent", "GridFightValueInitComponent", "RoleStar", "UniqueId" }, null, null, null, new GeneratedClrTypeInfo[2])
		}));
	}
}
