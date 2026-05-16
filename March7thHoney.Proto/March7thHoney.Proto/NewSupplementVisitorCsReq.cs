using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NewSupplementVisitorCsReq : IMessage<NewSupplementVisitorCsReq>, IMessage, IEquatable<NewSupplementVisitorCsReq>, IDeepCloneable<NewSupplementVisitorCsReq>, IBufferMessage
{
	private static readonly MessageParser<NewSupplementVisitorCsReq> _parser = new MessageParser<NewSupplementVisitorCsReq>(() => new NewSupplementVisitorCsReq());

	private UnknownFieldSet _unknownFields;

	public const int GLBPLJPPJPAFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_gLBPLJPPJPA_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> gLBPLJPPJPA_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NewSupplementVisitorCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NewSupplementVisitorCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GLBPLJPPJPA => gLBPLJPPJPA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NewSupplementVisitorCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NewSupplementVisitorCsReq(NewSupplementVisitorCsReq other)
		: this()
	{
		gLBPLJPPJPA_ = other.gLBPLJPPJPA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NewSupplementVisitorCsReq Clone()
	{
		return new NewSupplementVisitorCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NewSupplementVisitorCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NewSupplementVisitorCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gLBPLJPPJPA_.Equals(other.gLBPLJPPJPA_))
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
		num ^= gLBPLJPPJPA_.GetHashCode();
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
		gLBPLJPPJPA_.WriteTo(ref output, _repeated_gLBPLJPPJPA_codec);
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
		num += gLBPLJPPJPA_.CalculateSize(_repeated_gLBPLJPPJPA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NewSupplementVisitorCsReq other)
	{
		if (other != null)
		{
			gLBPLJPPJPA_.Add(other.gLBPLJPPJPA_);
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
			if (num != 48 && num != 50)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				gLBPLJPPJPA_.AddEntriesFrom(ref input, _repeated_gLBPLJPPJPA_codec);
			}
		}
	}
}
