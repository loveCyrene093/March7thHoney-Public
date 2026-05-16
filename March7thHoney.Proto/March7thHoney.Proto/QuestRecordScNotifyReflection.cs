using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class QuestRecordScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static QuestRecordScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlRdWVzdFJlY29yZFNjTm90aWZ5LnByb3RvGhFKT0hQR0VER0pBRC5wcm90" + "byI4ChNRdWVzdFJlY29yZFNjTm90aWZ5EiEKC01PSEpESEtLSUdCGAIgASgL" + "MgwuSk9IUEdFREdKQURCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[1] { JOHPGEDGJADReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(QuestRecordScNotify), QuestRecordScNotify.Parser, new string[1] { "MOHJDHKKIGB" }, null, null, null, null)
		}));
	}
}
