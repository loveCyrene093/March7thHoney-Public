using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OOFLDCDHLDL : IMessage<OOFLDCDHLDL>, IMessage, IEquatable<OOFLDCDHLDL>, IDeepCloneable<OOFLDCDHLDL>, IBufferMessage
{
	private static readonly MessageParser<OOFLDCDHLDL> _parser = new MessageParser<OOFLDCDHLDL>(() => new OOFLDCDHLDL());

	private UnknownFieldSet _unknownFields;

	public const int POFOCMIHJIAFieldNumber = 3;

	private JLGNKMBMPKL pOFOCMIHJIA_;

	public const int BIEBFHECEPMFieldNumber = 13;

	private static readonly FieldCodec<ADHNJADIJAC> _repeated_bIEBFHECEPM_codec = FieldCodec.ForMessage(106u, ADHNJADIJAC.Parser);

	private readonly RepeatedField<ADHNJADIJAC> bIEBFHECEPM_ = new RepeatedField<ADHNJADIJAC>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OOFLDCDHLDL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OOFLDCDHLDLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLGNKMBMPKL POFOCMIHJIA
	{
		get
		{
			return pOFOCMIHJIA_;
		}
		set
		{
			pOFOCMIHJIA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ADHNJADIJAC> BIEBFHECEPM => bIEBFHECEPM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOFLDCDHLDL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOFLDCDHLDL(OOFLDCDHLDL other)
		: this()
	{
		pOFOCMIHJIA_ = ((other.pOFOCMIHJIA_ != null) ? other.pOFOCMIHJIA_.Clone() : null);
		bIEBFHECEPM_ = other.bIEBFHECEPM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOFLDCDHLDL Clone()
	{
		return new OOFLDCDHLDL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OOFLDCDHLDL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OOFLDCDHLDL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(POFOCMIHJIA, other.POFOCMIHJIA))
		{
			return false;
		}
		if (!bIEBFHECEPM_.Equals(other.bIEBFHECEPM_))
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
		if (pOFOCMIHJIA_ != null)
		{
			num ^= POFOCMIHJIA.GetHashCode();
		}
		num ^= bIEBFHECEPM_.GetHashCode();
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
		if (pOFOCMIHJIA_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(POFOCMIHJIA);
		}
		bIEBFHECEPM_.WriteTo(ref output, _repeated_bIEBFHECEPM_codec);
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
		if (pOFOCMIHJIA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(POFOCMIHJIA);
		}
		num += bIEBFHECEPM_.CalculateSize(_repeated_bIEBFHECEPM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OOFLDCDHLDL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.pOFOCMIHJIA_ != null)
		{
			if (pOFOCMIHJIA_ == null)
			{
				POFOCMIHJIA = new JLGNKMBMPKL();
			}
			POFOCMIHJIA.MergeFrom(other.POFOCMIHJIA);
		}
		bIEBFHECEPM_.Add(other.bIEBFHECEPM_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
				if (pOFOCMIHJIA_ == null)
				{
					POFOCMIHJIA = new JLGNKMBMPKL();
				}
				input.ReadMessage(POFOCMIHJIA);
				break;
			case 106u:
				bIEBFHECEPM_.AddEntriesFrom(ref input, _repeated_bIEBFHECEPM_codec);
				break;
			}
		}
	}
}
