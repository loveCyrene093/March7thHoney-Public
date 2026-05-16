using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SaveLogisticsCsReq : IMessage<SaveLogisticsCsReq>, IMessage, IEquatable<SaveLogisticsCsReq>, IDeepCloneable<SaveLogisticsCsReq>, IBufferMessage
{
	private static readonly MessageParser<SaveLogisticsCsReq> _parser = new MessageParser<SaveLogisticsCsReq>(() => new SaveLogisticsCsReq());

	private UnknownFieldSet _unknownFields;

	public const int KDKBNMEJLFPFieldNumber = 2;

	private static readonly FieldCodec<CCBKGJGNDCL> _repeated_kDKBNMEJLFP_codec = FieldCodec.ForMessage(18u, CCBKGJGNDCL.Parser);

	private readonly RepeatedField<CCBKGJGNDCL> kDKBNMEJLFP_ = new RepeatedField<CCBKGJGNDCL>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SaveLogisticsCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SaveLogisticsCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CCBKGJGNDCL> KDKBNMEJLFP => kDKBNMEJLFP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SaveLogisticsCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SaveLogisticsCsReq(SaveLogisticsCsReq other)
		: this()
	{
		kDKBNMEJLFP_ = other.kDKBNMEJLFP_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SaveLogisticsCsReq Clone()
	{
		return new SaveLogisticsCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SaveLogisticsCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SaveLogisticsCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!kDKBNMEJLFP_.Equals(other.kDKBNMEJLFP_))
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
		num ^= kDKBNMEJLFP_.GetHashCode();
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
		kDKBNMEJLFP_.WriteTo(ref output, _repeated_kDKBNMEJLFP_codec);
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
		num += kDKBNMEJLFP_.CalculateSize(_repeated_kDKBNMEJLFP_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SaveLogisticsCsReq other)
	{
		if (other != null)
		{
			kDKBNMEJLFP_.Add(other.kDKBNMEJLFP_);
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
			if (num != 18)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				kDKBNMEJLFP_.AddEntriesFrom(ref input, _repeated_kDKBNMEJLFP_codec);
			}
		}
	}
}
