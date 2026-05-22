using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OCLEJLEFBFOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OCLEJLEFBFOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPQ0xFSkxFRkJGTy5wcm90bypHCgtPQ0xFSkxFRkJGTxIbChdPQ0xFSkxF" + "RkJGT19QQ1BESEVMUEtFTRAAEhsKF09DTEVKTEVGQkZPX0ZGT0tKT0lFQ0pG" + "EAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(OCLEJLEFBFO) }, null, null));
	}
}
