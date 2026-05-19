using March7thHoney.Proto;

namespace March7thHoney.GameServer.Game.Mail;

public record TakeMailAttachmentFailInfo(uint MailId, Retcode Retcode);
