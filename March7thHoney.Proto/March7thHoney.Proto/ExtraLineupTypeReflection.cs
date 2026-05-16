using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ExtraLineupTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ExtraLineupTypeReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 0) = "ChVFeHRyYUxpbmV1cFR5cGUucHJvdG8qxgMKD0V4dHJhTGluZXVwVHlwZRIP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 1) = "CgtMSU5FVVBfTk9ORRAAEhQKEExJTkVVUF9DSEFMTEVOR0UQARIQCgxMSU5F";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 2) = "VVBfUk9HVUUQAhIWChJMSU5FVVBfQ0hBTExFTkdFXzIQAxIWChJMSU5FVVBf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 3) = "Q0hBTExFTkdFXzMQBBIaChZMSU5FVVBfUk9HVUVfQ0hBTExFTkdFEAUSFgoS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 4) = "TElORVVQX1NUQUdFX1RSSUFMEAYSFgoSTElORVVQX1JPR1VFX1RSSUFMEAcS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 5) = "EwoPTElORVVQX0FDVElWSVRZEAgSFgoSTElORVVQX0JPWElOR19DTFVCEAkS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 6) = "GwoXTElORVVQX1RSRUFTVVJFX0RVTkdFT04QCxIWChJMSU5FVVBfQ0hFU1Nf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 7) = "Uk9HVUUQDBITCg9MSU5FVVBfSEVMSU9CVVMQDRIWChJMSU5FVVBfVE9VUk5f";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 8) = "Uk9HVUUQDhIWChJMSU5FVVBfUkVMSUNfUk9HVUUQDxIXChNMSU5FVVBfQVJD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 9) = "QURFX1JPR1VFEBASFgoSTElORVVQX01BR0lDX1JPR1VFEBESDwoLTElORVVQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 10) = "X0ZBVEUQEhIVChFMSU5FVVBfR1JJRF9GSUdIVBATQhaqAhNNYXJjaDd0aEhv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray12<string>, string>(ref buffer, 11) = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray12<string>, string>(in buffer, 12))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(ExtraLineupType) }, null, null));
	}
}
