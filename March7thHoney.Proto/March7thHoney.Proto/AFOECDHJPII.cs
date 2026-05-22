using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AFOECDHJPII : IMessage<AFOECDHJPII>, IMessage, IEquatable<AFOECDHJPII>, IDeepCloneable<AFOECDHJPII>, IBufferMessage
{
	private static readonly MessageParser<AFOECDHJPII> _parser = new MessageParser<AFOECDHJPII>(() => new AFOECDHJPII());

	private UnknownFieldSet _unknownFields;

	public const int JJGMPFGCKHGFieldNumber = 3;

	private static readonly FieldCodec<GOFFLGEJEND> _repeated_jJGMPFGCKHG_codec = FieldCodec.ForMessage(26u, GOFFLGEJEND.Parser);

	private readonly RepeatedField<GOFFLGEJEND> jJGMPFGCKHG_ = new RepeatedField<GOFFLGEJEND>();

	public const int HMLAPLKEDDHFieldNumber = 9;

	private static readonly FieldCodec<IMHNBMOMLAC> _repeated_hMLAPLKEDDH_codec = FieldCodec.ForMessage(74u, IMHNBMOMLAC.Parser);

	private readonly RepeatedField<IMHNBMOMLAC> hMLAPLKEDDH_ = new RepeatedField<IMHNBMOMLAC>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AFOECDHJPII> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AFOECDHJPIIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GOFFLGEJEND> JJGMPFGCKHG => jJGMPFGCKHG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IMHNBMOMLAC> HMLAPLKEDDH => hMLAPLKEDDH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AFOECDHJPII()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AFOECDHJPII(AFOECDHJPII other)
		: this()
	{
		jJGMPFGCKHG_ = other.jJGMPFGCKHG_.Clone();
		hMLAPLKEDDH_ = other.hMLAPLKEDDH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AFOECDHJPII Clone()
	{
		return new AFOECDHJPII(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AFOECDHJPII);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AFOECDHJPII other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jJGMPFGCKHG_.Equals(other.jJGMPFGCKHG_))
		{
			return false;
		}
		if (!hMLAPLKEDDH_.Equals(other.hMLAPLKEDDH_))
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
		num ^= jJGMPFGCKHG_.GetHashCode();
		num ^= hMLAPLKEDDH_.GetHashCode();
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
		jJGMPFGCKHG_.WriteTo(ref output, _repeated_jJGMPFGCKHG_codec);
		hMLAPLKEDDH_.WriteTo(ref output, _repeated_hMLAPLKEDDH_codec);
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
		num += jJGMPFGCKHG_.CalculateSize(_repeated_jJGMPFGCKHG_codec);
		num += hMLAPLKEDDH_.CalculateSize(_repeated_hMLAPLKEDDH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AFOECDHJPII other)
	{
		if (other != null)
		{
			jJGMPFGCKHG_.Add(other.jJGMPFGCKHG_);
			hMLAPLKEDDH_.Add(other.hMLAPLKEDDH_);
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
				jJGMPFGCKHG_.AddEntriesFrom(ref input, _repeated_jJGMPFGCKHG_codec);
				break;
			case 74u:
				hMLAPLKEDDH_.AddEntriesFrom(ref input, _repeated_hMLAPLKEDDH_codec);
				break;
			}
		}
	}
}
