using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CakeRaceCoinScoreChangeScNotify : IMessage<CakeRaceCoinScoreChangeScNotify>, IMessage, IEquatable<CakeRaceCoinScoreChangeScNotify>, IDeepCloneable<CakeRaceCoinScoreChangeScNotify>, IBufferMessage
{
	private static readonly MessageParser<CakeRaceCoinScoreChangeScNotify> _parser = new MessageParser<CakeRaceCoinScoreChangeScNotify>(() => new CakeRaceCoinScoreChangeScNotify());

	private UnknownFieldSet _unknownFields;

	public const int ScoreIdFieldNumber = 1;

	private uint scoreId_;

	public const int ItemValueFieldNumber = 5;

	private uint itemValue_;

	public const int LCHDAPELPGOFieldNumber = 9;

	private uint lCHDAPELPGO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CakeRaceCoinScoreChangeScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CakeRaceCoinScoreChangeScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScoreId
	{
		get
		{
			return scoreId_;
		}
		set
		{
			scoreId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemValue
	{
		get
		{
			return itemValue_;
		}
		set
		{
			itemValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LCHDAPELPGO
	{
		get
		{
			return lCHDAPELPGO_;
		}
		set
		{
			lCHDAPELPGO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CakeRaceCoinScoreChangeScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CakeRaceCoinScoreChangeScNotify(CakeRaceCoinScoreChangeScNotify other)
		: this()
	{
		scoreId_ = other.scoreId_;
		itemValue_ = other.itemValue_;
		lCHDAPELPGO_ = other.lCHDAPELPGO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CakeRaceCoinScoreChangeScNotify Clone()
	{
		return new CakeRaceCoinScoreChangeScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CakeRaceCoinScoreChangeScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CakeRaceCoinScoreChangeScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (ItemValue != other.ItemValue)
		{
			return false;
		}
		if (LCHDAPELPGO != other.LCHDAPELPGO)
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
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (ItemValue != 0)
		{
			num ^= ItemValue.GetHashCode();
		}
		if (LCHDAPELPGO != 0)
		{
			num ^= LCHDAPELPGO.GetHashCode();
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
		if (ScoreId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(ScoreId);
		}
		if (ItemValue != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(ItemValue);
		}
		if (LCHDAPELPGO != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(LCHDAPELPGO);
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
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (ItemValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemValue);
		}
		if (LCHDAPELPGO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LCHDAPELPGO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CakeRaceCoinScoreChangeScNotify other)
	{
		if (other != null)
		{
			if (other.ScoreId != 0)
			{
				ScoreId = other.ScoreId;
			}
			if (other.ItemValue != 0)
			{
				ItemValue = other.ItemValue;
			}
			if (other.LCHDAPELPGO != 0)
			{
				LCHDAPELPGO = other.LCHDAPELPGO;
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
			case 8u:
				ScoreId = input.ReadUInt32();
				break;
			case 40u:
				ItemValue = input.ReadUInt32();
				break;
			case 72u:
				LCHDAPELPGO = input.ReadUInt32();
				break;
			}
		}
	}
}
