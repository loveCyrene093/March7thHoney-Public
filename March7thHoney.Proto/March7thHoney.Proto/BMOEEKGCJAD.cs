using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BMOEEKGCJAD : IMessage<BMOEEKGCJAD>, IMessage, IEquatable<BMOEEKGCJAD>, IDeepCloneable<BMOEEKGCJAD>, IBufferMessage
{
	private static readonly MessageParser<BMOEEKGCJAD> _parser = new MessageParser<BMOEEKGCJAD>(() => new BMOEEKGCJAD());

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 4;

	private uint level_;

	public const int IANEPPCHINMFieldNumber = 10;

	private bool iANEPPCHINM_;

	public const int GridFightEquipmentIdFieldNumber = 11;

	private uint gridFightEquipmentId_;

	public const int RarityFieldNumber = 13;

	private uint rarity_;

	public const int DCLAKCFJCPJFieldNumber = 14;

	private static readonly FieldCodec<EMFFAIMHEOO> _repeated_dCLAKCFJCPJ_codec = FieldCodec.ForMessage(114u, EMFFAIMHEOO.Parser);

	private readonly RepeatedField<EMFFAIMHEOO> dCLAKCFJCPJ_ = new RepeatedField<EMFFAIMHEOO>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BMOEEKGCJAD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BMOEEKGCJADReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public bool IANEPPCHINM
	{
		get
		{
			return iANEPPCHINM_;
		}
		set
		{
			iANEPPCHINM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GridFightEquipmentId
	{
		get
		{
			return gridFightEquipmentId_;
		}
		set
		{
			gridFightEquipmentId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Rarity
	{
		get
		{
			return rarity_;
		}
		set
		{
			rarity_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EMFFAIMHEOO> DCLAKCFJCPJ => dCLAKCFJCPJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BMOEEKGCJAD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BMOEEKGCJAD(BMOEEKGCJAD other)
		: this()
	{
		level_ = other.level_;
		iANEPPCHINM_ = other.iANEPPCHINM_;
		gridFightEquipmentId_ = other.gridFightEquipmentId_;
		rarity_ = other.rarity_;
		dCLAKCFJCPJ_ = other.dCLAKCFJCPJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BMOEEKGCJAD Clone()
	{
		return new BMOEEKGCJAD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BMOEEKGCJAD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BMOEEKGCJAD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (IANEPPCHINM != other.IANEPPCHINM)
		{
			return false;
		}
		if (GridFightEquipmentId != other.GridFightEquipmentId)
		{
			return false;
		}
		if (Rarity != other.Rarity)
		{
			return false;
		}
		if (!dCLAKCFJCPJ_.Equals(other.dCLAKCFJCPJ_))
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
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (IANEPPCHINM)
		{
			num ^= IANEPPCHINM.GetHashCode();
		}
		if (GridFightEquipmentId != 0)
		{
			num ^= GridFightEquipmentId.GetHashCode();
		}
		if (Rarity != 0)
		{
			num ^= Rarity.GetHashCode();
		}
		num ^= dCLAKCFJCPJ_.GetHashCode();
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
		if (Level != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Level);
		}
		if (IANEPPCHINM)
		{
			output.WriteRawTag(80);
			output.WriteBool(IANEPPCHINM);
		}
		if (GridFightEquipmentId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(GridFightEquipmentId);
		}
		if (Rarity != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Rarity);
		}
		dCLAKCFJCPJ_.WriteTo(ref output, _repeated_dCLAKCFJCPJ_codec);
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
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (IANEPPCHINM)
		{
			num += 2;
		}
		if (GridFightEquipmentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GridFightEquipmentId);
		}
		if (Rarity != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Rarity);
		}
		num += dCLAKCFJCPJ_.CalculateSize(_repeated_dCLAKCFJCPJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BMOEEKGCJAD other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.IANEPPCHINM)
			{
				IANEPPCHINM = other.IANEPPCHINM;
			}
			if (other.GridFightEquipmentId != 0)
			{
				GridFightEquipmentId = other.GridFightEquipmentId;
			}
			if (other.Rarity != 0)
			{
				Rarity = other.Rarity;
			}
			dCLAKCFJCPJ_.Add(other.dCLAKCFJCPJ_);
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
				Level = input.ReadUInt32();
				break;
			case 80u:
				IANEPPCHINM = input.ReadBool();
				break;
			case 88u:
				GridFightEquipmentId = input.ReadUInt32();
				break;
			case 104u:
				Rarity = input.ReadUInt32();
				break;
			case 114u:
				dCLAKCFJCPJ_.AddEntriesFrom(ref input, _repeated_dCLAKCFJCPJ_codec);
				break;
			}
		}
	}
}
