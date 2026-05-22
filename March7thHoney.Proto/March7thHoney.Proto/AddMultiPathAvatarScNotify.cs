using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AddMultiPathAvatarScNotify : IMessage<AddMultiPathAvatarScNotify>, IMessage, IEquatable<AddMultiPathAvatarScNotify>, IDeepCloneable<AddMultiPathAvatarScNotify>, IBufferMessage
{
	private static readonly MessageParser<AddMultiPathAvatarScNotify> _parser = new MessageParser<AddMultiPathAvatarScNotify>(() => new AddMultiPathAvatarScNotify());

	private UnknownFieldSet _unknownFields;

	public const int LANGJOJLEOCFieldNumber = 2;

	private PJNEFBBLPND lANGJOJLEOC_;

	public const int IsNewFieldNumber = 4;

	private bool isNew_;

	public const int OIOFPADOGFCFieldNumber = 10;

	private static readonly FieldCodec<DPBEGBNICPG> _repeated_oIOFPADOGFC_codec = FieldCodec.ForMessage(82u, DPBEGBNICPG.Parser);

	private readonly RepeatedField<DPBEGBNICPG> oIOFPADOGFC_ = new RepeatedField<DPBEGBNICPG>();

	public const int AvatarIdFieldNumber = 12;

	private uint avatarId_;

	public const int RewardFieldNumber = 14;

	private ItemList reward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AddMultiPathAvatarScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AddMultiPathAvatarScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PJNEFBBLPND LANGJOJLEOC
	{
		get
		{
			return lANGJOJLEOC_;
		}
		set
		{
			lANGJOJLEOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsNew
	{
		get
		{
			return isNew_;
		}
		set
		{
			isNew_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DPBEGBNICPG> OIOFPADOGFC => oIOFPADOGFC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarId
	{
		get
		{
			return avatarId_;
		}
		set
		{
			avatarId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList Reward
	{
		get
		{
			return reward_;
		}
		set
		{
			reward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AddMultiPathAvatarScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AddMultiPathAvatarScNotify(AddMultiPathAvatarScNotify other)
		: this()
	{
		lANGJOJLEOC_ = other.lANGJOJLEOC_;
		isNew_ = other.isNew_;
		oIOFPADOGFC_ = other.oIOFPADOGFC_.Clone();
		avatarId_ = other.avatarId_;
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AddMultiPathAvatarScNotify Clone()
	{
		return new AddMultiPathAvatarScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AddMultiPathAvatarScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AddMultiPathAvatarScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LANGJOJLEOC != other.LANGJOJLEOC)
		{
			return false;
		}
		if (IsNew != other.IsNew)
		{
			return false;
		}
		if (!oIOFPADOGFC_.Equals(other.oIOFPADOGFC_))
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (!object.Equals(Reward, other.Reward))
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
		if (LANGJOJLEOC != PJNEFBBLPND.Pcpdhelpkem)
		{
			num ^= LANGJOJLEOC.GetHashCode();
		}
		if (IsNew)
		{
			num ^= IsNew.GetHashCode();
		}
		num ^= oIOFPADOGFC_.GetHashCode();
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
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
		if (LANGJOJLEOC != PJNEFBBLPND.Pcpdhelpkem)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)LANGJOJLEOC);
		}
		if (IsNew)
		{
			output.WriteRawTag(32);
			output.WriteBool(IsNew);
		}
		oIOFPADOGFC_.WriteTo(ref output, _repeated_oIOFPADOGFC_codec);
		if (AvatarId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(AvatarId);
		}
		if (reward_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(Reward);
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
		if (LANGJOJLEOC != PJNEFBBLPND.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)LANGJOJLEOC);
		}
		if (IsNew)
		{
			num += 2;
		}
		num += oIOFPADOGFC_.CalculateSize(_repeated_oIOFPADOGFC_codec);
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AddMultiPathAvatarScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.LANGJOJLEOC != PJNEFBBLPND.Pcpdhelpkem)
		{
			LANGJOJLEOC = other.LANGJOJLEOC;
		}
		if (other.IsNew)
		{
			IsNew = other.IsNew;
		}
		oIOFPADOGFC_.Add(other.oIOFPADOGFC_);
		if (other.AvatarId != 0)
		{
			AvatarId = other.AvatarId;
		}
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new ItemList();
			}
			Reward.MergeFrom(other.Reward);
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
			case 16u:
				LANGJOJLEOC = (PJNEFBBLPND)input.ReadEnum();
				break;
			case 32u:
				IsNew = input.ReadBool();
				break;
			case 82u:
				oIOFPADOGFC_.AddEntriesFrom(ref input, _repeated_oIOFPADOGFC_codec);
				break;
			case 96u:
				AvatarId = input.ReadUInt32();
				break;
			case 114u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			}
		}
	}
}
