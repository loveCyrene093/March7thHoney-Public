using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TarotBookModifyEnergyScNotify : IMessage<TarotBookModifyEnergyScNotify>, IMessage, IEquatable<TarotBookModifyEnergyScNotify>, IDeepCloneable<TarotBookModifyEnergyScNotify>, IBufferMessage
{
	private static readonly MessageParser<TarotBookModifyEnergyScNotify> _parser = new MessageParser<TarotBookModifyEnergyScNotify>(() => new TarotBookModifyEnergyScNotify());

	private UnknownFieldSet _unknownFields;

	public const int SubMissionIdFieldNumber = 7;

	private uint subMissionId_;

	public const int EnergyInfoFieldNumber = 8;

	private uint energyInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TarotBookModifyEnergyScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TarotBookModifyEnergyScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SubMissionId
	{
		get
		{
			return subMissionId_;
		}
		set
		{
			subMissionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EnergyInfo
	{
		get
		{
			return energyInfo_;
		}
		set
		{
			energyInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookModifyEnergyScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookModifyEnergyScNotify(TarotBookModifyEnergyScNotify other)
		: this()
	{
		subMissionId_ = other.subMissionId_;
		energyInfo_ = other.energyInfo_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TarotBookModifyEnergyScNotify Clone()
	{
		return new TarotBookModifyEnergyScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TarotBookModifyEnergyScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TarotBookModifyEnergyScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SubMissionId != other.SubMissionId)
		{
			return false;
		}
		if (EnergyInfo != other.EnergyInfo)
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
		if (SubMissionId != 0)
		{
			num ^= SubMissionId.GetHashCode();
		}
		if (EnergyInfo != 0)
		{
			num ^= EnergyInfo.GetHashCode();
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
		if (SubMissionId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(SubMissionId);
		}
		if (EnergyInfo != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(EnergyInfo);
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
		if (SubMissionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SubMissionId);
		}
		if (EnergyInfo != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EnergyInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TarotBookModifyEnergyScNotify other)
	{
		if (other != null)
		{
			if (other.SubMissionId != 0)
			{
				SubMissionId = other.SubMissionId;
			}
			if (other.EnergyInfo != 0)
			{
				EnergyInfo = other.EnergyInfo;
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
			case 56u:
				SubMissionId = input.ReadUInt32();
				break;
			case 64u:
				EnergyInfo = input.ReadUInt32();
				break;
			}
		}
	}
}
