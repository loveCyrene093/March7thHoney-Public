using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GroupRefreshInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GroupRefreshInfoReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 0) = "ChZHcm91cFJlZnJlc2hJbmZvLnByb3RvGhFOTkhHT0JMTkNJRS5wcm90bxoa";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 1) = "U2NlbmVFbnRpdHlHcm91cEluZm8ucHJvdG8aHFNjZW5lRW50aXR5UmVmcmVz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 2) = "aEluZm8ucHJvdG8aG1NjZW5lR3JvdXBSZWZyZXNoVHlwZS5wcm90byLaAQoQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 3) = "R3JvdXBSZWZyZXNoSW5mbxIjCgR1bmsxGAEgASgLMhUuU2NlbmVFbnRpdHlH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 4) = "cm91cEluZm8SLAoMcmVmcmVzaF90eXBlGAggASgOMhYuU2NlbmVHcm91cFJl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 5) = "ZnJlc2hUeXBlEhAKCGdyb3VwX2lkGAkgASgNEiEKC0RDTEFLQ0ZKQ1BKGAsg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 6) = "AygLMgwuTk5IR09CTE5DSUUSLwoOcmVmcmVzaF9lbnRpdHkYDCADKAsyFy5T";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 7) = "Y2VuZUVudGl0eVJlZnJlc2hJbmZvEg0KBXN0YXRlGA0gASgNQhaqAhNNYXJj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 8) = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray9<string>, string>(in buffer, 9))), new FileDescriptor[4]
		{
			NNHGOBLNCIEReflection.Descriptor,
			SceneEntityGroupInfoReflection.Descriptor,
			SceneEntityRefreshInfoReflection.Descriptor,
			SceneGroupRefreshTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GroupRefreshInfo), GroupRefreshInfo.Parser, new string[6] { "Unk1", "RefreshType", "GroupId", "DCLAKCFJCPJ", "RefreshEntity", "State" }, null, null, null, null)
		}));
	}
}
