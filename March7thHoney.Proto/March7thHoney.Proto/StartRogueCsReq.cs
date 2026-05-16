using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StartRogueCsReq : IMessage<StartRogueCsReq>, IMessage, IEquatable<StartRogueCsReq>, IDeepCloneable<StartRogueCsReq>, IBufferMessage
{
	private static readonly MessageParser<StartRogueCsReq> _parser = new MessageParser<StartRogueCsReq>(() => new StartRogueCsReq());

	private UnknownFieldSet _unknownFields;

	public const int LGHOOKMNMCLFieldNumber = 2;

	private uint lGHOOKMNMCL_;

	public const int KOLBLKEDOGCFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_kOLBLKEDOGC_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> kOLBLKEDOGC_ = new RepeatedField<uint>();

	public const int AreaIdFieldNumber = 5;

	private uint areaId_;

	public const int UnfinishedStoryLineIdListFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_unfinishedStoryLineIdList_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> unfinishedStoryLineIdList_ = new RepeatedField<uint>();

	public const int BaseAvatarIdListFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StartRogueCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StartRogueCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LGHOOKMNMCL
	{
		get
		{
			return lGHOOKMNMCL_;
		}
		set
		{
			lGHOOKMNMCL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> KOLBLKEDOGC => kOLBLKEDOGC_;

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
	public RepeatedField<uint> UnfinishedStoryLineIdList => unfinishedStoryLineIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BaseAvatarIdList => baseAvatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartRogueCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartRogueCsReq(StartRogueCsReq other)
		: this()
	{
		lGHOOKMNMCL_ = other.lGHOOKMNMCL_;
		kOLBLKEDOGC_ = other.kOLBLKEDOGC_.Clone();
		areaId_ = other.areaId_;
		unfinishedStoryLineIdList_ = other.unfinishedStoryLineIdList_.Clone();
		baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartRogueCsReq Clone()
	{
		return new StartRogueCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StartRogueCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StartRogueCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LGHOOKMNMCL != other.LGHOOKMNMCL)
		{
			return false;
		}
		if (!kOLBLKEDOGC_.Equals(other.kOLBLKEDOGC_))
		{
			return false;
		}
		if (AreaId != other.AreaId)
		{
			return false;
		}
		if (!unfinishedStoryLineIdList_.Equals(other.unfinishedStoryLineIdList_))
		{
			return false;
		}
		if (!baseAvatarIdList_.Equals(other.baseAvatarIdList_))
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
		if (LGHOOKMNMCL != 0)
		{
			num ^= LGHOOKMNMCL.GetHashCode();
		}
		num ^= kOLBLKEDOGC_.GetHashCode();
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
		}
		num ^= unfinishedStoryLineIdList_.GetHashCode();
		num ^= baseAvatarIdList_.GetHashCode();
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
		if (LGHOOKMNMCL != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(LGHOOKMNMCL);
		}
		kOLBLKEDOGC_.WriteTo(ref output, _repeated_kOLBLKEDOGC_codec);
		if (AreaId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(AreaId);
		}
		unfinishedStoryLineIdList_.WriteTo(ref output, _repeated_unfinishedStoryLineIdList_codec);
		baseAvatarIdList_.WriteTo(ref output, _repeated_baseAvatarIdList_codec);
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
		if (LGHOOKMNMCL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LGHOOKMNMCL);
		}
		num += kOLBLKEDOGC_.CalculateSize(_repeated_kOLBLKEDOGC_codec);
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		num += unfinishedStoryLineIdList_.CalculateSize(_repeated_unfinishedStoryLineIdList_codec);
		num += baseAvatarIdList_.CalculateSize(_repeated_baseAvatarIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StartRogueCsReq other)
	{
		if (other != null)
		{
			if (other.LGHOOKMNMCL != 0)
			{
				LGHOOKMNMCL = other.LGHOOKMNMCL;
			}
			kOLBLKEDOGC_.Add(other.kOLBLKEDOGC_);
			if (other.AreaId != 0)
			{
				AreaId = other.AreaId;
			}
			unfinishedStoryLineIdList_.Add(other.unfinishedStoryLineIdList_);
			baseAvatarIdList_.Add(other.baseAvatarIdList_);
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
				LGHOOKMNMCL = input.ReadUInt32();
				break;
			case 24u:
			case 26u:
				kOLBLKEDOGC_.AddEntriesFrom(ref input, _repeated_kOLBLKEDOGC_codec);
				break;
			case 40u:
				AreaId = input.ReadUInt32();
				break;
			case 88u:
			case 90u:
				unfinishedStoryLineIdList_.AddEntriesFrom(ref input, _repeated_unfinishedStoryLineIdList_codec);
				break;
			case 112u:
			case 114u:
				baseAvatarIdList_.AddEntriesFrom(ref input, _repeated_baseAvatarIdList_codec);
				break;
			}
		}
	}
}
