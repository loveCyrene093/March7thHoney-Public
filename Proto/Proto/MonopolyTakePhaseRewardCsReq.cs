using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyTakePhaseRewardCsReq : IMessage<MonopolyTakePhaseRewardCsReq>, IMessage, IEquatable<MonopolyTakePhaseRewardCsReq>, IDeepCloneable<MonopolyTakePhaseRewardCsReq>, IBufferMessage
{
	private static readonly MessageParser<MonopolyTakePhaseRewardCsReq> _parser = new MessageParser<MonopolyTakePhaseRewardCsReq>(() => new MonopolyTakePhaseRewardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int FFJECAMIEDLFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_fFJECAMIEDL_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> fFJECAMIEDL_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyTakePhaseRewardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyTakePhaseRewardCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FFJECAMIEDL => fFJECAMIEDL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyTakePhaseRewardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyTakePhaseRewardCsReq(MonopolyTakePhaseRewardCsReq other)
		: this()
	{
		fFJECAMIEDL_ = other.fFJECAMIEDL_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyTakePhaseRewardCsReq Clone()
	{
		return new MonopolyTakePhaseRewardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyTakePhaseRewardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyTakePhaseRewardCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fFJECAMIEDL_.Equals(other.fFJECAMIEDL_))
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
		num ^= fFJECAMIEDL_.GetHashCode();
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
		fFJECAMIEDL_.WriteTo(ref output, _repeated_fFJECAMIEDL_codec);
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
		num += fFJECAMIEDL_.CalculateSize(_repeated_fFJECAMIEDL_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyTakePhaseRewardCsReq other)
	{
		if (other != null)
		{
			fFJECAMIEDL_.Add(other.fFJECAMIEDL_);
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
			if (num != 80 && num != 82)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				fFJECAMIEDL_.AddEntriesFrom(ref input, _repeated_fFJECAMIEDL_codec);
			}
		}
	}
}
