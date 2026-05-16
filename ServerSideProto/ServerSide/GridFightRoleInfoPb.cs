using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightRoleInfoPb : IMessage<GridFightRoleInfoPb>, IMessage, IEquatable<GridFightRoleInfoPb>, IDeepCloneable<GridFightRoleInfoPb>, IBufferMessage
{
	private static readonly MessageParser<GridFightRoleInfoPb> _parser = new MessageParser<GridFightRoleInfoPb>(() => new GridFightRoleInfoPb());

	private UnknownFieldSet _unknownFields;

	public const int RoleIdFieldNumber = 1;

	private uint roleId_;

	public const int TierFieldNumber = 2;

	private uint tier_;

	public const int PosFieldNumber = 3;

	private uint pos_;

	public const int UniqueIdFieldNumber = 4;

	private uint uniqueId_;

	public const int SavedValuesFieldNumber = 5;

	private static readonly MapField<string, uint>.Codec _map_savedValues_codec = new MapField<string, uint>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForUInt32(16u, 0u), 42u);

	private readonly MapField<string, uint> savedValues_ = new MapField<string, uint>();

	public const int EquipmentIdsFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_equipmentIds_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> equipmentIds_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightRoleInfoPb> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightDataReflection.Descriptor.MessageTypes[6];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RoleId
	{
		get
		{
			return roleId_;
		}
		set
		{
			roleId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Tier
	{
		get
		{
			return tier_;
		}
		set
		{
			tier_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Pos
	{
		get
		{
			return pos_;
		}
		set
		{
			pos_ = value;
		}
	}

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
	public MapField<string, uint> SavedValues => savedValues_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> EquipmentIds => equipmentIds_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightRoleInfoPb()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightRoleInfoPb(GridFightRoleInfoPb other)
		: this()
	{
		roleId_ = other.roleId_;
		tier_ = other.tier_;
		pos_ = other.pos_;
		uniqueId_ = other.uniqueId_;
		savedValues_ = other.savedValues_.Clone();
		equipmentIds_ = other.equipmentIds_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightRoleInfoPb Clone()
	{
		return new GridFightRoleInfoPb(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightRoleInfoPb);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightRoleInfoPb other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		if (Tier != other.Tier)
		{
			return false;
		}
		if (Pos != other.Pos)
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (!SavedValues.Equals(other.SavedValues))
		{
			return false;
		}
		if (!equipmentIds_.Equals(other.equipmentIds_))
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
		if (RoleId != 0)
		{
			num ^= RoleId.GetHashCode();
		}
		if (Tier != 0)
		{
			num ^= Tier.GetHashCode();
		}
		if (Pos != 0)
		{
			num ^= Pos.GetHashCode();
		}
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		num ^= SavedValues.GetHashCode();
		num ^= equipmentIds_.GetHashCode();
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
		if (RoleId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(RoleId);
		}
		if (Tier != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Tier);
		}
		if (Pos != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Pos);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(UniqueId);
		}
		savedValues_.WriteTo(ref output, _map_savedValues_codec);
		equipmentIds_.WriteTo(ref output, _repeated_equipmentIds_codec);
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
		if (RoleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoleId);
		}
		if (Tier != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Tier);
		}
		if (Pos != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Pos);
		}
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		num += savedValues_.CalculateSize(_map_savedValues_codec);
		num += equipmentIds_.CalculateSize(_repeated_equipmentIds_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightRoleInfoPb other)
	{
		if (other != null)
		{
			if (other.RoleId != 0)
			{
				RoleId = other.RoleId;
			}
			if (other.Tier != 0)
			{
				Tier = other.Tier;
			}
			if (other.Pos != 0)
			{
				Pos = other.Pos;
			}
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
			}
			savedValues_.MergeFrom(other.savedValues_);
			equipmentIds_.Add(other.equipmentIds_);
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
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 8u:
				RoleId = input.ReadUInt32();
				break;
			case 16u:
				Tier = input.ReadUInt32();
				break;
			case 24u:
				Pos = input.ReadUInt32();
				break;
			case 32u:
				UniqueId = input.ReadUInt32();
				break;
			case 42u:
				savedValues_.AddEntriesFrom(ref input, _map_savedValues_codec);
				break;
			case 48u:
			case 50u:
				equipmentIds_.AddEntriesFrom(ref input, _repeated_equipmentIds_codec);
				break;
			}
		}
	}
}
