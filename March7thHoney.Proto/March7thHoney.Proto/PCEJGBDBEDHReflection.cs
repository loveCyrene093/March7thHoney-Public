using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PCEJGBDBEDHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PCEJGBDBEDHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQQ0VKR0JEQkVESC5wcm90byJRCgtQQ0VKR0JEQkVESBITCgtLR0tGQURE" + "RUdOShgEIAEoDRIcChRkcmVzc19yb2xlX3VuaXF1ZV9pZBgGIAEoDRIPCgdy" + "b2xlX2lkGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PCEJGBDBEDH), PCEJGBDBEDH.Parser, new string[3] { "KGKFADDEGNJ", "DressRoleUniqueId", "RoleId" }, null, null, null, null)
		}));
	}
}
