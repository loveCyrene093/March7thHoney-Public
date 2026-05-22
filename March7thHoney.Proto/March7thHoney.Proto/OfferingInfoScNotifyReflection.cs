using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OfferingInfoScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OfferingInfoScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpPZmZlcmluZ0luZm9TY05vdGlmeS5wcm90bxoST2ZmZXJpbmdJbmZvLnBy" + "b3RvIjwKFE9mZmVyaW5nSW5mb1NjTm90aWZ5EiQKDW9mZmVyaW5nX2luZm8Y" + "ByABKAsyDS5PZmZlcmluZ0luZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[1] { OfferingInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OfferingInfoScNotify), OfferingInfoScNotify.Parser, new string[1] { "OfferingInfo" }, null, null, null, null)
		}));
	}
}
