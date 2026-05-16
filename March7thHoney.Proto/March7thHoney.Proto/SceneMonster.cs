using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneMonster : IMessage<SceneMonster>, IMessage, IEquatable<SceneMonster>, IDeepCloneable<SceneMonster>, IBufferMessage
{
	private static readonly MessageParser<SceneMonster> _parser = new MessageParser<SceneMonster>(() => new SceneMonster());

	private UnknownFieldSet _unknownFields;

	public const int MaxHpFieldNumber = 7;

	private uint maxHp_;

	public const int ExtraInfoFieldNumber = 8;

	private MEHAOMGBOMC extraInfo_;

	public const int CurHpFieldNumber = 11;

	private uint curHp_;

	public const int MonsterIdFieldNumber = 15;

	private uint monsterId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneMonster> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneMonsterReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MaxHp
	{
		get
		{
			return maxHp_;
		}
		set
		{
			maxHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MEHAOMGBOMC ExtraInfo
	{
		get
		{
			return extraInfo_;
		}
		set
		{
			extraInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurHp
	{
		get
		{
			return curHp_;
		}
		set
		{
			curHp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MonsterId
	{
		get
		{
			return monsterId_;
		}
		set
		{
			monsterId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneMonster()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneMonster(SceneMonster other)
		: this()
	{
		maxHp_ = other.maxHp_;
		extraInfo_ = ((other.extraInfo_ != null) ? other.extraInfo_.Clone() : null);
		curHp_ = other.curHp_;
		monsterId_ = other.monsterId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneMonster Clone()
	{
		return new SceneMonster(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneMonster);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneMonster other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MaxHp != other.MaxHp)
		{
			return false;
		}
		if (!object.Equals(ExtraInfo, other.ExtraInfo))
		{
			return false;
		}
		if (CurHp != other.CurHp)
		{
			return false;
		}
		if (MonsterId != other.MonsterId)
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
		if (MaxHp != 0)
		{
			num ^= MaxHp.GetHashCode();
		}
		if (extraInfo_ != null)
		{
			num ^= ExtraInfo.GetHashCode();
		}
		if (CurHp != 0)
		{
			num ^= CurHp.GetHashCode();
		}
		if (MonsterId != 0)
		{
			num ^= MonsterId.GetHashCode();
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
		if (MaxHp != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(MaxHp);
		}
		if (extraInfo_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(ExtraInfo);
		}
		if (CurHp != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(CurHp);
		}
		if (MonsterId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(MonsterId);
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
		if (MaxHp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MaxHp);
		}
		if (extraInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ExtraInfo);
		}
		if (CurHp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurHp);
		}
		if (MonsterId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MonsterId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SceneMonster other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MaxHp != 0)
		{
			MaxHp = other.MaxHp;
		}
		if (other.extraInfo_ != null)
		{
			if (extraInfo_ == null)
			{
				ExtraInfo = new MEHAOMGBOMC();
			}
			ExtraInfo.MergeFrom(other.ExtraInfo);
		}
		if (other.CurHp != 0)
		{
			CurHp = other.CurHp;
		}
		if (other.MonsterId != 0)
		{
			MonsterId = other.MonsterId;
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
			case 56u:
				MaxHp = input.ReadUInt32();
				break;
			case 66u:
				if (extraInfo_ == null)
				{
					ExtraInfo = new MEHAOMGBOMC();
				}
				input.ReadMessage(ExtraInfo);
				break;
			case 88u:
				CurHp = input.ReadUInt32();
				break;
			case 120u:
				MonsterId = input.ReadUInt32();
				break;
			}
		}
	}
}
