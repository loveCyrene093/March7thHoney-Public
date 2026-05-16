using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BlackLimitLevelReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BlackLimitLevelReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVCbGFja0xpbWl0TGV2ZWwucHJvdG8qLAoPQmxhY2tMaW1pdExldmVsEhkK" + "FUJMQUNLX0xJTUlUX0xFVkVMX0FMTBAAQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(BlackLimitLevel) }, null, null));
	}
}
