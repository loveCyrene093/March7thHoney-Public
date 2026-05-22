using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ICCCIJAKOJL : IMessage<ICCCIJAKOJL>, IMessage, IEquatable<ICCCIJAKOJL>, IDeepCloneable<ICCCIJAKOJL>, IBufferMessage
{
	private static readonly MessageParser<ICCCIJAKOJL> _parser = new MessageParser<ICCCIJAKOJL>(() => new ICCCIJAKOJL());

	private UnknownFieldSet _unknownFields;

	public const int CCBIEBICDMEFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_cCBIEBICDME_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> cCBIEBICDME_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ICCCIJAKOJL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ICCCIJAKOJLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CCBIEBICDME => cCBIEBICDME_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ICCCIJAKOJL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ICCCIJAKOJL(ICCCIJAKOJL other)
		: this()
	{
		cCBIEBICDME_ = other.cCBIEBICDME_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ICCCIJAKOJL Clone()
	{
		return new ICCCIJAKOJL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ICCCIJAKOJL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ICCCIJAKOJL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cCBIEBICDME_.Equals(other.cCBIEBICDME_))
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
		num ^= cCBIEBICDME_.GetHashCode();
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
		cCBIEBICDME_.WriteTo(ref output, _repeated_cCBIEBICDME_codec);
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
		num += cCBIEBICDME_.CalculateSize(_repeated_cCBIEBICDME_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ICCCIJAKOJL other)
	{
		if (other != null)
		{
			cCBIEBICDME_.Add(other.cCBIEBICDME_);
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
			if (num != 64 && num != 66)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				cCBIEBICDME_.AddEntriesFrom(ref input, _repeated_cCBIEBICDME_codec);
			}
		}
	}
}
