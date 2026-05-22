using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesSkillLevelUpScRsp : IMessage<PlanetFesSkillLevelUpScRsp>, IMessage, IEquatable<PlanetFesSkillLevelUpScRsp>, IDeepCloneable<PlanetFesSkillLevelUpScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesSkillLevelUpScRsp> _parser = new MessageParser<PlanetFesSkillLevelUpScRsp>(() => new PlanetFesSkillLevelUpScRsp());

	private UnknownFieldSet _unknownFields;

	public const int SkillIdFieldNumber = 2;

	private uint skillId_;

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int SkillLevelFieldNumber = 5;

	private uint skillLevel_;

	public const int ItemCostFieldNumber = 9;

	private FBBMDFDOEEF itemCost_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesSkillLevelUpScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesSkillLevelUpScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SkillId
	{
		get
		{
			return skillId_;
		}
		set
		{
			skillId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SkillLevel
	{
		get
		{
			return skillLevel_;
		}
		set
		{
			skillLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FBBMDFDOEEF ItemCost
	{
		get
		{
			return itemCost_;
		}
		set
		{
			itemCost_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesSkillLevelUpScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesSkillLevelUpScRsp(PlanetFesSkillLevelUpScRsp other)
		: this()
	{
		skillId_ = other.skillId_;
		retcode_ = other.retcode_;
		skillLevel_ = other.skillLevel_;
		itemCost_ = ((other.itemCost_ != null) ? other.itemCost_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesSkillLevelUpScRsp Clone()
	{
		return new PlanetFesSkillLevelUpScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesSkillLevelUpScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesSkillLevelUpScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SkillId != other.SkillId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (SkillLevel != other.SkillLevel)
		{
			return false;
		}
		if (!object.Equals(ItemCost, other.ItemCost))
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
		if (SkillId != 0)
		{
			num ^= SkillId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (SkillLevel != 0)
		{
			num ^= SkillLevel.GetHashCode();
		}
		if (itemCost_ != null)
		{
			num ^= ItemCost.GetHashCode();
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
		if (SkillId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(SkillId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		if (SkillLevel != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(SkillLevel);
		}
		if (itemCost_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(ItemCost);
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
		if (SkillId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SkillId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (SkillLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SkillLevel);
		}
		if (itemCost_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ItemCost);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesSkillLevelUpScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.SkillId != 0)
		{
			SkillId = other.SkillId;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.SkillLevel != 0)
		{
			SkillLevel = other.SkillLevel;
		}
		if (other.itemCost_ != null)
		{
			if (itemCost_ == null)
			{
				ItemCost = new FBBMDFDOEEF();
			}
			ItemCost.MergeFrom(other.ItemCost);
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
				SkillId = input.ReadUInt32();
				break;
			case 24u:
				Retcode = input.ReadUInt32();
				break;
			case 40u:
				SkillLevel = input.ReadUInt32();
				break;
			case 74u:
				if (itemCost_ == null)
				{
					ItemCost = new FBBMDFDOEEF();
				}
				input.ReadMessage(ItemCost);
				break;
			}
		}
	}
}
