using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JOEPJJKIPJCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JOEPJJKIPJCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKT0VQSkpLSVBKQy5wcm90bxoRQURITkpBRElKQUMucHJvdG8iQQoLSk9F" + "UEpKS0lQSkMSDwoHcmV0Y29kZRgGIAEoDRIhCgtCSUVCRkhFQ0VQTRgNIAMo" + "CzIMLkFESE5KQURJSkFDQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { ADHNJADIJACReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JOEPJJKIPJC), JOEPJJKIPJC.Parser, new string[2] { "Retcode", "BIEBFHECEPM" }, null, null, null, null)
		}));
	}
}
