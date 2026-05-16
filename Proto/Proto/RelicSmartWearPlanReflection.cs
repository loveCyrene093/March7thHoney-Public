using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicSmartWearPlanReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicSmartWearPlanReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhSZWxpY1NtYXJ0V2VhclBsYW4ucHJvdG8icQoSUmVsaWNTbWFydFdlYXJQ" + "bGFuEhEKCWF2YXRhcl9pZBgHIAEoDRIaChJvdXRzaWRlX3JlbGljX2xpc3QY" + "CSADKA0SGQoRaW5zaWRlX3JlbGljX2xpc3QYDSADKA0SEQoJdW5pcXVlX2lk" + "GA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicSmartWearPlan), RelicSmartWearPlan.Parser, new string[4] { "AvatarId", "OutsideRelicList", "InsideRelicList", "UniqueId" }, null, null, null, null)
		}));
	}
}
