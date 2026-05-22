using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridGameRoleInfo : IMessage<GridGameRoleInfo>, IMessage, IEquatable<GridGameRoleInfo>, IDeepCloneable<GridGameRoleInfo>, IBufferMessage
{
	private static readonly MessageParser<GridGameRoleInfo> _parser = new MessageParser<GridGameRoleInfo>(() => new GridGameRoleInfo());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private uint id_;

	public const int PosFieldNumber = 2;

	private uint pos_;

	public const int ConvertPropertyToFixpointFieldNumber = 6;

	private static readonly MapField<uint, uint>.Codec _map_convertPropertyToFixpoint_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 50u);

	private readonly MapField<uint, uint> convertPropertyToFixpoint_ = new MapField<uint, uint>();

	public const int UpdateEquipsComponentFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_updateEquipsComponent_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> updateEquipsComponent_ = new RepeatedField<uint>();

	public const int GridFightValueInitComponentFieldNumber = 10;

	private static readonly MapField<string, uint>.Codec _map_gridFightValueInitComponent_codec = new MapField<string, uint>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForUInt32(16u, 0u), 82u);

	private readonly MapField<string, uint> gridFightValueInitComponent_ = new MapField<string, uint>();

	public const int RoleStarFieldNumber = 11;

	private uint roleStar_;

	public const int UniqueIdFieldNumber = 12;

	private uint uniqueId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridGameRoleInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridGameRoleInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
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
	public MapField<uint, uint> ConvertPropertyToFixpoint => convertPropertyToFixpoint_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> UpdateEquipsComponent => updateEquipsComponent_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, uint> GridFightValueInitComponent => gridFightValueInitComponent_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RoleStar
	{
		get
		{
			return roleStar_;
		}
		set
		{
			roleStar_ = value;
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
	public GridGameRoleInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridGameRoleInfo(GridGameRoleInfo other)
		: this()
	{
		id_ = other.id_;
		pos_ = other.pos_;
		convertPropertyToFixpoint_ = other.convertPropertyToFixpoint_.Clone();
		updateEquipsComponent_ = other.updateEquipsComponent_.Clone();
		gridFightValueInitComponent_ = other.gridFightValueInitComponent_.Clone();
		roleStar_ = other.roleStar_;
		uniqueId_ = other.uniqueId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridGameRoleInfo Clone()
	{
		return new GridGameRoleInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridGameRoleInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridGameRoleInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (Pos != other.Pos)
		{
			return false;
		}
		if (!ConvertPropertyToFixpoint.Equals(other.ConvertPropertyToFixpoint))
		{
			return false;
		}
		if (!updateEquipsComponent_.Equals(other.updateEquipsComponent_))
		{
			return false;
		}
		if (!GridFightValueInitComponent.Equals(other.GridFightValueInitComponent))
		{
			return false;
		}
		if (RoleStar != other.RoleStar)
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (Pos != 0)
		{
			num ^= Pos.GetHashCode();
		}
		num ^= ConvertPropertyToFixpoint.GetHashCode();
		num ^= updateEquipsComponent_.GetHashCode();
		num ^= GridFightValueInitComponent.GetHashCode();
		if (RoleStar != 0)
		{
			num ^= RoleStar.GetHashCode();
		}
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Id);
		}
		if (Pos != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Pos);
		}
		convertPropertyToFixpoint_.WriteTo(ref output, _map_convertPropertyToFixpoint_codec);
		updateEquipsComponent_.WriteTo(ref output, _repeated_updateEquipsComponent_codec);
		gridFightValueInitComponent_.WriteTo(ref output, _map_gridFightValueInitComponent_codec);
		if (RoleStar != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(RoleStar);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(UniqueId);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (Pos != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Pos);
		}
		num += convertPropertyToFixpoint_.CalculateSize(_map_convertPropertyToFixpoint_codec);
		num += updateEquipsComponent_.CalculateSize(_repeated_updateEquipsComponent_codec);
		num += gridFightValueInitComponent_.CalculateSize(_map_gridFightValueInitComponent_codec);
		if (RoleStar != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoleStar);
		}
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridGameRoleInfo other)
	{
		if (other != null)
		{
			if (other.Id != 0)
			{
				Id = other.Id;
			}
			if (other.Pos != 0)
			{
				Pos = other.Pos;
			}
			convertPropertyToFixpoint_.MergeFrom(other.convertPropertyToFixpoint_);
			updateEquipsComponent_.Add(other.updateEquipsComponent_);
			gridFightValueInitComponent_.MergeFrom(other.gridFightValueInitComponent_);
			if (other.RoleStar != 0)
			{
				RoleStar = other.RoleStar;
			}
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
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
				Id = input.ReadUInt32();
				break;
			case 16u:
				Pos = input.ReadUInt32();
				break;
			case 50u:
				convertPropertyToFixpoint_.AddEntriesFrom(ref input, _map_convertPropertyToFixpoint_codec);
				break;
			case 56u:
			case 58u:
				updateEquipsComponent_.AddEntriesFrom(ref input, _repeated_updateEquipsComponent_codec);
				break;
			case 82u:
				gridFightValueInitComponent_.AddEntriesFrom(ref input, _map_gridFightValueInitComponent_codec);
				break;
			case 88u:
				RoleStar = input.ReadUInt32();
				break;
			case 96u:
				UniqueId = input.ReadUInt32();
				break;
			}
		}
	}
}
