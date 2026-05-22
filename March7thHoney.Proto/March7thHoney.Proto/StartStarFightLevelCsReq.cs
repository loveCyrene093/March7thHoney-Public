using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StartStarFightLevelCsReq : IMessage<StartStarFightLevelCsReq>, IMessage, IEquatable<StartStarFightLevelCsReq>, IDeepCloneable<StartStarFightLevelCsReq>, IBufferMessage
{
	private static readonly MessageParser<StartStarFightLevelCsReq> _parser = new MessageParser<StartStarFightLevelCsReq>(() => new StartStarFightLevelCsReq());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 9;

	private uint groupId_;

	public const int INOMFFAIEOAFieldNumber = 10;

	private uint iNOMFFAIEOA_;

	public const int AvatarListFieldNumber = 11;

	private static readonly FieldCodec<HJKGMCHFHFM> _repeated_avatarList_codec = FieldCodec.ForMessage(90u, HJKGMCHFHFM.Parser);

	private readonly RepeatedField<HJKGMCHFHFM> avatarList_ = new RepeatedField<HJKGMCHFHFM>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StartStarFightLevelCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StartStarFightLevelCsReqReflection.Descriptor.MessageTypes[0];

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
	public uint INOMFFAIEOA
	{
		get
		{
			return iNOMFFAIEOA_;
		}
		set
		{
			iNOMFFAIEOA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HJKGMCHFHFM> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartStarFightLevelCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartStarFightLevelCsReq(StartStarFightLevelCsReq other)
		: this()
	{
		groupId_ = other.groupId_;
		iNOMFFAIEOA_ = other.iNOMFFAIEOA_;
		avatarList_ = other.avatarList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartStarFightLevelCsReq Clone()
	{
		return new StartStarFightLevelCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StartStarFightLevelCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StartStarFightLevelCsReq other)
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
		if (INOMFFAIEOA != other.INOMFFAIEOA)
		{
			return false;
		}
		if (!avatarList_.Equals(other.avatarList_))
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
		if (INOMFFAIEOA != 0)
		{
			num ^= INOMFFAIEOA.GetHashCode();
		}
		num ^= avatarList_.GetHashCode();
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
			output.WriteRawTag(72);
			output.WriteUInt32(GroupId);
		}
		if (INOMFFAIEOA != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(INOMFFAIEOA);
		}
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
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
		if (INOMFFAIEOA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(INOMFFAIEOA);
		}
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StartStarFightLevelCsReq other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			if (other.INOMFFAIEOA != 0)
			{
				INOMFFAIEOA = other.INOMFFAIEOA;
			}
			avatarList_.Add(other.avatarList_);
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
			case 72u:
				GroupId = input.ReadUInt32();
				break;
			case 80u:
				INOMFFAIEOA = input.ReadUInt32();
				break;
			case 90u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			}
		}
	}
}
