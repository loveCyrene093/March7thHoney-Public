using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HOIKCKDHPGCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HOIKCKDHPGCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIT0lLQ0tESFBHQy5wcm90byJKCgtIT0lLQ0tESFBHQxITCgtOUEJLTENI" + "TEpNRxgCIAEoDRITCgtPTlBLRkRLQURMQRgHIAEoDRIRCglhdmF0YXJfaWQY" + "DSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HOIKCKDHPGC), HOIKCKDHPGC.Parser, new string[3] { "NPBKLCHLJMG", "ONPKFDKADLA", "AvatarId" }, null, null, null, null)
		}));
	}
}
