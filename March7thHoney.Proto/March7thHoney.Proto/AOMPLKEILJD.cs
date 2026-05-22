using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AOMPLKEILJD : IMessage<AOMPLKEILJD>, IMessage, IEquatable<AOMPLKEILJD>, IDeepCloneable<AOMPLKEILJD>, IBufferMessage
{
	private static readonly MessageParser<AOMPLKEILJD> _parser = new MessageParser<AOMPLKEILJD>(() => new AOMPLKEILJD());

	private UnknownFieldSet _unknownFields;

	public const int MHEPBNFJDIBFieldNumber = 1;

	private uint mHEPBNFJDIB_;

	public const int AvatarIdFieldNumber = 3;

	private uint avatarId_;

	public const int SpBarFieldNumber = 11;

	private SpBarInfo spBar_;

	public const int HpFieldNumber = 12;

	private uint hp_;

	public const int AvatarTypeFieldNumber = 14;

	private uint avatarType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AOMPLKEILJD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AOMPLKEILJDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MHEPBNFJDIB
	{
		get
		{
			return mHEPBNFJDIB_;
		}
		set
		{
			mHEPBNFJDIB_ = value;
		}
	}

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
	public SpBarInfo SpBar
	{
		get
		{
			return spBar_;
		}
		set
		{
			spBar_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Hp
	{
		get
		{
			return hp_;
		}
		set
		{
			hp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AvatarType
	{
		get
		{
			return avatarType_;
		}
		set
		{
			avatarType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOMPLKEILJD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOMPLKEILJD(AOMPLKEILJD other)
		: this()
	{
		mHEPBNFJDIB_ = other.mHEPBNFJDIB_;
		avatarId_ = other.avatarId_;
		spBar_ = ((other.spBar_ != null) ? other.spBar_.Clone() : null);
		hp_ = other.hp_;
		avatarType_ = other.avatarType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AOMPLKEILJD Clone()
	{
		return new AOMPLKEILJD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AOMPLKEILJD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AOMPLKEILJD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MHEPBNFJDIB != other.MHEPBNFJDIB)
		{
			return false;
		}
		if (AvatarId != other.AvatarId)
		{
			return false;
		}
		if (!object.Equals(SpBar, other.SpBar))
		{
			return false;
		}
		if (Hp != other.Hp)
		{
			return false;
		}
		if (AvatarType != other.AvatarType)
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
		if (MHEPBNFJDIB != 0)
		{
			num ^= MHEPBNFJDIB.GetHashCode();
		}
		if (AvatarId != 0)
		{
			num ^= AvatarId.GetHashCode();
		}
		if (spBar_ != null)
		{
			num ^= SpBar.GetHashCode();
		}
		if (Hp != 0)
		{
			num ^= Hp.GetHashCode();
		}
		if (AvatarType != 0)
		{
			num ^= AvatarType.GetHashCode();
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
		if (MHEPBNFJDIB != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(MHEPBNFJDIB);
		}
		if (AvatarId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(AvatarId);
		}
		if (spBar_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(SpBar);
		}
		if (Hp != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Hp);
		}
		if (AvatarType != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(AvatarType);
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
		if (MHEPBNFJDIB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MHEPBNFJDIB);
		}
		if (AvatarId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarId);
		}
		if (spBar_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(SpBar);
		}
		if (Hp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Hp);
		}
		if (AvatarType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AvatarType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AOMPLKEILJD other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MHEPBNFJDIB != 0)
		{
			MHEPBNFJDIB = other.MHEPBNFJDIB;
		}
		if (other.AvatarId != 0)
		{
			AvatarId = other.AvatarId;
		}
		if (other.spBar_ != null)
		{
			if (spBar_ == null)
			{
				SpBar = new SpBarInfo();
			}
			SpBar.MergeFrom(other.SpBar);
		}
		if (other.Hp != 0)
		{
			Hp = other.Hp;
		}
		if (other.AvatarType != 0)
		{
			AvatarType = other.AvatarType;
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
				MHEPBNFJDIB = input.ReadUInt32();
				break;
			case 24u:
				AvatarId = input.ReadUInt32();
				break;
			case 90u:
				if (spBar_ == null)
				{
					SpBar = new SpBarInfo();
				}
				input.ReadMessage(SpBar);
				break;
			case 96u:
				Hp = input.ReadUInt32();
				break;
			case 112u:
				AvatarType = input.ReadUInt32();
				break;
			}
		}
	}
}
