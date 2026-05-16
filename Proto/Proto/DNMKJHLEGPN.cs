using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DNMKJHLEGPN : IMessage<DNMKJHLEGPN>, IMessage, IEquatable<DNMKJHLEGPN>, IDeepCloneable<DNMKJHLEGPN>, IBufferMessage
{
	private static readonly MessageParser<DNMKJHLEGPN> _parser = new MessageParser<DNMKJHLEGPN>(() => new DNMKJHLEGPN());

	private UnknownFieldSet _unknownFields;

	public const int FAIPOCIAFODFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_fAIPOCIAFOD_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> fAIPOCIAFOD_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DNMKJHLEGPN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DNMKJHLEGPNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FAIPOCIAFOD => fAIPOCIAFOD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DNMKJHLEGPN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DNMKJHLEGPN(DNMKJHLEGPN other)
		: this()
	{
		fAIPOCIAFOD_ = other.fAIPOCIAFOD_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DNMKJHLEGPN Clone()
	{
		return new DNMKJHLEGPN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DNMKJHLEGPN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DNMKJHLEGPN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fAIPOCIAFOD_.Equals(other.fAIPOCIAFOD_))
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
		num ^= fAIPOCIAFOD_.GetHashCode();
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
		fAIPOCIAFOD_.WriteTo(ref output, _repeated_fAIPOCIAFOD_codec);
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
		num += fAIPOCIAFOD_.CalculateSize(_repeated_fAIPOCIAFOD_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DNMKJHLEGPN other)
	{
		if (other != null)
		{
			fAIPOCIAFOD_.Add(other.fAIPOCIAFOD_);
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
				fAIPOCIAFOD_.AddEntriesFrom(ref input, _repeated_fAIPOCIAFOD_codec);
			}
		}
	}
}
