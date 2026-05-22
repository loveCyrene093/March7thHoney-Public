using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class APCNLFANPEP : IMessage<APCNLFANPEP>, IMessage, IEquatable<APCNLFANPEP>, IDeepCloneable<APCNLFANPEP>, IBufferMessage
{
	private static readonly MessageParser<APCNLFANPEP> _parser = new MessageParser<APCNLFANPEP>(() => new APCNLFANPEP());

	private UnknownFieldSet _unknownFields;

	public const int GridFightEquipmentIdFieldNumber = 2;

	private uint gridFightEquipmentId_;

	public const int ConvertPropertyToFixpointFieldNumber = 4;

	private static readonly MapField<uint, uint>.Codec _map_convertPropertyToFixpoint_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 34u);

	private readonly MapField<uint, uint> convertPropertyToFixpoint_ = new MapField<uint, uint>();

	public const int UniqueIdFieldNumber = 5;

	private uint uniqueId_;

	public const int BBJCMOFGBFIFieldNumber = 6;

	private static readonly MapField<uint, double>.Codec _map_bBJCMOFGBFI_codec = new MapField<uint, double>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForDouble(17u, 0.0), 50u);

	private readonly MapField<uint, double> bBJCMOFGBFI_ = new MapField<uint, double>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<APCNLFANPEP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => APCNLFANPEPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public MapField<uint, uint> ConvertPropertyToFixpoint => convertPropertyToFixpoint_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, double> BBJCMOFGBFI => bBJCMOFGBFI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APCNLFANPEP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APCNLFANPEP(APCNLFANPEP other)
		: this()
	{
		gridFightEquipmentId_ = other.gridFightEquipmentId_;
		convertPropertyToFixpoint_ = other.convertPropertyToFixpoint_.Clone();
		uniqueId_ = other.uniqueId_;
		bBJCMOFGBFI_ = other.bBJCMOFGBFI_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APCNLFANPEP Clone()
	{
		return new APCNLFANPEP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as APCNLFANPEP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(APCNLFANPEP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GridFightEquipmentId != other.GridFightEquipmentId)
		{
			return false;
		}
		if (!ConvertPropertyToFixpoint.Equals(other.ConvertPropertyToFixpoint))
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (!BBJCMOFGBFI.Equals(other.BBJCMOFGBFI))
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
		if (GridFightEquipmentId != 0)
		{
			num ^= GridFightEquipmentId.GetHashCode();
		}
		num ^= ConvertPropertyToFixpoint.GetHashCode();
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		num ^= BBJCMOFGBFI.GetHashCode();
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
		if (GridFightEquipmentId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GridFightEquipmentId);
		}
		convertPropertyToFixpoint_.WriteTo(ref output, _map_convertPropertyToFixpoint_codec);
		if (UniqueId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(UniqueId);
		}
		bBJCMOFGBFI_.WriteTo(ref output, _map_bBJCMOFGBFI_codec);
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
		if (GridFightEquipmentId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GridFightEquipmentId);
		}
		num += convertPropertyToFixpoint_.CalculateSize(_map_convertPropertyToFixpoint_codec);
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		num += bBJCMOFGBFI_.CalculateSize(_map_bBJCMOFGBFI_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(APCNLFANPEP other)
	{
		if (other != null)
		{
			if (other.GridFightEquipmentId != 0)
			{
				GridFightEquipmentId = other.GridFightEquipmentId;
			}
			convertPropertyToFixpoint_.MergeFrom(other.convertPropertyToFixpoint_);
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
			}
			bBJCMOFGBFI_.MergeFrom(other.bBJCMOFGBFI_);
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
				GridFightEquipmentId = input.ReadUInt32();
				break;
			case 34u:
				convertPropertyToFixpoint_.AddEntriesFrom(ref input, _map_convertPropertyToFixpoint_codec);
				break;
			case 40u:
				UniqueId = input.ReadUInt32();
				break;
			case 50u:
				bBJCMOFGBFI_.AddEntriesFrom(ref input, _map_bBJCMOFGBFI_codec);
				break;
			}
		}
	}
}
