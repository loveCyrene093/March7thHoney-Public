using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightTeamInfoPb : IMessage<GridFightTeamInfoPb>, IMessage, IEquatable<GridFightTeamInfoPb>, IDeepCloneable<GridFightTeamInfoPb>, IBufferMessage
{
	private static readonly MessageParser<GridFightTeamInfoPb> _parser = new MessageParser<GridFightTeamInfoPb>(() => new GridFightTeamInfoPb());

	private UnknownFieldSet _unknownFields;

	public const int RolesFieldNumber = 1;

	private static readonly FieldCodec<GridFightRoleInfoPb> _repeated_roles_codec = FieldCodec.ForMessage(10u, GridFightRoleInfoPb.Parser);

	private readonly RepeatedField<GridFightRoleInfoPb> roles_ = new RepeatedField<GridFightRoleInfoPb>();

	public const int NpcsFieldNumber = 2;

	private static readonly FieldCodec<GridFightNpcInfoPb> _repeated_npcs_codec = FieldCodec.ForMessage(18u, GridFightNpcInfoPb.Parser);

	private readonly RepeatedField<GridFightNpcInfoPb> npcs_ = new RepeatedField<GridFightNpcInfoPb>();

	public const int ForgesFieldNumber = 3;

	private static readonly FieldCodec<GridFightForgeInfoPb> _repeated_forges_codec = FieldCodec.ForMessage(26u, GridFightForgeInfoPb.Parser);

	private readonly RepeatedField<GridFightForgeInfoPb> forges_ = new RepeatedField<GridFightForgeInfoPb>();

	public const int CurUniqueIdFieldNumber = 4;

	private uint curUniqueId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightTeamInfoPb> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightDataReflection.Descriptor.MessageTypes[11];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightRoleInfoPb> Roles => roles_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightNpcInfoPb> Npcs => npcs_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GridFightForgeInfoPb> Forges => forges_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurUniqueId
	{
		get
		{
			return curUniqueId_;
		}
		set
		{
			curUniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTeamInfoPb()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTeamInfoPb(GridFightTeamInfoPb other)
		: this()
	{
		roles_ = other.roles_.Clone();
		npcs_ = other.npcs_.Clone();
		forges_ = other.forges_.Clone();
		curUniqueId_ = other.curUniqueId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTeamInfoPb Clone()
	{
		return new GridFightTeamInfoPb(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightTeamInfoPb);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightTeamInfoPb other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!roles_.Equals(other.roles_))
		{
			return false;
		}
		if (!npcs_.Equals(other.npcs_))
		{
			return false;
		}
		if (!forges_.Equals(other.forges_))
		{
			return false;
		}
		if (CurUniqueId != other.CurUniqueId)
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
		num ^= roles_.GetHashCode();
		num ^= npcs_.GetHashCode();
		num ^= forges_.GetHashCode();
		if (CurUniqueId != 0)
		{
			num ^= CurUniqueId.GetHashCode();
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
		roles_.WriteTo(ref output, _repeated_roles_codec);
		npcs_.WriteTo(ref output, _repeated_npcs_codec);
		forges_.WriteTo(ref output, _repeated_forges_codec);
		if (CurUniqueId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(CurUniqueId);
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
		num += roles_.CalculateSize(_repeated_roles_codec);
		num += npcs_.CalculateSize(_repeated_npcs_codec);
		num += forges_.CalculateSize(_repeated_forges_codec);
		if (CurUniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurUniqueId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightTeamInfoPb other)
	{
		if (other != null)
		{
			roles_.Add(other.roles_);
			npcs_.Add(other.npcs_);
			forges_.Add(other.forges_);
			if (other.CurUniqueId != 0)
			{
				CurUniqueId = other.CurUniqueId;
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
		while ((num = input.ReadTag()) != 0)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 10u:
				roles_.AddEntriesFrom(ref input, _repeated_roles_codec);
				break;
			case 18u:
				npcs_.AddEntriesFrom(ref input, _repeated_npcs_codec);
				break;
			case 26u:
				forges_.AddEntriesFrom(ref input, _repeated_forges_codec);
				break;
			case 32u:
				CurUniqueId = input.ReadUInt32();
				break;
			}
		}
	}
}
