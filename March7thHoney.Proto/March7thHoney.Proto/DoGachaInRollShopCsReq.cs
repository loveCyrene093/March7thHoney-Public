using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DoGachaInRollShopCsReq : IMessage<DoGachaInRollShopCsReq>, IMessage, IEquatable<DoGachaInRollShopCsReq>, IDeepCloneable<DoGachaInRollShopCsReq>, IBufferMessage
{
	private static readonly MessageParser<DoGachaInRollShopCsReq> _parser = new MessageParser<DoGachaInRollShopCsReq>(() => new DoGachaInRollShopCsReq());

	private UnknownFieldSet _unknownFields;

	public const int GachaCountFieldNumber = 6;

	private uint gachaCount_;

	public const int GachaRandomFieldNumber = 7;

	private uint gachaRandom_;

	public const int RollShopIdFieldNumber = 9;

	private uint rollShopId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DoGachaInRollShopCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DoGachaInRollShopCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GachaCount
	{
		get
		{
			return gachaCount_;
		}
		set
		{
			gachaCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GachaRandom
	{
		get
		{
			return gachaRandom_;
		}
		set
		{
			gachaRandom_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RollShopId
	{
		get
		{
			return rollShopId_;
		}
		set
		{
			rollShopId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DoGachaInRollShopCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DoGachaInRollShopCsReq(DoGachaInRollShopCsReq other)
		: this()
	{
		gachaCount_ = other.gachaCount_;
		gachaRandom_ = other.gachaRandom_;
		rollShopId_ = other.rollShopId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DoGachaInRollShopCsReq Clone()
	{
		return new DoGachaInRollShopCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DoGachaInRollShopCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DoGachaInRollShopCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GachaCount != other.GachaCount)
		{
			return false;
		}
		if (GachaRandom != other.GachaRandom)
		{
			return false;
		}
		if (RollShopId != other.RollShopId)
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
		if (GachaCount != 0)
		{
			num ^= GachaCount.GetHashCode();
		}
		if (GachaRandom != 0)
		{
			num ^= GachaRandom.GetHashCode();
		}
		if (RollShopId != 0)
		{
			num ^= RollShopId.GetHashCode();
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
		if (GachaCount != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(GachaCount);
		}
		if (GachaRandom != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(GachaRandom);
		}
		if (RollShopId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(RollShopId);
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
		if (GachaCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GachaCount);
		}
		if (GachaRandom != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GachaRandom);
		}
		if (RollShopId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RollShopId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DoGachaInRollShopCsReq other)
	{
		if (other != null)
		{
			if (other.GachaCount != 0)
			{
				GachaCount = other.GachaCount;
			}
			if (other.GachaRandom != 0)
			{
				GachaRandom = other.GachaRandom;
			}
			if (other.RollShopId != 0)
			{
				RollShopId = other.RollShopId;
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
			case 48u:
				GachaCount = input.ReadUInt32();
				break;
			case 56u:
				GachaRandom = input.ReadUInt32();
				break;
			case 72u:
				RollShopId = input.ReadUInt32();
				break;
			}
		}
	}
}
