using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeartDialUnlockStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeartDialUnlockStatusReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChtIZWFydERpYWxVbmxvY2tTdGF0dXMucHJvdG8qjwEKFUhlYXJ0RGlhbFVu";
		buffer[1] = "bG9ja1N0YXR1cxIhCh1IRUFSVF9ESUFMX1VOTE9DS19TVEFUVVNfTE9DSxAA";
		buffer[2] = "EioKJkhFQVJUX0RJQUxfVU5MT0NLX1NUQVRVU19VTkxPQ0tfU0lOR0xFEAES";
		buffer[3] = "JwojSEVBUlRfRElBTF9VTkxPQ0tfU1RBVFVTX1VOTE9DS19BTEwQAkIWqgIT";
		buffer[4] = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(HeartDialUnlockStatus) }, null, null));
	}
}
