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
		buffer[0] = "ChdNb25zdGVyQmF0dGxlVHlwZS5wcm90byrgAQoRTW9uc3RlckJhdHRsZVR5";
		buffer[1] = "cGUSHAoYTU9OU1RFUl9CQVRUTEVfVFlQRV9OT05FEAASJgoiTU9OU1RFUl9C";
		buffer[2] = "QVRUTEVfVFlQRV9UUklHR0VSX0JBVFRMRRABEjIKLk1PTlNURVJfQkFUVExF";
		buffer[3] = "X1RZUEVfRElSRUNUX0RJRV9TSU1VTEFURV9CQVRUTEUQAhIuCipNT05TVEVS";
		buffer[4] = "X0JBVFRMRV9UWVBFX0RJUkVDVF9ESUVfU0tJUF9CQVRUTEUQAxIhCh1NT05T";
		buffer[5] = "VEVSX0JBVFRMRV9UWVBFX05PX0JBVFRMRRAEQhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[6] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(MonsterBattleType) }, null, null));
	}
}
