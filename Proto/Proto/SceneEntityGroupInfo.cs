using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneEntityGroupInfo : IMessage<SceneEntityGroupInfo>, IMessage, IEquatable<SceneEntityGroupInfo>, IDeepCloneable<SceneEntityGroupInfo>, IBufferMessage
{
	private static readonly MessageParser<SceneEntityGroupInfo> _parser = new MessageParser<SceneEntityGroupInfo>(() => new SceneEntityGroupInfo());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 2;

	private uint groupId_;

	public const int OPLJDFOOMGFFieldNumber = 8;

	private static readonly MapField<string, int>.Codec _map_oPLJDFOOMGF_codec = new MapField<string, int>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForInt32(16u, 0), 66u);

	private readonly MapField<string, int> oPLJDFOOMGF_ = new MapField<string, int>();

	public const int EntityListFieldNumber = 12;

	private static readonly FieldCodec<SceneEntityInfo> _repeated_entityList_codec = FieldCodec.ForMessage(98u, SceneEntityInfo.Parser);

	private readonly RepeatedField<SceneEntityInfo> entityList_ = new RepeatedField<SceneEntityInfo>();

	public const int StateFieldNumber = 15;

	private uint state_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneEntityGroupInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneEntityGroupInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, int> OPLJDFOOMGF => oPLJDFOOMGF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SceneEntityInfo> EntityList => entityList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint State
	{
		get
		{
			return state_;
		}
		set
		{
			state_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityGroupInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityGroupInfo(SceneEntityGroupInfo other)
		: this()
	{
		groupId_ = other.groupId_;
		oPLJDFOOMGF_ = other.oPLJDFOOMGF_.Clone();
		entityList_ = other.entityList_.Clone();
		state_ = other.state_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityGroupInfo Clone()
	{
		return new SceneEntityGroupInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneEntityGroupInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneEntityGroupInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (!OPLJDFOOMGF.Equals(other.OPLJDFOOMGF))
		{
			return false;
		}
		if (!entityList_.Equals(other.entityList_))
		{
			return false;
		}
		if (State != other.State)
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		num ^= OPLJDFOOMGF.GetHashCode();
		num ^= entityList_.GetHashCode();
		if (State != 0)
		{
			num ^= State.GetHashCode();
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
		if (GroupId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GroupId);
		}
		oPLJDFOOMGF_.WriteTo(ref output, _map_oPLJDFOOMGF_codec);
		entityList_.WriteTo(ref output, _repeated_entityList_codec);
		if (State != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(State);
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		num += oPLJDFOOMGF_.CalculateSize(_map_oPLJDFOOMGF_codec);
		num += entityList_.CalculateSize(_repeated_entityList_codec);
		if (State != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(State);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SceneEntityGroupInfo other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			oPLJDFOOMGF_.MergeFrom(other.oPLJDFOOMGF_);
			entityList_.Add(other.entityList_);
			if (other.State != 0)
			{
				State = other.State;
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
			case 16u:
				GroupId = input.ReadUInt32();
				break;
			case 66u:
				oPLJDFOOMGF_.AddEntriesFrom(ref input, _map_oPLJDFOOMGF_codec);
				break;
			case 98u:
				entityList_.AddEntriesFrom(ref input, _repeated_entityList_codec);
				break;
			case 120u:
				State = input.ReadUInt32();
				break;
			}
		}
	}
}
