using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TakeEventHandbookRewardCsReq : IMessage<TakeEventHandbookRewardCsReq>, IMessage, IEquatable<TakeEventHandbookRewardCsReq>, IDeepCloneable<TakeEventHandbookRewardCsReq>, IBufferMessage
{
	private static readonly MessageParser<TakeEventHandbookRewardCsReq> _parser = new MessageParser<TakeEventHandbookRewardCsReq>(() => new TakeEventHandbookRewardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int LADCEEHAJDGFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_lADCEEHAJDG_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> lADCEEHAJDG_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TakeEventHandbookRewardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TakeEventHandbookRewardCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> LADCEEHAJDG => lADCEEHAJDG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeEventHandbookRewardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeEventHandbookRewardCsReq(TakeEventHandbookRewardCsReq other)
		: this()
	{
		lADCEEHAJDG_ = other.lADCEEHAJDG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TakeEventHandbookRewardCsReq Clone()
	{
		return new TakeEventHandbookRewardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TakeEventHandbookRewardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TakeEventHandbookRewardCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lADCEEHAJDG_.Equals(other.lADCEEHAJDG_))
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
		num ^= lADCEEHAJDG_.GetHashCode();
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
		lADCEEHAJDG_.WriteTo(ref output, _repeated_lADCEEHAJDG_codec);
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
		num += lADCEEHAJDG_.CalculateSize(_repeated_lADCEEHAJDG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TakeEventHandbookRewardCsReq other)
	{
		if (other != null)
		{
			lADCEEHAJDG_.Add(other.lADCEEHAJDG_);
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
			if (num != 96 && num != 98)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				lADCEEHAJDG_.AddEntriesFrom(ref input, _repeated_lADCEEHAJDG_codec);
			}
		}
	}
}
