using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FOFNOBHLKGO : IMessage<FOFNOBHLKGO>, IMessage, IEquatable<FOFNOBHLKGO>, IDeepCloneable<FOFNOBHLKGO>, IBufferMessage
{
	private static readonly MessageParser<FOFNOBHLKGO> _parser = new MessageParser<FOFNOBHLKGO>(() => new FOFNOBHLKGO());

	private UnknownFieldSet _unknownFields;

	public const int OJNJEDBBAJJFieldNumber = 1;

	private static readonly FieldCodec<BIAIKHBFALH> _repeated_oJNJEDBBAJJ_codec = FieldCodec.ForMessage(10u, BIAIKHBFALH.Parser);

	private readonly RepeatedField<BIAIKHBFALH> oJNJEDBBAJJ_ = new RepeatedField<BIAIKHBFALH>();

	public const int LKPGMBDBJFAFieldNumber = 2;

	private static readonly FieldCodec<GFAHEGCPIEB> _repeated_lKPGMBDBJFA_codec = FieldCodec.ForMessage(18u, GFAHEGCPIEB.Parser);

	private readonly RepeatedField<GFAHEGCPIEB> lKPGMBDBJFA_ = new RepeatedField<GFAHEGCPIEB>();

	public const int MIPPCFJPJDDFieldNumber = 3;

	private HEAJBHNMJGO mIPPCFJPJDD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FOFNOBHLKGO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FOFNOBHLKGOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BIAIKHBFALH> OJNJEDBBAJJ => oJNJEDBBAJJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GFAHEGCPIEB> LKPGMBDBJFA => lKPGMBDBJFA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HEAJBHNMJGO MIPPCFJPJDD
	{
		get
		{
			return mIPPCFJPJDD_;
		}
		set
		{
			mIPPCFJPJDD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FOFNOBHLKGO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FOFNOBHLKGO(FOFNOBHLKGO other)
		: this()
	{
		oJNJEDBBAJJ_ = other.oJNJEDBBAJJ_.Clone();
		lKPGMBDBJFA_ = other.lKPGMBDBJFA_.Clone();
		mIPPCFJPJDD_ = other.mIPPCFJPJDD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FOFNOBHLKGO Clone()
	{
		return new FOFNOBHLKGO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FOFNOBHLKGO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FOFNOBHLKGO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!oJNJEDBBAJJ_.Equals(other.oJNJEDBBAJJ_))
		{
			return false;
		}
		if (!lKPGMBDBJFA_.Equals(other.lKPGMBDBJFA_))
		{
			return false;
		}
		if (MIPPCFJPJDD != other.MIPPCFJPJDD)
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
		num ^= oJNJEDBBAJJ_.GetHashCode();
		num ^= lKPGMBDBJFA_.GetHashCode();
		if (MIPPCFJPJDD != HEAJBHNMJGO.Ofghjkihmib)
		{
			num ^= MIPPCFJPJDD.GetHashCode();
		}
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
		oJNJEDBBAJJ_.WriteTo(ref output, _repeated_oJNJEDBBAJJ_codec);
		lKPGMBDBJFA_.WriteTo(ref output, _repeated_lKPGMBDBJFA_codec);
		if (MIPPCFJPJDD != HEAJBHNMJGO.Ofghjkihmib)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)MIPPCFJPJDD);
		}
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
		num += oJNJEDBBAJJ_.CalculateSize(_repeated_oJNJEDBBAJJ_codec);
		num += lKPGMBDBJFA_.CalculateSize(_repeated_lKPGMBDBJFA_codec);
		if (MIPPCFJPJDD != HEAJBHNMJGO.Ofghjkihmib)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MIPPCFJPJDD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FOFNOBHLKGO other)
	{
		if (other != null)
		{
			oJNJEDBBAJJ_.Add(other.oJNJEDBBAJJ_);
			lKPGMBDBJFA_.Add(other.lKPGMBDBJFA_);
			if (other.MIPPCFJPJDD != HEAJBHNMJGO.Ofghjkihmib)
			{
				MIPPCFJPJDD = other.MIPPCFJPJDD;
			}
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
			case 10u:
				oJNJEDBBAJJ_.AddEntriesFrom(ref input, _repeated_oJNJEDBBAJJ_codec);
				break;
			case 18u:
				lKPGMBDBJFA_.AddEntriesFrom(ref input, _repeated_lKPGMBDBJFA_codec);
				break;
			case 24u:
				MIPPCFJPJDD = (HEAJBHNMJGO)input.ReadEnum();
				break;
			}
		}
	}
}
