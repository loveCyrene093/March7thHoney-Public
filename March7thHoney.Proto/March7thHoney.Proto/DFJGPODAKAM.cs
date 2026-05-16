using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DFJGPODAKAM : IMessage<DFJGPODAKAM>, IMessage, IEquatable<DFJGPODAKAM>, IDeepCloneable<DFJGPODAKAM>, IBufferMessage
{
	private static readonly MessageParser<DFJGPODAKAM> _parser = new MessageParser<DFJGPODAKAM>(() => new DFJGPODAKAM());

	private UnknownFieldSet _unknownFields;

	public const int ILEMMKPGPNDFieldNumber = 1;

	private uint iLEMMKPGPND_;

	public const int NKGIGKEBODGFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_nKGIGKEBODG_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> nKGIGKEBODG_ = new RepeatedField<uint>();

	public const int GridFightEquipmentListFieldNumber = 3;

	private static readonly FieldCodec<APCNLFANPEP> _repeated_gridFightEquipmentList_codec = FieldCodec.ForMessage(26u, APCNLFANPEP.Parser);

	private readonly RepeatedField<APCNLFANPEP> gridFightEquipmentList_ = new RepeatedField<APCNLFANPEP>();

	public const int OPLJDFOOMGFFieldNumber = 4;

	private static readonly MapField<string, int>.Codec _map_oPLJDFOOMGF_codec = new MapField<string, int>.Codec(FieldCodec.ForString(10u, ""), FieldCodec.ForInt32(16u, 0), 34u);

	private readonly MapField<string, int> oPLJDFOOMGF_ = new MapField<string, int>();

	public const int FDJMJOKGOMFFieldNumber = 5;

	private static readonly FieldCodec<CMHAMBKCJBK> _repeated_fDJMJOKGOMF_codec = FieldCodec.ForMessage(42u, CMHAMBKCJBK.Parser);

	private readonly RepeatedField<CMHAMBKCJBK> fDJMJOKGOMF_ = new RepeatedField<CMHAMBKCJBK>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DFJGPODAKAM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DFJGPODAKAMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ILEMMKPGPND
	{
		get
		{
			return iLEMMKPGPND_;
		}
		set
		{
			iLEMMKPGPND_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NKGIGKEBODG => nKGIGKEBODG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<APCNLFANPEP> GridFightEquipmentList => gridFightEquipmentList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, int> OPLJDFOOMGF => oPLJDFOOMGF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<CMHAMBKCJBK> FDJMJOKGOMF => fDJMJOKGOMF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFJGPODAKAM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFJGPODAKAM(DFJGPODAKAM other)
		: this()
	{
		iLEMMKPGPND_ = other.iLEMMKPGPND_;
		nKGIGKEBODG_ = other.nKGIGKEBODG_.Clone();
		gridFightEquipmentList_ = other.gridFightEquipmentList_.Clone();
		oPLJDFOOMGF_ = other.oPLJDFOOMGF_.Clone();
		fDJMJOKGOMF_ = other.fDJMJOKGOMF_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFJGPODAKAM Clone()
	{
		return new DFJGPODAKAM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DFJGPODAKAM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DFJGPODAKAM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ILEMMKPGPND != other.ILEMMKPGPND)
		{
			return false;
		}
		if (!nKGIGKEBODG_.Equals(other.nKGIGKEBODG_))
		{
			return false;
		}
		if (!gridFightEquipmentList_.Equals(other.gridFightEquipmentList_))
		{
			return false;
		}
		if (!OPLJDFOOMGF.Equals(other.OPLJDFOOMGF))
		{
			return false;
		}
		if (!fDJMJOKGOMF_.Equals(other.fDJMJOKGOMF_))
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
		if (ILEMMKPGPND != 0)
		{
			num ^= ILEMMKPGPND.GetHashCode();
		}
		num ^= nKGIGKEBODG_.GetHashCode();
		num ^= gridFightEquipmentList_.GetHashCode();
		num ^= OPLJDFOOMGF.GetHashCode();
		num ^= fDJMJOKGOMF_.GetHashCode();
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
		if (ILEMMKPGPND != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(ILEMMKPGPND);
		}
		nKGIGKEBODG_.WriteTo(ref output, _repeated_nKGIGKEBODG_codec);
		gridFightEquipmentList_.WriteTo(ref output, _repeated_gridFightEquipmentList_codec);
		oPLJDFOOMGF_.WriteTo(ref output, _map_oPLJDFOOMGF_codec);
		fDJMJOKGOMF_.WriteTo(ref output, _repeated_fDJMJOKGOMF_codec);
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
		if (ILEMMKPGPND != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ILEMMKPGPND);
		}
		num += nKGIGKEBODG_.CalculateSize(_repeated_nKGIGKEBODG_codec);
		num += gridFightEquipmentList_.CalculateSize(_repeated_gridFightEquipmentList_codec);
		num += oPLJDFOOMGF_.CalculateSize(_map_oPLJDFOOMGF_codec);
		num += fDJMJOKGOMF_.CalculateSize(_repeated_fDJMJOKGOMF_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DFJGPODAKAM other)
	{
		if (other != null)
		{
			if (other.ILEMMKPGPND != 0)
			{
				ILEMMKPGPND = other.ILEMMKPGPND;
			}
			nKGIGKEBODG_.Add(other.nKGIGKEBODG_);
			gridFightEquipmentList_.Add(other.gridFightEquipmentList_);
			oPLJDFOOMGF_.MergeFrom(other.oPLJDFOOMGF_);
			fDJMJOKGOMF_.Add(other.fDJMJOKGOMF_);
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
			case 8u:
				ILEMMKPGPND = input.ReadUInt32();
				break;
			case 16u:
			case 18u:
				nKGIGKEBODG_.AddEntriesFrom(ref input, _repeated_nKGIGKEBODG_codec);
				break;
			case 26u:
				gridFightEquipmentList_.AddEntriesFrom(ref input, _repeated_gridFightEquipmentList_codec);
				break;
			case 34u:
				oPLJDFOOMGF_.AddEntriesFrom(ref input, _map_oPLJDFOOMGF_codec);
				break;
			case 42u:
				fDJMJOKGOMF_.AddEntriesFrom(ref input, _repeated_fDJMJOKGOMF_codec);
				break;
			}
		}
	}
}
