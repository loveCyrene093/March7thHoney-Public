using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FantasticStoryActivityBattleEndScNotify : IMessage<FantasticStoryActivityBattleEndScNotify>, IMessage, IEquatable<FantasticStoryActivityBattleEndScNotify>, IDeepCloneable<FantasticStoryActivityBattleEndScNotify>, IBufferMessage
{
	private static readonly MessageParser<FantasticStoryActivityBattleEndScNotify> _parser = new MessageParser<FantasticStoryActivityBattleEndScNotify>(() => new FantasticStoryActivityBattleEndScNotify());

	private UnknownFieldSet _unknownFields;

	public const int CEIMNDJFDJDFieldNumber = 2;

	private uint cEIMNDJFDJD_;

	public const int JHGANJGBALIFieldNumber = 3;

	private uint jHGANJGBALI_;

	public const int BattleIdFieldNumber = 7;

	private uint battleId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FantasticStoryActivityBattleEndScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FantasticStoryActivityBattleEndScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CEIMNDJFDJD
	{
		get
		{
			return cEIMNDJFDJD_;
		}
		set
		{
			cEIMNDJFDJD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JHGANJGBALI
	{
		get
		{
			return jHGANJGBALI_;
		}
		set
		{
			jHGANJGBALI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BattleId
	{
		get
		{
			return battleId_;
		}
		set
		{
			battleId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FantasticStoryActivityBattleEndScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FantasticStoryActivityBattleEndScNotify(FantasticStoryActivityBattleEndScNotify other)
		: this()
	{
		cEIMNDJFDJD_ = other.cEIMNDJFDJD_;
		jHGANJGBALI_ = other.jHGANJGBALI_;
		battleId_ = other.battleId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FantasticStoryActivityBattleEndScNotify Clone()
	{
		return new FantasticStoryActivityBattleEndScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FantasticStoryActivityBattleEndScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FantasticStoryActivityBattleEndScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CEIMNDJFDJD != other.CEIMNDJFDJD)
		{
			return false;
		}
		if (JHGANJGBALI != other.JHGANJGBALI)
		{
			return false;
		}
		if (BattleId != other.BattleId)
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
		if (CEIMNDJFDJD != 0)
		{
			num ^= CEIMNDJFDJD.GetHashCode();
		}
		if (JHGANJGBALI != 0)
		{
			num ^= JHGANJGBALI.GetHashCode();
		}
		if (BattleId != 0)
		{
			num ^= BattleId.GetHashCode();
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
		if (CEIMNDJFDJD != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(CEIMNDJFDJD);
		}
		if (JHGANJGBALI != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(JHGANJGBALI);
		}
		if (BattleId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(BattleId);
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
		if (CEIMNDJFDJD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CEIMNDJFDJD);
		}
		if (JHGANJGBALI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JHGANJGBALI);
		}
		if (BattleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BattleId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FantasticStoryActivityBattleEndScNotify other)
	{
		if (other != null)
		{
			if (other.CEIMNDJFDJD != 0)
			{
				CEIMNDJFDJD = other.CEIMNDJFDJD;
			}
			if (other.JHGANJGBALI != 0)
			{
				JHGANJGBALI = other.JHGANJGBALI;
			}
			if (other.BattleId != 0)
			{
				BattleId = other.BattleId;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
				CEIMNDJFDJD = input.ReadUInt32();
				break;
			case 24u:
				JHGANJGBALI = input.ReadUInt32();
				break;
			case 56u:
				BattleId = input.ReadUInt32();
				break;
			}
		}
	}
}
