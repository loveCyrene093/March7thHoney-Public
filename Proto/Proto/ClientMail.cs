using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ClientMail : IMessage<ClientMail>, IMessage, IEquatable<ClientMail>, IDeepCloneable<ClientMail>, IBufferMessage
{
	private static readonly MessageParser<ClientMail> _parser = new MessageParser<ClientMail>(() => new ClientMail());

	private UnknownFieldSet _unknownFields;

	public const int TimeFieldNumber = 1;

	private long time_;

	public const int IdFieldNumber = 2;

	private uint id_;

	public const int IsReadFieldNumber = 3;

	private bool isRead_;

	public const int ContentFieldNumber = 4;

	private string content_ = "";

	public const int ParaListFieldNumber = 6;

	private static readonly FieldCodec<string> _repeated_paraList_codec = FieldCodec.ForString(50u);

	private readonly RepeatedField<string> paraList_ = new RepeatedField<string>();

	public const int ExpireTimeFieldNumber = 7;

	private long expireTime_;

	public const int MailTypeFieldNumber = 9;

	private MailType mailType_;

	public const int TemplateIdFieldNumber = 10;

	private uint templateId_;

	public const int SenderFieldNumber = 11;

	private string sender_ = "";

	public const int TitleFieldNumber = 12;

	private string title_ = "";

	public const int AttachmentFieldNumber = 15;

	private ItemList attachment_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ClientMail> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ClientMailReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Time
	{
		get
		{
			return time_;
		}
		set
		{
			time_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsRead
	{
		get
		{
			return isRead_;
		}
		set
		{
			isRead_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Content
	{
		get
		{
			return content_;
		}
		set
		{
			content_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> ParaList => paraList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long ExpireTime
	{
		get
		{
			return expireTime_;
		}
		set
		{
			expireTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MailType MailType
	{
		get
		{
			return mailType_;
		}
		set
		{
			mailType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TemplateId
	{
		get
		{
			return templateId_;
		}
		set
		{
			templateId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Sender
	{
		get
		{
			return sender_;
		}
		set
		{
			sender_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Title
	{
		get
		{
			return title_;
		}
		set
		{
			title_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList Attachment
	{
		get
		{
			return attachment_;
		}
		set
		{
			attachment_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClientMail()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClientMail(ClientMail other)
		: this()
	{
		time_ = other.time_;
		id_ = other.id_;
		isRead_ = other.isRead_;
		content_ = other.content_;
		paraList_ = other.paraList_.Clone();
		expireTime_ = other.expireTime_;
		mailType_ = other.mailType_;
		templateId_ = other.templateId_;
		sender_ = other.sender_;
		title_ = other.title_;
		attachment_ = ((other.attachment_ != null) ? other.attachment_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClientMail Clone()
	{
		return new ClientMail(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ClientMail);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ClientMail other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Time != other.Time)
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (IsRead != other.IsRead)
		{
			return false;
		}
		if (Content != other.Content)
		{
			return false;
		}
		if (!paraList_.Equals(other.paraList_))
		{
			return false;
		}
		if (ExpireTime != other.ExpireTime)
		{
			return false;
		}
		if (MailType != other.MailType)
		{
			return false;
		}
		if (TemplateId != other.TemplateId)
		{
			return false;
		}
		if (Sender != other.Sender)
		{
			return false;
		}
		if (Title != other.Title)
		{
			return false;
		}
		if (!object.Equals(Attachment, other.Attachment))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (Time != 0L)
		{
			num ^= Time.GetHashCode();
		}
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (IsRead)
		{
			num ^= IsRead.GetHashCode();
		}
		if (Content.Length != 0)
		{
			num ^= Content.GetHashCode();
		}
		num ^= paraList_.GetHashCode();
		if (ExpireTime != 0L)
		{
			num ^= ExpireTime.GetHashCode();
		}
		if (MailType != MailType.Normal)
		{
			num ^= MailType.GetHashCode();
		}
		if (TemplateId != 0)
		{
			num ^= TemplateId.GetHashCode();
		}
		if (Sender.Length != 0)
		{
			num ^= Sender.GetHashCode();
		}
		if (Title.Length != 0)
		{
			num ^= Title.GetHashCode();
		}
		if (attachment_ != null)
		{
			num ^= Attachment.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Time != 0L)
		{
			output.WriteRawTag(8);
			output.WriteInt64(Time);
		}
		if (Id != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Id);
		}
		if (IsRead)
		{
			output.WriteRawTag(24);
			output.WriteBool(IsRead);
		}
		if (Content.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(Content);
		}
		paraList_.WriteTo(ref output, _repeated_paraList_codec);
		if (ExpireTime != 0L)
		{
			output.WriteRawTag(56);
			output.WriteInt64(ExpireTime);
		}
		if (MailType != MailType.Normal)
		{
			output.WriteRawTag(72);
			output.WriteEnum((int)MailType);
		}
		if (TemplateId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(TemplateId);
		}
		if (Sender.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(Sender);
		}
		if (Title.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(Title);
		}
		if (attachment_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(Attachment);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (Time != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(Time);
		}
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (IsRead)
		{
			num += 2;
		}
		if (Content.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Content);
		}
		num += paraList_.CalculateSize(_repeated_paraList_codec);
		if (ExpireTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(ExpireTime);
		}
		if (MailType != MailType.Normal)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MailType);
		}
		if (TemplateId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TemplateId);
		}
		if (Sender.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Sender);
		}
		if (Title.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Title);
		}
		if (attachment_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Attachment);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ClientMail other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Time != 0L)
		{
			Time = other.Time;
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.IsRead)
		{
			IsRead = other.IsRead;
		}
		if (other.Content.Length != 0)
		{
			Content = other.Content;
		}
		paraList_.Add(other.paraList_);
		if (other.ExpireTime != 0L)
		{
			ExpireTime = other.ExpireTime;
		}
		if (other.MailType != MailType.Normal)
		{
			MailType = other.MailType;
		}
		if (other.TemplateId != 0)
		{
			TemplateId = other.TemplateId;
		}
		if (other.Sender.Length != 0)
		{
			Sender = other.Sender;
		}
		if (other.Title.Length != 0)
		{
			Title = other.Title;
		}
		if (other.attachment_ != null)
		{
			if (attachment_ == null)
			{
				Attachment = new ItemList();
			}
			Attachment.MergeFrom(other.Attachment);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				Time = input.ReadInt64();
				break;
			case 16u:
				Id = input.ReadUInt32();
				break;
			case 24u:
				IsRead = input.ReadBool();
				break;
			case 34u:
				Content = input.ReadString();
				break;
			case 50u:
				paraList_.AddEntriesFrom(ref input, _repeated_paraList_codec);
				break;
			case 56u:
				ExpireTime = input.ReadInt64();
				break;
			case 72u:
				MailType = (MailType)input.ReadEnum();
				break;
			case 80u:
				TemplateId = input.ReadUInt32();
				break;
			case 90u:
				Sender = input.ReadString();
				break;
			case 98u:
				Title = input.ReadString();
				break;
			case 122u:
				if (attachment_ == null)
				{
					Attachment = new ItemList();
				}
				input.ReadMessage(Attachment);
				break;
			}
		}
	}
}
