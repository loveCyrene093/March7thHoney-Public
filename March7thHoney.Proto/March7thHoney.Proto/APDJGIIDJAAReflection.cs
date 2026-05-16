using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class APDJGIIDJAAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static APDJGIIDJAAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBUERKR0lJREpBQS5wcm90bxoRQUZISUhNS0NQTkYucHJvdG8iSwoLQVBE" + "SkdJSURKQUESEwoLQUFBR0JLRUhLTEMYASABKA0SJwoRa2lsbF9tb25zdGVy" + "X2xpc3QYAiADKAsyDC5BRkhJSE1LQ1BORkIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[1] { AFHIHMKCPNFReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(APDJGIIDJAA), APDJGIIDJAA.Parser, new string[2] { "AAAGBKEHKLC", "KillMonsterList" }, null, null, null, null)
		}));
	}
}
