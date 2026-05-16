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
		buffer[0] = "ChVFeHRyYUxpbmV1cFR5cGUucHJvdG8qxgMKD0V4dHJhTGluZXVwVHlwZRIP";
		buffer[1] = "CgtMSU5FVVBfTk9ORRAAEhQKEExJTkVVUF9DSEFMTEVOR0UQARIQCgxMSU5F";
		buffer[2] = "VVBfUk9HVUUQAhIWChJMSU5FVVBfQ0hBTExFTkdFXzIQAxIWChJMSU5FVVBf";
		buffer[3] = "Q0hBTExFTkdFXzMQBBIaChZMSU5FVVBfUk9HVUVfQ0hBTExFTkdFEAUSFgoS";
		buffer[4] = "TElORVVQX1NUQUdFX1RSSUFMEAYSFgoSTElORVVQX1JPR1VFX1RSSUFMEAcS";
		buffer[5] = "EwoPTElORVVQX0FDVElWSVRZEAgSFgoSTElORVVQX0JPWElOR19DTFVCEAkS";
		buffer[6] = "GwoXTElORVVQX1RSRUFTVVJFX0RVTkdFT04QCxIWChJMSU5FVVBfQ0hFU1Nf";
		buffer[7] = "Uk9HVUUQDBITCg9MSU5FVVBfSEVMSU9CVVMQDRIWChJMSU5FVVBfVE9VUk5f";
		buffer[8] = "Uk9HVUUQDhIWChJMSU5FVVBfUkVMSUNfUk9HVUUQDxIXChNMSU5FVVBfQVJD";
		buffer[9] = "QURFX1JPR1VFEBASFgoSTElORVVQX01BR0lDX1JPR1VFEBESDwoLTElORVVQ";
		buffer[10] = "X0ZBVEUQEhIVChFMSU5FVVBfR1JJRF9GSUdIVBATQhaqAhNNYXJjaDd0aEhv";
		buffer[11] = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(ExtraLineupType) }, null, null));
	}
}
