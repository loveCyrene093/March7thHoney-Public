using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyCellUpdateNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyCellUpdateNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Nb25vcG9seUNlbGxVcGRhdGVOb3RpZnkucHJvdG8aEUFBSEJFQ0lDT0VO" + "LnByb3RvIj0KGE1vbm9wb2x5Q2VsbFVwZGF0ZU5vdGlmeRIhCgtMSkhET0ZC" + "Rk5KSBgIIAEoCzIMLkFBSEJFQ0lDT0VOQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[1] { AAHBECICOENReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyCellUpdateNotify), MonopolyCellUpdateNotify.Parser, new string[1] { "LJHDOFBFNJH" }, null, null, null, null)
		}));
	}
}
