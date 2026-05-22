using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LoginActivityDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LoginActivityDataReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdMb2dpbkFjdGl2aXR5RGF0YS5wcm90byJaChFMb2dpbkFjdGl2aXR5RGF0" + "YRITCgtFS05DUEhER0JNThgHIAMoDRIKCgJpZBgMIAEoDRIQCghwYW5lbF9p" + "ZBgOIAEoDRISCgpsb2dpbl9kYXlzGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LoginActivityData), LoginActivityData.Parser, new string[4] { "EKNCPHDGBMN", "Id", "PanelId", "LoginDays" }, null, null, null, null)
		}));
	}
}
