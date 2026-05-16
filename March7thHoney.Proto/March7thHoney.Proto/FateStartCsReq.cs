using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FateStartCsReq : IMessage<FateStartCsReq>, IMessage, IEquatable<FateStartCsReq>, IDeepCloneable<FateStartCsReq>, IBufferMessage
{
	private static readonly MessageParser<FateStartCsReq> _parser = new MessageParser<FateStartCsReq>(() => new FateStartCsReq());

	private UnknownFieldSet _unknownFields;

	public const int AvatarListFieldNumber = 1;

	private static readonly FieldCodec<HAJAOGGPCJC> _repeated_avatarList_codec = FieldCodec.ForMessage(10u, HAJAOGGPCJC.Parser);

	private readonly RepeatedField<HAJAOGGPCJC> avatarList_ = new RepeatedField<HAJAOGGPCJC>();

	public const int AreaIdFieldNumber = 9;

	private uint areaId_;

	public const int DifficultyLevelFieldNumber = 15;

	private uint difficultyLevel_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FateStartCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FateStartCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HAJAOGGPCJC> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AreaId
	{
		get
		{
			return areaId_;
		}
		set
		{
			areaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DifficultyLevel
	{
		get
		{
			return difficultyLevel_;
		}
		set
		{
			difficultyLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateStartCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateStartCsReq(FateStartCsReq other)
		: this()
	{
		avatarList_ = other.avatarList_.Clone();
		areaId_ = other.areaId_;
		difficultyLevel_ = other.difficultyLevel_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FateStartCsReq Clone()
	{
		return new FateStartCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FateStartCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FateStartCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		if (AreaId != other.AreaId)
		{
			return false;
		}
		if (DifficultyLevel != other.DifficultyLevel)
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
		num ^= avatarList_.GetHashCode();
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
		}
		if (DifficultyLevel != 0)
		{
			num ^= DifficultyLevel.GetHashCode();
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
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		if (AreaId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(AreaId);
		}
		if (DifficultyLevel != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(DifficultyLevel);
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
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		if (DifficultyLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DifficultyLevel);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FateStartCsReq other)
	{
		if (other != null)
		{
			avatarList_.Add(other.avatarList_);
			if (other.AreaId != 0)
			{
				AreaId = other.AreaId;
			}
			if (other.DifficultyLevel != 0)
			{
				DifficultyLevel = other.DifficultyLevel;
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
			case 10u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 72u:
				AreaId = input.ReadUInt32();
				break;
			case 120u:
				DifficultyLevel = input.ReadUInt32();
				break;
			}
		}
	}
}
