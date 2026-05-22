using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerBoardModuleSyncReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerBoardModuleSyncReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChtQbGF5ZXJCb2FyZE1vZHVsZVN5bmMucHJvdG8aE0hlYWRGcmFtZUluZm8u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "cHJvdG8aEkhlYWRJY29uRGF0YS5wcm90byKtAQoVUGxheWVyQm9hcmRNb2R1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "bGVTeW5jEhEKCXNpZ25hdHVyZRgBIAEoCRIuChd1bmxvY2tlZF9oZWFkX2lj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "b25fbGlzdBgDIAMoCzINLkhlYWRJY29uRGF0YRInCg9oZWFkX2ZyYW1lX2lu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "Zm8YByABKAsyDi5IZWFkRnJhbWVJbmZvEhMKC0RHSEpMRkVLTVBPGAsgASgI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "EhMKC0JOR0pHRVBHRE5LGA8gAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			HeadFrameInfoReflection.Descriptor,
			HeadIconDataReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerBoardModuleSync), PlayerBoardModuleSync.Parser, new string[5] { "Signature", "UnlockedHeadIconList", "HeadFrameInfo", "DGHJLFEKMPO", "BNGJGEPGDNK" }, null, null, null, null)
		}));
	}
}
