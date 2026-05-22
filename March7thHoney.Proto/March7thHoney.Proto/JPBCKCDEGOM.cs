using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JPBCKCDEGOM : IMessage<JPBCKCDEGOM>, IMessage, IEquatable<JPBCKCDEGOM>, IDeepCloneable<JPBCKCDEGOM>, IBufferMessage
{
	private static readonly MessageParser<JPBCKCDEGOM> _parser = new MessageParser<JPBCKCDEGOM>(() => new JPBCKCDEGOM());

	private UnknownFieldSet _unknownFields;

	public const int ALIDDLBDPDHFieldNumber = 11;

	private static readonly FieldCodec<ELEOGABGBKG> _repeated_aLIDDLBDPDH_codec = FieldCodec.ForMessage(90u, ELEOGABGBKG.Parser);

	private readonly RepeatedField<ELEOGABGBKG> aLIDDLBDPDH_ = new RepeatedField<ELEOGABGBKG>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JPBCKCDEGOM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JPBCKCDEGOMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ELEOGABGBKG> ALIDDLBDPDH => aLIDDLBDPDH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JPBCKCDEGOM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JPBCKCDEGOM(JPBCKCDEGOM other)
		: this()
	{
		aLIDDLBDPDH_ = other.aLIDDLBDPDH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JPBCKCDEGOM Clone()
	{
		return new JPBCKCDEGOM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JPBCKCDEGOM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JPBCKCDEGOM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!aLIDDLBDPDH_.Equals(other.aLIDDLBDPDH_))
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
		num ^= aLIDDLBDPDH_.GetHashCode();
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
		aLIDDLBDPDH_.WriteTo(ref output, _repeated_aLIDDLBDPDH_codec);
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
		num += aLIDDLBDPDH_.CalculateSize(_repeated_aLIDDLBDPDH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JPBCKCDEGOM other)
	{
		if (other != null)
		{
			aLIDDLBDPDH_.Add(other.aLIDDLBDPDH_);
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
			if (num != 90)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				aLIDDLBDPDH_.AddEntriesFrom(ref input, _repeated_aLIDDLBDPDH_codec);
			}
		}
	}
}
