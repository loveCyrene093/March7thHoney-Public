using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FriendSimpleInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FriendSimpleInfoReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChZGcmllbmRTaW1wbGVJbmZvLnByb3RvGhFQSE5IRUVPTEFETC5wcm90bxoW";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "UGxheWVyU2ltcGxlSW5mby5wcm90bxoSUGxheWluZ1N0YXRlLnByb3RvIsAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "ChBGcmllbmRTaW1wbGVJbmZvEiYKC3BsYXllcl9pbmZvGAEgASgLMhEuUGxh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "eWVyU2ltcGxlSW5mbxITCgtyZW1hcmtfbmFtZRgHIAEoCRIRCglpc19tYXJr";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "ZWQYCSABKAgSJAoNcGxheWluZ19zdGF0ZRgLIAEoDjINLlBsYXlpbmdTdGF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "ZRITCgtjcmVhdGVfdGltZRgMIAEoAxIhCgtGQ0tESEZGTUVDQxgOIAEoCzIM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "LlBITkhFRU9MQURMQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[3]
		{
			PHNHEEOLADLReflection.Descriptor,
			PlayerSimpleInfoReflection.Descriptor,
			PlayingStateReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FriendSimpleInfo), FriendSimpleInfo.Parser, new string[6] { "PlayerInfo", "RemarkName", "IsMarked", "PlayingState", "CreateTime", "FCKDHFFMECC" }, null, null, null, null)
		}));
	}
}
