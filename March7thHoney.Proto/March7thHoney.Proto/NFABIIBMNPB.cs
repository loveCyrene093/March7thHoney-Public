using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NFABIIBMNPB : IMessage<NFABIIBMNPB>, IMessage, IEquatable<NFABIIBMNPB>, IDeepCloneable<NFABIIBMNPB>, IBufferMessage
{
	private static readonly MessageParser<NFABIIBMNPB> _parser = new MessageParser<NFABIIBMNPB>(() => new NFABIIBMNPB());

	private UnknownFieldSet _unknownFields;

	public const int PosFieldNumber = 1;

	private uint pos_;

	public const int RoleIdFieldNumber = 2;

	private uint roleId_;

	public const int RoleStarFieldNumber = 3;

	private uint roleStar_;

	public const int GridFightItemListFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_gridFightItemList_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> gridFightItemList_ = new RepeatedField<uint>();

	public const int GridFightValueInitComponentFieldNumber = 5;

	private static readonly MapField<string, uint>.Codec _map_gridFightValueInitComponent_codec = new MapField<string, uint>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForUInt32(16u, 0u), 42u);

	private readonly MapField<string, uint> gridFightValueInitComponent_ = new MapField<string, uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NFABIIBMNPB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NFABIIBMNPBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<uint> GridFightItemList => gridFightItemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, uint> GridFightValueInitComponent => gridFightValueInitComponent_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NFABIIBMNPB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NFABIIBMNPB(NFABIIBMNPB other)
		: this()
	{
		pos_ = other.pos_;
		roleId_ = other.roleId_;
		roleStar_ = other.roleStar_;
		gridFightItemList_ = other.gridFightItemList_.Clone();
		gridFightValueInitComponent_ = other.gridFightValueInitComponent_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NFABIIBMNPB Clone()
	{
		return new NFABIIBMNPB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NFABIIBMNPB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NFABIIBMNPB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Pos != other.Pos)
		{
			return false;
		}
		if (RoleId != other.RoleId)
		{
			return false;
		}
		if (RoleStar != other.RoleStar)
		{
			return false;
		}
		if (!gridFightItemList_.Equals(other.gridFightItemList_))
		{
			return false;
		}
		if (!GridFightValueInitComponent.Equals(other.GridFightValueInitComponent))
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
		if (Pos != 0)
		{
			num ^= Pos.GetHashCode();
		}
		if (RoleId != 0)
		{
			num ^= RoleId.GetHashCode();
		}
		if (RoleStar != 0)
		{
			num ^= RoleStar.GetHashCode();
		}
		num ^= gridFightItemList_.GetHashCode();
		num ^= GridFightValueInitComponent.GetHashCode();
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
		if (Pos != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Pos);
		}
		if (RoleId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(RoleId);
		}
		if (RoleStar != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(RoleStar);
		}
		gridFightItemList_.WriteTo(ref output, _repeated_gridFightItemList_codec);
		gridFightValueInitComponent_.WriteTo(ref output, _map_gridFightValueInitComponent_codec);
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
		if (Pos != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Pos);
		}
		if (RoleId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoleId);
		}
		if (RoleStar != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoleStar);
		}
		num += gridFightItemList_.CalculateSize(_repeated_gridFightItemList_codec);
		num += gridFightValueInitComponent_.CalculateSize(_map_gridFightValueInitComponent_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NFABIIBMNPB other)
	{
		if (other != null)
		{
			if (other.Pos != 0)
			{
				Pos = other.Pos;
			}
			if (other.RoleId != 0)
			{
				RoleId = other.RoleId;
			}
			if (other.RoleStar != 0)
			{
				RoleStar = other.RoleStar;
			}
			gridFightItemList_.Add(other.gridFightItemList_);
			gridFightValueInitComponent_.MergeFrom(other.gridFightValueInitComponent_);
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
				Pos = input.ReadUInt32();
				break;
			case 16u:
				RoleId = input.ReadUInt32();
				break;
			case 24u:
				RoleStar = input.ReadUInt32();
				break;
			case 32u:
			case 34u:
				gridFightItemList_.AddEntriesFrom(ref input, _repeated_gridFightItemList_codec);
				break;
			case 42u:
				gridFightValueInitComponent_.AddEntriesFrom(ref input, _map_gridFightValueInitComponent_codec);
				break;
			}
		}
	}
}
