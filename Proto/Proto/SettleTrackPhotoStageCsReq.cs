using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SettleTrackPhotoStageCsReq : IMessage<SettleTrackPhotoStageCsReq>, IMessage, IEquatable<SettleTrackPhotoStageCsReq>, IDeepCloneable<SettleTrackPhotoStageCsReq>, IBufferMessage
{
	private static readonly MessageParser<SettleTrackPhotoStageCsReq> _parser = new MessageParser<SettleTrackPhotoStageCsReq>(() => new SettleTrackPhotoStageCsReq());

	private UnknownFieldSet _unknownFields;

	public const int AJDKCBFCNLGFieldNumber = 10;

	private static readonly FieldCodec<MBCCBIAMIJP> _repeated_aJDKCBFCNLG_codec = FieldCodec.ForMessage(82u, MBCCBIAMIJP.Parser);

	private readonly RepeatedField<MBCCBIAMIJP> aJDKCBFCNLG_ = new RepeatedField<MBCCBIAMIJP>();

	public const int CostTimeFieldNumber = 13;

	private uint costTime_;

	public const int StageIdFieldNumber = 15;

	private uint stageId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SettleTrackPhotoStageCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SettleTrackPhotoStageCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MBCCBIAMIJP> AJDKCBFCNLG => aJDKCBFCNLG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CostTime
	{
		get
		{
			return costTime_;
		}
		set
		{
			costTime_ = value;
		}
	}

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
	public SettleTrackPhotoStageCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SettleTrackPhotoStageCsReq(SettleTrackPhotoStageCsReq other)
		: this()
	{
		aJDKCBFCNLG_ = other.aJDKCBFCNLG_.Clone();
		costTime_ = other.costTime_;
		stageId_ = other.stageId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SettleTrackPhotoStageCsReq Clone()
	{
		return new SettleTrackPhotoStageCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SettleTrackPhotoStageCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SettleTrackPhotoStageCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!aJDKCBFCNLG_.Equals(other.aJDKCBFCNLG_))
		{
			return false;
		}
		if (CostTime != other.CostTime)
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
		num ^= aJDKCBFCNLG_.GetHashCode();
		if (CostTime != 0)
		{
			num ^= CostTime.GetHashCode();
		}
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
		aJDKCBFCNLG_.WriteTo(ref output, _repeated_aJDKCBFCNLG_codec);
		if (CostTime != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(CostTime);
		}
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
		num += aJDKCBFCNLG_.CalculateSize(_repeated_aJDKCBFCNLG_codec);
		if (CostTime != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CostTime);
		}
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
	public void MergeFrom(SettleTrackPhotoStageCsReq other)
	{
		if (other != null)
		{
			aJDKCBFCNLG_.Add(other.aJDKCBFCNLG_);
			if (other.CostTime != 0)
			{
				CostTime = other.CostTime;
			}
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
			case 82u:
				aJDKCBFCNLG_.AddEntriesFrom(ref input, _repeated_aJDKCBFCNLG_codec);
				break;
			case 104u:
				CostTime = input.ReadUInt32();
				break;
			case 120u:
				StageId = input.ReadUInt32();
				break;
			}
		}
	}
}
