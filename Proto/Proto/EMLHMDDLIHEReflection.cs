using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EMLHMDDLIHEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EMLHMDDLIHEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFTUxITURETElIRS5wcm90bypHCgtFTUxITURETElIRRIbChdFTUxITURE" + "TElIRV9ORk1DSUtQR0xKSxAAEhsKF0VNTEhNRERMSUhFX1BFQk1HT0NFR0ZH" + "EAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(EMLHMDDLIHE) }, null, null));
	}
}
