using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GroupRefreshInfo : IMessage<GroupRefreshInfo>, IMessage, IEquatable<GroupRefreshInfo>, IDeepCloneable<GroupRefreshInfo>, IBufferMessage
{
	private static readonly MessageParser<GroupRefreshInfo> _parser = new MessageParser<GroupRefreshInfo>(() => new GroupRefreshInfo());

	private UnknownFieldSet _unknownFields;

	public const int Unk1FieldNumber = 1;

	private SceneEntityGroupInfo unk1_;

	public const int RefreshTypeFieldNumber = 8;

	private SceneGroupRefreshType refreshType_;

	public const int GroupIdFieldNumber = 9;

	private uint groupId_;

	public const int DCLAKCFJCPJFieldNumber = 11;

	private static readonly FieldCodec<NNHGOBLNCIE> _repeated_dCLAKCFJCPJ_codec = FieldCodec.ForMessage(90u, NNHGOBLNCIE.Parser);

	private readonly RepeatedField<NNHGOBLNCIE> dCLAKCFJCPJ_ = new RepeatedField<NNHGOBLNCIE>();

	public const int RefreshEntityFieldNumber = 12;

	private static readonly FieldCodec<SceneEntityRefreshInfo> _repeated_refreshEntity_codec = FieldCodec.ForMessage(98u, SceneEntityRefreshInfo.Parser);

	private readonly RepeatedField<SceneEntityRefreshInfo> refreshEntity_ = new RepeatedField<SceneEntityRefreshInfo>();

	public const int StateFieldNumber = 13;

	private uint state_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GroupRefreshInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GroupRefreshInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEntityGroupInfo Unk1
	{
		get
		{
			return unk1_;
		}
		set
		{
			unk1_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneGroupRefreshType RefreshType
	{
		get
		{
			return refreshType_;
		}
		set
		{
			refreshType_ = value;
		}
	}

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
	public RepeatedField<NNHGOBLNCIE> DCLAKCFJCPJ => dCLAKCFJCPJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SceneEntityRefreshInfo> RefreshEntity => refreshEntity_;

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
	public GroupRefreshInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupRefreshInfo(GroupRefreshInfo other)
		: this()
	{
		unk1_ = ((other.unk1_ != null) ? other.unk1_.Clone() : null);
		refreshType_ = other.refreshType_;
		groupId_ = other.groupId_;
		dCLAKCFJCPJ_ = other.dCLAKCFJCPJ_.Clone();
		refreshEntity_ = other.refreshEntity_.Clone();
		state_ = other.state_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GroupRefreshInfo Clone()
	{
		return new GroupRefreshInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GroupRefreshInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GroupRefreshInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Unk1, other.Unk1))
		{
			return false;
		}
		if (RefreshType != other.RefreshType)
		{
			return false;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (!dCLAKCFJCPJ_.Equals(other.dCLAKCFJCPJ_))
		{
			return false;
		}
		if (!refreshEntity_.Equals(other.refreshEntity_))
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
		if (unk1_ != null)
		{
			num ^= Unk1.GetHashCode();
		}
		if (RefreshType != SceneGroupRefreshType.None)
		{
			num ^= RefreshType.GetHashCode();
		}
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		num ^= dCLAKCFJCPJ_.GetHashCode();
		num ^= refreshEntity_.GetHashCode();
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
		if (unk1_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(Unk1);
		}
		if (RefreshType != SceneGroupRefreshType.None)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)RefreshType);
		}
		if (GroupId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(GroupId);
		}
		dCLAKCFJCPJ_.WriteTo(ref output, _repeated_dCLAKCFJCPJ_codec);
		refreshEntity_.WriteTo(ref output, _repeated_refreshEntity_codec);
		if (State != 0)
		{
			output.WriteRawTag(104);
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
		if (unk1_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Unk1);
		}
		if (RefreshType != SceneGroupRefreshType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)RefreshType);
		}
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		num += dCLAKCFJCPJ_.CalculateSize(_repeated_dCLAKCFJCPJ_codec);
		num += refreshEntity_.CalculateSize(_repeated_refreshEntity_codec);
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
	public void MergeFrom(GroupRefreshInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.unk1_ != null)
		{
			if (unk1_ == null)
			{
				Unk1 = new SceneEntityGroupInfo();
			}
			Unk1.MergeFrom(other.Unk1);
		}
		if (other.RefreshType != SceneGroupRefreshType.None)
		{
			RefreshType = other.RefreshType;
		}
		if (other.GroupId != 0)
		{
			GroupId = other.GroupId;
		}
		dCLAKCFJCPJ_.Add(other.dCLAKCFJCPJ_);
		refreshEntity_.Add(other.refreshEntity_);
		if (other.State != 0)
		{
			State = other.State;
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
			case 10u:
				if (unk1_ == null)
				{
					Unk1 = new SceneEntityGroupInfo();
				}
				input.ReadMessage(Unk1);
				break;
			case 64u:
				RefreshType = (SceneGroupRefreshType)input.ReadEnum();
				break;
			case 72u:
				GroupId = input.ReadUInt32();
				break;
			case 90u:
				dCLAKCFJCPJ_.AddEntriesFrom(ref input, _repeated_dCLAKCFJCPJ_codec);
				break;
			case 98u:
				refreshEntity_.AddEntriesFrom(ref input, _repeated_refreshEntity_codec);
				break;
			case 104u:
				State = input.ReadUInt32();
				break;
			}
		}
	}
}
