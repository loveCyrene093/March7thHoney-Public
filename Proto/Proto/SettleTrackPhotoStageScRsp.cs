using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SettleTrackPhotoStageScRsp : IMessage<SettleTrackPhotoStageScRsp>, IMessage, IEquatable<SettleTrackPhotoStageScRsp>, IDeepCloneable<SettleTrackPhotoStageScRsp>, IBufferMessage
{
	private static readonly MessageParser<SettleTrackPhotoStageScRsp> _parser = new MessageParser<SettleTrackPhotoStageScRsp>(() => new SettleTrackPhotoStageScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ScoreIdFieldNumber = 2;

	private uint scoreId_;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int AJDKCBFCNLGFieldNumber = 13;

	private static readonly FieldCodec<MBCCBIAMIJP> _repeated_aJDKCBFCNLG_codec = FieldCodec.ForMessage(106u, MBCCBIAMIJP.Parser);

	private readonly RepeatedField<MBCCBIAMIJP> aJDKCBFCNLG_ = new RepeatedField<MBCCBIAMIJP>();

	public const int StageIdFieldNumber = 15;

	private uint stageId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SettleTrackPhotoStageScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SettleTrackPhotoStageScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<MBCCBIAMIJP> AJDKCBFCNLG => aJDKCBFCNLG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint StageId
	{
		get
		{
			return stageId_;
		}
		set
		{
			stageId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SettleTrackPhotoStageScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SettleTrackPhotoStageScRsp(SettleTrackPhotoStageScRsp other)
		: this()
	{
		scoreId_ = other.scoreId_;
		retcode_ = other.retcode_;
		aJDKCBFCNLG_ = other.aJDKCBFCNLG_.Clone();
		stageId_ = other.stageId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SettleTrackPhotoStageScRsp Clone()
	{
		return new SettleTrackPhotoStageScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SettleTrackPhotoStageScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SettleTrackPhotoStageScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!aJDKCBFCNLG_.Equals(other.aJDKCBFCNLG_))
		{
			return false;
		}
		if (StageId != other.StageId)
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
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= aJDKCBFCNLG_.GetHashCode();
		if (StageId != 0)
		{
			num ^= StageId.GetHashCode();
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
		if (ScoreId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(ScoreId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		aJDKCBFCNLG_.WriteTo(ref output, _repeated_aJDKCBFCNLG_codec);
		if (StageId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(StageId);
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
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += aJDKCBFCNLG_.CalculateSize(_repeated_aJDKCBFCNLG_codec);
		if (StageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StageId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SettleTrackPhotoStageScRsp other)
	{
		if (other != null)
		{
			if (other.ScoreId != 0)
			{
				ScoreId = other.ScoreId;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			aJDKCBFCNLG_.Add(other.aJDKCBFCNLG_);
			if (other.StageId != 0)
			{
				StageId = other.StageId;
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
				ScoreId = input.ReadUInt32();
				break;
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 106u:
				aJDKCBFCNLG_.AddEntriesFrom(ref input, _repeated_aJDKCBFCNLG_codec);
				break;
			case 120u:
				StageId = input.ReadUInt32();
				break;
			}
		}
	}
}
