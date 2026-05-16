using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MainMissionAcceptNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MainMissionAcceptNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1NYWluTWlzc2lvbkFjY2VwdE5vdGlmeS5wcm90byI2ChdNYWluTWlzc2lv" + "bkFjY2VwdE5vdGlmeRIbChNzdWJfbWlzc2lvbl9pZF9saXN0GAwgAygNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MainMissionAcceptNotify), MainMissionAcceptNotify.Parser, new string[1] { "SubMissionIdList" }, null, null, null, null)
		}));
	}
}
