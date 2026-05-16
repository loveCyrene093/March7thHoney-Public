using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetTrialActivityDataScRsp : IMessage<GetTrialActivityDataScRsp>, IMessage, IEquatable<GetTrialActivityDataScRsp>, IDeepCloneable<GetTrialActivityDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetTrialActivityDataScRsp> _parser = new MessageParser<GetTrialActivityDataScRsp>(() => new GetTrialActivityDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int BLDLBKLAIALFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_bLDLBKLAIAL_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> bLDLBKLAIAL_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int ActivityStageIdFieldNumber = 5;

	private uint activityStageId_;

	public const int MANGLIPKMDIFieldNumber = 13;

	private static readonly FieldCodec<NNFJAOJKKFO> _repeated_mANGLIPKMDI_codec = FieldCodec.ForMessage(106u, NNFJAOJKKFO.Parser);

	private readonly RepeatedField<NNFJAOJKKFO> mANGLIPKMDI_ = new RepeatedField<NNFJAOJKKFO>();

	public const int TrialActivityInfoListFieldNumber = 15;

	private static readonly FieldCodec<TrialActivityInfo> _repeated_trialActivityInfoList_codec = FieldCodec.ForMessage(122u, TrialActivityInfo.Parser);

	private readonly RepeatedField<TrialActivityInfo> trialActivityInfoList_ = new RepeatedField<TrialActivityInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetTrialActivityDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetTrialActivityDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BLDLBKLAIAL => bLDLBKLAIAL_;

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
	public uint ActivityStageId
	{
		get
		{
			return activityStageId_;
		}
		set
		{
			activityStageId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NNFJAOJKKFO> MANGLIPKMDI => mANGLIPKMDI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<TrialActivityInfo> TrialActivityInfoList => trialActivityInfoList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetTrialActivityDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetTrialActivityDataScRsp(GetTrialActivityDataScRsp other)
		: this()
	{
		bLDLBKLAIAL_ = other.bLDLBKLAIAL_.Clone();
		retcode_ = other.retcode_;
		activityStageId_ = other.activityStageId_;
		mANGLIPKMDI_ = other.mANGLIPKMDI_.Clone();
		trialActivityInfoList_ = other.trialActivityInfoList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetTrialActivityDataScRsp Clone()
	{
		return new GetTrialActivityDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetTrialActivityDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetTrialActivityDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bLDLBKLAIAL_.Equals(other.bLDLBKLAIAL_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (ActivityStageId != other.ActivityStageId)
		{
			return false;
		}
		if (!mANGLIPKMDI_.Equals(other.mANGLIPKMDI_))
		{
			return false;
		}
		if (!trialActivityInfoList_.Equals(other.trialActivityInfoList_))
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
		num ^= bLDLBKLAIAL_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (ActivityStageId != 0)
		{
			num ^= ActivityStageId.GetHashCode();
		}
		num ^= mANGLIPKMDI_.GetHashCode();
		num ^= trialActivityInfoList_.GetHashCode();
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
		bLDLBKLAIAL_.WriteTo(ref output, _repeated_bLDLBKLAIAL_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		if (ActivityStageId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(ActivityStageId);
		}
		mANGLIPKMDI_.WriteTo(ref output, _repeated_mANGLIPKMDI_codec);
		trialActivityInfoList_.WriteTo(ref output, _repeated_trialActivityInfoList_codec);
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
		num += bLDLBKLAIAL_.CalculateSize(_repeated_bLDLBKLAIAL_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (ActivityStageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ActivityStageId);
		}
		num += mANGLIPKMDI_.CalculateSize(_repeated_mANGLIPKMDI_codec);
		num += trialActivityInfoList_.CalculateSize(_repeated_trialActivityInfoList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetTrialActivityDataScRsp other)
	{
		if (other != null)
		{
			bLDLBKLAIAL_.Add(other.bLDLBKLAIAL_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.ActivityStageId != 0)
			{
				ActivityStageId = other.ActivityStageId;
			}
			mANGLIPKMDI_.Add(other.mANGLIPKMDI_);
			trialActivityInfoList_.Add(other.trialActivityInfoList_);
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
			case 18u:
				bLDLBKLAIAL_.AddEntriesFrom(ref input, _repeated_bLDLBKLAIAL_codec);
				break;
			case 24u:
				Retcode = input.ReadUInt32();
				break;
			case 40u:
				ActivityStageId = input.ReadUInt32();
				break;
			case 106u:
				mANGLIPKMDI_.AddEntriesFrom(ref input, _repeated_mANGLIPKMDI_codec);
				break;
			case 122u:
				trialActivityInfoList_.AddEntriesFrom(ref input, _repeated_trialActivityInfoList_codec);
				break;
			}
		}
	}
}
