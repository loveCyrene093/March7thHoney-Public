using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyEventLoadUpdateScNotify : IMessage<MonopolyEventLoadUpdateScNotify>, IMessage, IEquatable<MonopolyEventLoadUpdateScNotify>, IDeepCloneable<MonopolyEventLoadUpdateScNotify>, IBufferMessage
{
	private static readonly MessageParser<MonopolyEventLoadUpdateScNotify> _parser = new MessageParser<MonopolyEventLoadUpdateScNotify>(() => new MonopolyEventLoadUpdateScNotify());

	private UnknownFieldSet _unknownFields;

	public const int LCPIODCLNHLFieldNumber = 3;

	private static readonly FieldCodec<AAHBECICOEN> _repeated_lCPIODCLNHL_codec = FieldCodec.ForMessage(26u, AAHBECICOEN.Parser);

	private readonly RepeatedField<AAHBECICOEN> lCPIODCLNHL_ = new RepeatedField<AAHBECICOEN>();

	public const int PGIHGNOLIOIFieldNumber = 7;

	private static readonly FieldCodec<AAHBECICOEN> _repeated_pGIHGNOLIOI_codec = FieldCodec.ForMessage(58u, AAHBECICOEN.Parser);

	private readonly RepeatedField<AAHBECICOEN> pGIHGNOLIOI_ = new RepeatedField<AAHBECICOEN>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyEventLoadUpdateScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyEventLoadUpdateScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AAHBECICOEN> LCPIODCLNHL => lCPIODCLNHL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AAHBECICOEN> PGIHGNOLIOI => pGIHGNOLIOI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyEventLoadUpdateScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyEventLoadUpdateScNotify(MonopolyEventLoadUpdateScNotify other)
		: this()
	{
		lCPIODCLNHL_ = other.lCPIODCLNHL_.Clone();
		pGIHGNOLIOI_ = other.pGIHGNOLIOI_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyEventLoadUpdateScNotify Clone()
	{
		return new MonopolyEventLoadUpdateScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyEventLoadUpdateScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyEventLoadUpdateScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lCPIODCLNHL_.Equals(other.lCPIODCLNHL_))
		{
			return false;
		}
		if (!pGIHGNOLIOI_.Equals(other.pGIHGNOLIOI_))
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
		num ^= lCPIODCLNHL_.GetHashCode();
		num ^= pGIHGNOLIOI_.GetHashCode();
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
		lCPIODCLNHL_.WriteTo(ref output, _repeated_lCPIODCLNHL_codec);
		pGIHGNOLIOI_.WriteTo(ref output, _repeated_pGIHGNOLIOI_codec);
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
		num += lCPIODCLNHL_.CalculateSize(_repeated_lCPIODCLNHL_codec);
		num += pGIHGNOLIOI_.CalculateSize(_repeated_pGIHGNOLIOI_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyEventLoadUpdateScNotify other)
	{
		if (other != null)
		{
			lCPIODCLNHL_.Add(other.lCPIODCLNHL_);
			pGIHGNOLIOI_.Add(other.pGIHGNOLIOI_);
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
				lCPIODCLNHL_.AddEntriesFrom(ref input, _repeated_lCPIODCLNHL_codec);
				break;
			case 58u:
				pGIHGNOLIOI_.AddEntriesFrom(ref input, _repeated_pGIHGNOLIOI_codec);
				break;
			}
		}
	}
}
