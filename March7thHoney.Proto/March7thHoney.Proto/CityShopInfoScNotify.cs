using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CityShopInfoScNotify : IMessage<CityShopInfoScNotify>, IMessage, IEquatable<CityShopInfoScNotify>, IDeepCloneable<CityShopInfoScNotify>, IBufferMessage
{
	private static readonly MessageParser<CityShopInfoScNotify> _parser = new MessageParser<CityShopInfoScNotify>(() => new CityShopInfoScNotify());

	private UnknownFieldSet _unknownFields;

	public const int TakenLevelRewardFieldNumber = 4;

	private ulong takenLevelReward_;

	public const int ExpFieldNumber = 7;

	private uint exp_;

	public const int LevelFieldNumber = 9;

	private uint level_;

	public const int ShopIdFieldNumber = 11;

	private uint shopId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CityShopInfoScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CityShopInfoScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong TakenLevelReward
	{
		get
		{
			return takenLevelReward_;
		}
		set
		{
			takenLevelReward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Exp
	{
		get
		{
			return exp_;
		}
		set
		{
			exp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ShopId
	{
		get
		{
			return shopId_;
		}
		set
		{
			shopId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CityShopInfoScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CityShopInfoScNotify(CityShopInfoScNotify other)
		: this()
	{
		takenLevelReward_ = other.takenLevelReward_;
		exp_ = other.exp_;
		level_ = other.level_;
		shopId_ = other.shopId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CityShopInfoScNotify Clone()
	{
		return new CityShopInfoScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CityShopInfoScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CityShopInfoScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TakenLevelReward != other.TakenLevelReward)
		{
			return false;
		}
		if (Exp != other.Exp)
		{
			return false;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (ShopId != other.ShopId)
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
		if (TakenLevelReward != 0L)
		{
			num ^= TakenLevelReward.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (ShopId != 0)
		{
			num ^= ShopId.GetHashCode();
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
		if (TakenLevelReward != 0L)
		{
			output.WriteRawTag(32);
			output.WriteUInt64(TakenLevelReward);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Exp);
		}
		if (Level != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Level);
		}
		if (ShopId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(ShopId);
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
		if (TakenLevelReward != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(TakenLevelReward);
		}
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (ShopId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ShopId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CityShopInfoScNotify other)
	{
		if (other != null)
		{
			if (other.TakenLevelReward != 0L)
			{
				TakenLevelReward = other.TakenLevelReward;
			}
			if (other.Exp != 0)
			{
				Exp = other.Exp;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.ShopId != 0)
			{
				ShopId = other.ShopId;
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
			case 32u:
				TakenLevelReward = input.ReadUInt64();
				break;
			case 56u:
				Exp = input.ReadUInt32();
				break;
			case 72u:
				Level = input.ReadUInt32();
				break;
			case 88u:
				ShopId = input.ReadUInt32();
				break;
			}
		}
	}
}
