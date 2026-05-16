using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KNNODAPAKJA : IMessage<KNNODAPAKJA>, IMessage, IEquatable<KNNODAPAKJA>, IDeepCloneable<KNNODAPAKJA>, IBufferMessage
{
	private static readonly MessageParser<KNNODAPAKJA> _parser = new MessageParser<KNNODAPAKJA>(() => new KNNODAPAKJA());

	private UnknownFieldSet _unknownFields;

	public const int OODPDEBICHFFieldNumber = 3;

	private uint oODPDEBICHF_;

	public const int JILAADEFNGDFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_jILAADEFNGD_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> jILAADEFNGD_ = new RepeatedField<uint>();

	public const int PADDEJDLFLAFieldNumber = 7;

	private static readonly FieldCodec<AFFIMBGBMBJ> _repeated_pADDEJDLFLA_codec = FieldCodec.ForMessage(58u, AFFIMBGBMBJ.Parser);

	private readonly RepeatedField<AFFIMBGBMBJ> pADDEJDLFLA_ = new RepeatedField<AFFIMBGBMBJ>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KNNODAPAKJA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KNNODAPAKJAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OODPDEBICHF
	{
		get
		{
			return oODPDEBICHF_;
		}
		set
		{
			oODPDEBICHF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JILAADEFNGD => jILAADEFNGD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AFFIMBGBMBJ> PADDEJDLFLA => pADDEJDLFLA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNNODAPAKJA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNNODAPAKJA(KNNODAPAKJA other)
		: this()
	{
		oODPDEBICHF_ = other.oODPDEBICHF_;
		jILAADEFNGD_ = other.jILAADEFNGD_.Clone();
		pADDEJDLFLA_ = other.pADDEJDLFLA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNNODAPAKJA Clone()
	{
		return new KNNODAPAKJA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KNNODAPAKJA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KNNODAPAKJA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OODPDEBICHF != other.OODPDEBICHF)
		{
			return false;
		}
		if (!jILAADEFNGD_.Equals(other.jILAADEFNGD_))
		{
			return false;
		}
		if (!pADDEJDLFLA_.Equals(other.pADDEJDLFLA_))
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
		if (OODPDEBICHF != 0)
		{
			num ^= OODPDEBICHF.GetHashCode();
		}
		num ^= jILAADEFNGD_.GetHashCode();
		num ^= pADDEJDLFLA_.GetHashCode();
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
		if (OODPDEBICHF != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(OODPDEBICHF);
		}
		jILAADEFNGD_.WriteTo(ref output, _repeated_jILAADEFNGD_codec);
		pADDEJDLFLA_.WriteTo(ref output, _repeated_pADDEJDLFLA_codec);
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
		if (OODPDEBICHF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OODPDEBICHF);
		}
		num += jILAADEFNGD_.CalculateSize(_repeated_jILAADEFNGD_codec);
		num += pADDEJDLFLA_.CalculateSize(_repeated_pADDEJDLFLA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KNNODAPAKJA other)
	{
		if (other != null)
		{
			if (other.OODPDEBICHF != 0)
			{
				OODPDEBICHF = other.OODPDEBICHF;
			}
			jILAADEFNGD_.Add(other.jILAADEFNGD_);
			pADDEJDLFLA_.Add(other.pADDEJDLFLA_);
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
			case 24u:
				OODPDEBICHF = input.ReadUInt32();
				break;
			case 32u:
			case 34u:
				jILAADEFNGD_.AddEntriesFrom(ref input, _repeated_jILAADEFNGD_codec);
				break;
			case 58u:
				pADDEJDLFLA_.AddEntriesFrom(ref input, _repeated_pADDEJDLFLA_codec);
				break;
			}
		}
	}
}
