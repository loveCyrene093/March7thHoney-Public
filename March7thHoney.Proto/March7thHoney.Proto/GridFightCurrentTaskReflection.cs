using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightCurrentTaskReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightCurrentTaskReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHcmlkRmlnaHRDdXJyZW50VGFzay5wcm90byI5ChRHcmlkRmlnaHRDdXJy" + "ZW50VGFzaxIQCghwcm9ncmVzcxgGIAEoDRIPCgd0YXNrX2lkGAkgASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightCurrentTask), GridFightCurrentTask.Parser, new string[2] { "Progress", "TaskId" }, null, null, null, null)
		}));
	}
}
