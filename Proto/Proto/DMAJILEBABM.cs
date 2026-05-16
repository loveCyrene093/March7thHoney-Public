using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DMAJILEBABM : IMessage<DMAJILEBABM>, IMessage, IEquatable<DMAJILEBABM>, IDeepCloneable<DMAJILEBABM>, IBufferMessage
{
	private static readonly MessageParser<DMAJILEBABM> _parser = new MessageParser<DMAJILEBABM>(() => new DMAJILEBABM());

	private UnknownFieldSet _unknownFields;

	public const int KCEFNIMAEJPFieldNumber = 3;

	private static readonly FieldCodec<DPEHILAANON> _repeated_kCEFNIMAEJP_codec = FieldCodec.ForMessage(26u, DPEHILAANON.Parser);

	private readonly RepeatedField<DPEHILAANON> kCEFNIMAEJP_ = new RepeatedField<DPEHILAANON>();

	public const int JJGMPFGCKHGFieldNumber = 11;

	private static readonly FieldCodec<IJOKDLMKDAE> _repeated_jJGMPFGCKHG_codec = FieldCodec.ForMessage(90u, IJOKDLMKDAE.Parser);

	private readonly RepeatedField<IJOKDLMKDAE> jJGMPFGCKHG_ = new RepeatedField<IJOKDLMKDAE>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DMAJILEBABM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DMAJILEBABMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DPEHILAANON> KCEFNIMAEJP => kCEFNIMAEJP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IJOKDLMKDAE> JJGMPFGCKHG => jJGMPFGCKHG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMAJILEBABM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMAJILEBABM(DMAJILEBABM other)
		: this()
	{
		kCEFNIMAEJP_ = other.kCEFNIMAEJP_.Clone();
		jJGMPFGCKHG_ = other.jJGMPFGCKHG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DMAJILEBABM Clone()
	{
		return new DMAJILEBABM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DMAJILEBABM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DMAJILEBABM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!kCEFNIMAEJP_.Equals(other.kCEFNIMAEJP_))
		{
			return false;
		}
		if (!jJGMPFGCKHG_.Equals(other.jJGMPFGCKHG_))
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
		num ^= kCEFNIMAEJP_.GetHashCode();
		num ^= jJGMPFGCKHG_.GetHashCode();
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
		kCEFNIMAEJP_.WriteTo(ref output, _repeated_kCEFNIMAEJP_codec);
		jJGMPFGCKHG_.WriteTo(ref output, _repeated_jJGMPFGCKHG_codec);
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
		num += kCEFNIMAEJP_.CalculateSize(_repeated_kCEFNIMAEJP_codec);
		num += jJGMPFGCKHG_.CalculateSize(_repeated_jJGMPFGCKHG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DMAJILEBABM other)
	{
		if (other != null)
		{
			kCEFNIMAEJP_.Add(other.kCEFNIMAEJP_);
			jJGMPFGCKHG_.Add(other.jJGMPFGCKHG_);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 26u:
				kCEFNIMAEJP_.AddEntriesFrom(ref input, _repeated_kCEFNIMAEJP_codec);
				break;
			case 90u:
				jJGMPFGCKHG_.AddEntriesFrom(ref input, _repeated_jJGMPFGCKHG_codec);
				break;
			}
		}
	}
}
