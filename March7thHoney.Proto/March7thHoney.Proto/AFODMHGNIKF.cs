using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AFODMHGNIKF : IMessage<AFODMHGNIKF>, IMessage, IEquatable<AFODMHGNIKF>, IDeepCloneable<AFODMHGNIKF>, IBufferMessage
{
	private static readonly MessageParser<AFODMHGNIKF> _parser = new MessageParser<AFODMHGNIKF>(() => new AFODMHGNIKF());

	private UnknownFieldSet _unknownFields;

	public const int HDMDIFPDKMKFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_hDMDIFPDKMK_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> hDMDIFPDKMK_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AFODMHGNIKF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AFODMHGNIKFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HDMDIFPDKMK => hDMDIFPDKMK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AFODMHGNIKF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AFODMHGNIKF(AFODMHGNIKF other)
		: this()
	{
		hDMDIFPDKMK_ = other.hDMDIFPDKMK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AFODMHGNIKF Clone()
	{
		return new AFODMHGNIKF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AFODMHGNIKF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AFODMHGNIKF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!hDMDIFPDKMK_.Equals(other.hDMDIFPDKMK_))
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
		num ^= hDMDIFPDKMK_.GetHashCode();
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
		hDMDIFPDKMK_.WriteTo(ref output, _repeated_hDMDIFPDKMK_codec);
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
		num += hDMDIFPDKMK_.CalculateSize(_repeated_hDMDIFPDKMK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AFODMHGNIKF other)
	{
		if (other != null)
		{
			hDMDIFPDKMK_.Add(other.hDMDIFPDKMK_);
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
			if (num != 8 && num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				hDMDIFPDKMK_.AddEntriesFrom(ref input, _repeated_hDMDIFPDKMK_codec);
			}
		}
	}
}
