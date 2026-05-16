using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonsterBattleTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonsterBattleTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChdNb25zdGVyQmF0dGxlVHlwZS5wcm90byrgAQoRTW9uc3RlckJhdHRsZVR5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "cGUSHAoYTU9OU1RFUl9CQVRUTEVfVFlQRV9OT05FEAASJgoiTU9OU1RFUl9C";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "QVRUTEVfVFlQRV9UUklHR0VSX0JBVFRMRRABEjIKLk1PTlNURVJfQkFUVExF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "X1RZUEVfRElSRUNUX0RJRV9TSU1VTEFURV9CQVRUTEUQAhIuCipNT05TVEVS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "X0JBVFRMRV9UWVBFX0RJUkVDVF9ESUVfU0tJUF9CQVRUTEUQAxIhCh1NT05T";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "VEVSX0JBVFRMRV9UWVBFX05PX0JBVFRMRRAEQhaqAhNNYXJjaDd0aEhvbmV5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(MonsterBattleType) }, null, null));
	}
}
