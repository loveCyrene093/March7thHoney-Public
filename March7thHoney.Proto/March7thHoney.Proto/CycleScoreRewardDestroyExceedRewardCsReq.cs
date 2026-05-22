using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CycleScoreRewardDestroyExceedRewardCsReq : IMessage<CycleScoreRewardDestroyExceedRewardCsReq>, IMessage, IEquatable<CycleScoreRewardDestroyExceedRewardCsReq>, IDeepCloneable<CycleScoreRewardDestroyExceedRewardCsReq>, IBufferMessage
{
	private static readonly MessageParser<CycleScoreRewardDestroyExceedRewardCsReq> _parser = new MessageParser<CycleScoreRewardDestroyExceedRewardCsReq>(() => new CycleScoreRewardDestroyExceedRewardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int IEFIFKLKAJNFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_iEFIFKLKAJN_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> iEFIFKLKAJN_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CycleScoreRewardDestroyExceedRewardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CycleScoreRewardDestroyExceedRewardCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IEFIFKLKAJN => iEFIFKLKAJN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CycleScoreRewardDestroyExceedRewardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CycleScoreRewardDestroyExceedRewardCsReq(CycleScoreRewardDestroyExceedRewardCsReq other)
		: this()
	{
		iEFIFKLKAJN_ = other.iEFIFKLKAJN_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CycleScoreRewardDestroyExceedRewardCsReq Clone()
	{
		return new CycleScoreRewardDestroyExceedRewardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CycleScoreRewardDestroyExceedRewardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CycleScoreRewardDestroyExceedRewardCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iEFIFKLKAJN_.Equals(other.iEFIFKLKAJN_))
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
		num ^= iEFIFKLKAJN_.GetHashCode();
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
		iEFIFKLKAJN_.WriteTo(ref output, _repeated_iEFIFKLKAJN_codec);
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
		num += iEFIFKLKAJN_.CalculateSize(_repeated_iEFIFKLKAJN_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CycleScoreRewardDestroyExceedRewardCsReq other)
	{
		if (other != null)
		{
			iEFIFKLKAJN_.Add(other.iEFIFKLKAJN_);
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
			if (num != 56 && num != 58)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				iEFIFKLKAJN_.AddEntriesFrom(ref input, _repeated_iEFIFKLKAJN_codec);
			}
		}
	}
}
