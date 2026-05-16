using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DOGGIDNINJP : IMessage<DOGGIDNINJP>, IMessage, IEquatable<DOGGIDNINJP>, IDeepCloneable<DOGGIDNINJP>, IBufferMessage
{
	private static readonly MessageParser<DOGGIDNINJP> _parser = new MessageParser<DOGGIDNINJP>(() => new DOGGIDNINJP());

	private UnknownFieldSet _unknownFields;

	public const int IMPOEHIOCBCFieldNumber = 2;

	private ILLBNKFBNBP iMPOEHIOCBC_;

	public const int NENCLFJDCDAFieldNumber = 6;

	private static readonly FieldCodec<AMKDEKMDENG> _repeated_nENCLFJDCDA_codec = FieldCodec.ForMessage(50u, AMKDEKMDENG.Parser);

	private readonly RepeatedField<AMKDEKMDENG> nENCLFJDCDA_ = new RepeatedField<AMKDEKMDENG>();

	public const int NMHNGINKOKNFieldNumber = 9;

	private static readonly MapField<uint, uint>.Codec _map_nMHNGINKOKN_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 74u);

	private readonly MapField<uint, uint> nMHNGINKOKN_ = new MapField<uint, uint>();

	public const int IEKOBDGHNPJFieldNumber = 15;

	private static readonly FieldCodec<EIPPGFCFJEO> _repeated_iEKOBDGHNPJ_codec = FieldCodec.ForMessage(122u, EIPPGFCFJEO.Parser);

	private readonly RepeatedField<EIPPGFCFJEO> iEKOBDGHNPJ_ = new RepeatedField<EIPPGFCFJEO>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DOGGIDNINJP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DOGGIDNINJPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILLBNKFBNBP IMPOEHIOCBC
	{
		get
		{
			return iMPOEHIOCBC_;
		}
		set
		{
			iMPOEHIOCBC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AMKDEKMDENG> NENCLFJDCDA => nENCLFJDCDA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> NMHNGINKOKN => nMHNGINKOKN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EIPPGFCFJEO> IEKOBDGHNPJ => iEKOBDGHNPJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOGGIDNINJP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOGGIDNINJP(DOGGIDNINJP other)
		: this()
	{
		iMPOEHIOCBC_ = ((other.iMPOEHIOCBC_ != null) ? other.iMPOEHIOCBC_.Clone() : null);
		nENCLFJDCDA_ = other.nENCLFJDCDA_.Clone();
		nMHNGINKOKN_ = other.nMHNGINKOKN_.Clone();
		iEKOBDGHNPJ_ = other.iEKOBDGHNPJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DOGGIDNINJP Clone()
	{
		return new DOGGIDNINJP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DOGGIDNINJP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DOGGIDNINJP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(IMPOEHIOCBC, other.IMPOEHIOCBC))
		{
			return false;
		}
		if (!nENCLFJDCDA_.Equals(other.nENCLFJDCDA_))
		{
			return false;
		}
		if (!NMHNGINKOKN.Equals(other.NMHNGINKOKN))
		{
			return false;
		}
		if (!iEKOBDGHNPJ_.Equals(other.iEKOBDGHNPJ_))
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
		if (iMPOEHIOCBC_ != null)
		{
			num ^= IMPOEHIOCBC.GetHashCode();
		}
		num ^= nENCLFJDCDA_.GetHashCode();
		num ^= NMHNGINKOKN.GetHashCode();
		num ^= iEKOBDGHNPJ_.GetHashCode();
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
		if (iMPOEHIOCBC_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(IMPOEHIOCBC);
		}
		nENCLFJDCDA_.WriteTo(ref output, _repeated_nENCLFJDCDA_codec);
		nMHNGINKOKN_.WriteTo(ref output, _map_nMHNGINKOKN_codec);
		iEKOBDGHNPJ_.WriteTo(ref output, _repeated_iEKOBDGHNPJ_codec);
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
		if (iMPOEHIOCBC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IMPOEHIOCBC);
		}
		num += nENCLFJDCDA_.CalculateSize(_repeated_nENCLFJDCDA_codec);
		num += nMHNGINKOKN_.CalculateSize(_map_nMHNGINKOKN_codec);
		num += iEKOBDGHNPJ_.CalculateSize(_repeated_iEKOBDGHNPJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DOGGIDNINJP other)
	{
		if (other == null)
		{
			return;
		}
		if (other.iMPOEHIOCBC_ != null)
		{
			if (iMPOEHIOCBC_ == null)
			{
				IMPOEHIOCBC = new ILLBNKFBNBP();
			}
			IMPOEHIOCBC.MergeFrom(other.IMPOEHIOCBC);
		}
		nENCLFJDCDA_.Add(other.nENCLFJDCDA_);
		nMHNGINKOKN_.MergeFrom(other.nMHNGINKOKN_);
		iEKOBDGHNPJ_.Add(other.iEKOBDGHNPJ_);
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
			case 18u:
				if (iMPOEHIOCBC_ == null)
				{
					IMPOEHIOCBC = new ILLBNKFBNBP();
				}
				input.ReadMessage(IMPOEHIOCBC);
				break;
			case 50u:
				nENCLFJDCDA_.AddEntriesFrom(ref input, _repeated_nENCLFJDCDA_codec);
				break;
			case 74u:
				nMHNGINKOKN_.AddEntriesFrom(ref input, _map_nMHNGINKOKN_codec);
				break;
			case 122u:
				iEKOBDGHNPJ_.AddEntriesFrom(ref input, _repeated_iEKOBDGHNPJ_codec);
				break;
			}
		}
	}
}
