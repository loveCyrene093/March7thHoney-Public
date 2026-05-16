using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GEOAAAOAPGK : IMessage<GEOAAAOAPGK>, IMessage, IEquatable<GEOAAAOAPGK>, IDeepCloneable<GEOAAAOAPGK>, IBufferMessage
{
	private static readonly MessageParser<GEOAAAOAPGK> _parser = new MessageParser<GEOAAAOAPGK>(() => new GEOAAAOAPGK());

	private UnknownFieldSet _unknownFields;

	public const int JOBIHKPLHENFieldNumber = 2;

	private static readonly FieldCodec<CCBKGJGNDCL> _repeated_jOBIHKPLHEN_codec = FieldCodec.ForMessage(18u, CCBKGJGNDCL.Parser);

	private readonly RepeatedField<CCBKGJGNDCL> jOBIHKPLHEN_ = new RepeatedField<CCBKGJGNDCL>();

	public const int IAHJJBPGOKBFieldNumber = 5;

	private static readonly FieldCodec<EINJLBBAGDL> _repeated_iAHJJBPGOKB_codec = FieldCodec.ForMessage(42u, EINJLBBAGDL.Parser);

	private readonly RepeatedField<EINJLBBAGDL> iAHJJBPGOKB_ = new RepeatedField<EINJLBBAGDL>();

	public const int FNFHHNFOEIMFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_fNFHHNFOEIM_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> fNFHHNFOEIM_ = new RepeatedField<uint>();

	public const int OAIKIFEKFLGFieldNumber = 15;

	private static readonly FieldCodec<JCCMGOOPHBO> _repeated_oAIKIFEKFLG_codec = FieldCodec.ForMessage(122u, JCCMGOOPHBO.Parser);

	private readonly RepeatedField<JCCMGOOPHBO> oAIKIFEKFLG_ = new RepeatedField<JCCMGOOPHBO>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GEOAAAOAPGK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GEOAAAOAPGKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CCBKGJGNDCL> JOBIHKPLHEN => jOBIHKPLHEN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EINJLBBAGDL> IAHJJBPGOKB => iAHJJBPGOKB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FNFHHNFOEIM => fNFHHNFOEIM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JCCMGOOPHBO> OAIKIFEKFLG => oAIKIFEKFLG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GEOAAAOAPGK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GEOAAAOAPGK(GEOAAAOAPGK other)
		: this()
	{
		jOBIHKPLHEN_ = other.jOBIHKPLHEN_.Clone();
		iAHJJBPGOKB_ = other.iAHJJBPGOKB_.Clone();
		fNFHHNFOEIM_ = other.fNFHHNFOEIM_.Clone();
		oAIKIFEKFLG_ = other.oAIKIFEKFLG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GEOAAAOAPGK Clone()
	{
		return new GEOAAAOAPGK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GEOAAAOAPGK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GEOAAAOAPGK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jOBIHKPLHEN_.Equals(other.jOBIHKPLHEN_))
		{
			return false;
		}
		if (!iAHJJBPGOKB_.Equals(other.iAHJJBPGOKB_))
		{
			return false;
		}
		if (!fNFHHNFOEIM_.Equals(other.fNFHHNFOEIM_))
		{
			return false;
		}
		if (!oAIKIFEKFLG_.Equals(other.oAIKIFEKFLG_))
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
		num ^= jOBIHKPLHEN_.GetHashCode();
		num ^= iAHJJBPGOKB_.GetHashCode();
		num ^= fNFHHNFOEIM_.GetHashCode();
		num ^= oAIKIFEKFLG_.GetHashCode();
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
		jOBIHKPLHEN_.WriteTo(ref output, _repeated_jOBIHKPLHEN_codec);
		iAHJJBPGOKB_.WriteTo(ref output, _repeated_iAHJJBPGOKB_codec);
		fNFHHNFOEIM_.WriteTo(ref output, _repeated_fNFHHNFOEIM_codec);
		oAIKIFEKFLG_.WriteTo(ref output, _repeated_oAIKIFEKFLG_codec);
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
		num += jOBIHKPLHEN_.CalculateSize(_repeated_jOBIHKPLHEN_codec);
		num += iAHJJBPGOKB_.CalculateSize(_repeated_iAHJJBPGOKB_codec);
		num += fNFHHNFOEIM_.CalculateSize(_repeated_fNFHHNFOEIM_codec);
		num += oAIKIFEKFLG_.CalculateSize(_repeated_oAIKIFEKFLG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GEOAAAOAPGK other)
	{
		if (other != null)
		{
			jOBIHKPLHEN_.Add(other.jOBIHKPLHEN_);
			iAHJJBPGOKB_.Add(other.iAHJJBPGOKB_);
			fNFHHNFOEIM_.Add(other.fNFHHNFOEIM_);
			oAIKIFEKFLG_.Add(other.oAIKIFEKFLG_);
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
			case 18u:
				jOBIHKPLHEN_.AddEntriesFrom(ref input, _repeated_jOBIHKPLHEN_codec);
				break;
			case 42u:
				iAHJJBPGOKB_.AddEntriesFrom(ref input, _repeated_iAHJJBPGOKB_codec);
				break;
			case 56u:
			case 58u:
				fNFHHNFOEIM_.AddEntriesFrom(ref input, _repeated_fNFHHNFOEIM_codec);
				break;
			case 122u:
				oAIKIFEKFLG_.AddEntriesFrom(ref input, _repeated_oAIKIFEKFLG_codec);
				break;
			}
		}
	}
}
