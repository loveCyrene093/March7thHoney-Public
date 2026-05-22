using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrialActivityDataChangeScNotify : IMessage<TrialActivityDataChangeScNotify>, IMessage, IEquatable<TrialActivityDataChangeScNotify>, IDeepCloneable<TrialActivityDataChangeScNotify>, IBufferMessage
{
	private static readonly MessageParser<TrialActivityDataChangeScNotify> _parser = new MessageParser<TrialActivityDataChangeScNotify>(() => new TrialActivityDataChangeScNotify());

	private UnknownFieldSet _unknownFields;

	public const int MANGLIPKMDIFieldNumber = 3;

	private static readonly FieldCodec<NNFJAOJKKFO> _repeated_mANGLIPKMDI_codec = FieldCodec.ForMessage(26u, NNFJAOJKKFO.Parser);

	private readonly RepeatedField<NNFJAOJKKFO> mANGLIPKMDI_ = new RepeatedField<NNFJAOJKKFO>();

	public const int TrialActivityInfoFieldNumber = 10;

	private TrialActivityInfo trialActivityInfo_;

	public const int BLDLBKLAIALFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_bLDLBKLAIAL_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> bLDLBKLAIAL_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrialActivityDataChangeScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrialActivityDataChangeScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<NNFJAOJKKFO> MANGLIPKMDI => mANGLIPKMDI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrialActivityInfo TrialActivityInfo
	{
		get
		{
			return trialActivityInfo_;
		}
		set
		{
			trialActivityInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BLDLBKLAIAL => bLDLBKLAIAL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrialActivityDataChangeScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrialActivityDataChangeScNotify(TrialActivityDataChangeScNotify other)
		: this()
	{
		mANGLIPKMDI_ = other.mANGLIPKMDI_.Clone();
		trialActivityInfo_ = ((other.trialActivityInfo_ != null) ? other.trialActivityInfo_.Clone() : null);
		bLDLBKLAIAL_ = other.bLDLBKLAIAL_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrialActivityDataChangeScNotify Clone()
	{
		return new TrialActivityDataChangeScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrialActivityDataChangeScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrialActivityDataChangeScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mANGLIPKMDI_.Equals(other.mANGLIPKMDI_))
		{
			return false;
		}
		if (!object.Equals(TrialActivityInfo, other.TrialActivityInfo))
		{
			return false;
		}
		if (!bLDLBKLAIAL_.Equals(other.bLDLBKLAIAL_))
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
		num ^= mANGLIPKMDI_.GetHashCode();
		if (trialActivityInfo_ != null)
		{
			num ^= TrialActivityInfo.GetHashCode();
		}
		num ^= bLDLBKLAIAL_.GetHashCode();
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
		mANGLIPKMDI_.WriteTo(ref output, _repeated_mANGLIPKMDI_codec);
		if (trialActivityInfo_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(TrialActivityInfo);
		}
		bLDLBKLAIAL_.WriteTo(ref output, _repeated_bLDLBKLAIAL_codec);
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
		num += mANGLIPKMDI_.CalculateSize(_repeated_mANGLIPKMDI_codec);
		if (trialActivityInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TrialActivityInfo);
		}
		num += bLDLBKLAIAL_.CalculateSize(_repeated_bLDLBKLAIAL_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrialActivityDataChangeScNotify other)
	{
		if (other == null)
		{
			return;
		}
		mANGLIPKMDI_.Add(other.mANGLIPKMDI_);
		if (other.trialActivityInfo_ != null)
		{
			if (trialActivityInfo_ == null)
			{
				TrialActivityInfo = new TrialActivityInfo();
			}
			TrialActivityInfo.MergeFrom(other.TrialActivityInfo);
		}
		bLDLBKLAIAL_.Add(other.bLDLBKLAIAL_);
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
			case 26u:
				mANGLIPKMDI_.AddEntriesFrom(ref input, _repeated_mANGLIPKMDI_codec);
				break;
			case 82u:
				if (trialActivityInfo_ == null)
				{
					TrialActivityInfo = new TrialActivityInfo();
				}
				input.ReadMessage(TrialActivityInfo);
				break;
			case 112u:
			case 114u:
				bLDLBKLAIAL_.AddEntriesFrom(ref input, _repeated_bLDLBKLAIAL_codec);
				break;
			}
		}
	}
}
