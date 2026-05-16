using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetFightFestDataScRsp : IMessage<GetFightFestDataScRsp>, IMessage, IEquatable<GetFightFestDataScRsp>, IDeepCloneable<GetFightFestDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetFightFestDataScRsp> _parser = new MessageParser<GetFightFestDataScRsp>(() => new GetFightFestDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ItemValueFieldNumber = 3;

	private uint itemValue_;

	public const int GIGPHJEBDFLFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_gIGPHJEBDFL_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> gIGPHJEBDFL_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	public const int ScoreIdFieldNumber = 13;

	private uint scoreId_;

	public const int ChallengeListFieldNumber = 14;

	private static readonly FieldCodec<NPGGDOLMNIE> _repeated_challengeList_codec = FieldCodec.ForMessage(114u, NPGGDOLMNIE.Parser);

	private readonly RepeatedField<NPGGDOLMNIE> challengeList_ = new RepeatedField<NPGGDOLMNIE>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetFightFestDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetFightFestDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemValue
	{
		get
		{
			return itemValue_;
		}
		set
		{
			itemValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GIGPHJEBDFL => gIGPHJEBDFL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScoreId
	{
		get
		{
			return scoreId_;
		}
		set
		{
			scoreId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NPGGDOLMNIE> ChallengeList => challengeList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFightFestDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFightFestDataScRsp(GetFightFestDataScRsp other)
		: this()
	{
		itemValue_ = other.itemValue_;
		gIGPHJEBDFL_ = other.gIGPHJEBDFL_.Clone();
		retcode_ = other.retcode_;
		scoreId_ = other.scoreId_;
		challengeList_ = other.challengeList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetFightFestDataScRsp Clone()
	{
		return new GetFightFestDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetFightFestDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetFightFestDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ItemValue != other.ItemValue)
		{
			return false;
		}
		if (!gIGPHJEBDFL_.Equals(other.gIGPHJEBDFL_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (!challengeList_.Equals(other.challengeList_))
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
		if (ItemValue != 0)
		{
			num ^= ItemValue.GetHashCode();
		}
		num ^= gIGPHJEBDFL_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		num ^= challengeList_.GetHashCode();
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
		if (ItemValue != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ItemValue);
		}
		gIGPHJEBDFL_.WriteTo(ref output, _repeated_gIGPHJEBDFL_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Retcode);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ScoreId);
		}
		challengeList_.WriteTo(ref output, _repeated_challengeList_codec);
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
		if (ItemValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemValue);
		}
		num += gIGPHJEBDFL_.CalculateSize(_repeated_gIGPHJEBDFL_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		num += challengeList_.CalculateSize(_repeated_challengeList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetFightFestDataScRsp other)
	{
		if (other != null)
		{
			if (other.ItemValue != 0)
			{
				ItemValue = other.ItemValue;
			}
			gIGPHJEBDFL_.Add(other.gIGPHJEBDFL_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.ScoreId != 0)
			{
				ScoreId = other.ScoreId;
			}
			challengeList_.Add(other.challengeList_);
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
			case 24u:
				ItemValue = input.ReadUInt32();
				break;
			case 64u:
			case 66u:
				gIGPHJEBDFL_.AddEntriesFrom(ref input, _repeated_gIGPHJEBDFL_codec);
				break;
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			case 104u:
				ScoreId = input.ReadUInt32();
				break;
			case 114u:
				challengeList_.AddEntriesFrom(ref input, _repeated_challengeList_codec);
				break;
			}
		}
	}
}
