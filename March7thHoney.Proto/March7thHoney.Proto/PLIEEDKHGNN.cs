using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PLIEEDKHGNN : IMessage<PLIEEDKHGNN>, IMessage, IEquatable<PLIEEDKHGNN>, IDeepCloneable<PLIEEDKHGNN>, IBufferMessage
{
	private static readonly MessageParser<PLIEEDKHGNN> _parser = new MessageParser<PLIEEDKHGNN>(() => new PLIEEDKHGNN());

	private UnknownFieldSet _unknownFields;

	public const int DGLIPLAHMBFFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_dGLIPLAHMBF_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> dGLIPLAHMBF_ = new RepeatedField<uint>();

	public const int CAJCAGNBGEKFieldNumber = 5;

	private bool cAJCAGNBGEK_;

	public const int HCAFCGKLKFDFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_hCAFCGKLKFD_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> hCAFCGKLKFD_ = new RepeatedField<uint>();

	public const int ADDEMHFJJAHFieldNumber = 9;

	private uint aDDEMHFJJAH_;

	public const int JLDPAIPAMNBFieldNumber = 13;

	private uint jLDPAIPAMNB_;

	public const int BMGEBFHHCODFieldNumber = 15;

	private uint bMGEBFHHCOD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PLIEEDKHGNN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PLIEEDKHGNNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DGLIPLAHMBF => dGLIPLAHMBF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CAJCAGNBGEK
	{
		get
		{
			return cAJCAGNBGEK_;
		}
		set
		{
			cAJCAGNBGEK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> HCAFCGKLKFD => hCAFCGKLKFD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ADDEMHFJJAH
	{
		get
		{
			return aDDEMHFJJAH_;
		}
		set
		{
			aDDEMHFJJAH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JLDPAIPAMNB
	{
		get
		{
			return jLDPAIPAMNB_;
		}
		set
		{
			jLDPAIPAMNB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BMGEBFHHCOD
	{
		get
		{
			return bMGEBFHHCOD_;
		}
		set
		{
			bMGEBFHHCOD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLIEEDKHGNN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLIEEDKHGNN(PLIEEDKHGNN other)
		: this()
	{
		dGLIPLAHMBF_ = other.dGLIPLAHMBF_.Clone();
		cAJCAGNBGEK_ = other.cAJCAGNBGEK_;
		hCAFCGKLKFD_ = other.hCAFCGKLKFD_.Clone();
		aDDEMHFJJAH_ = other.aDDEMHFJJAH_;
		jLDPAIPAMNB_ = other.jLDPAIPAMNB_;
		bMGEBFHHCOD_ = other.bMGEBFHHCOD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLIEEDKHGNN Clone()
	{
		return new PLIEEDKHGNN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PLIEEDKHGNN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PLIEEDKHGNN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dGLIPLAHMBF_.Equals(other.dGLIPLAHMBF_))
		{
			return false;
		}
		if (CAJCAGNBGEK != other.CAJCAGNBGEK)
		{
			return false;
		}
		if (!hCAFCGKLKFD_.Equals(other.hCAFCGKLKFD_))
		{
			return false;
		}
		if (ADDEMHFJJAH != other.ADDEMHFJJAH)
		{
			return false;
		}
		if (JLDPAIPAMNB != other.JLDPAIPAMNB)
		{
			return false;
		}
		if (BMGEBFHHCOD != other.BMGEBFHHCOD)
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
		num ^= dGLIPLAHMBF_.GetHashCode();
		if (CAJCAGNBGEK)
		{
			num ^= CAJCAGNBGEK.GetHashCode();
		}
		num ^= hCAFCGKLKFD_.GetHashCode();
		if (ADDEMHFJJAH != 0)
		{
			num ^= ADDEMHFJJAH.GetHashCode();
		}
		if (JLDPAIPAMNB != 0)
		{
			num ^= JLDPAIPAMNB.GetHashCode();
		}
		if (BMGEBFHHCOD != 0)
		{
			num ^= BMGEBFHHCOD.GetHashCode();
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
		dGLIPLAHMBF_.WriteTo(ref output, _repeated_dGLIPLAHMBF_codec);
		if (CAJCAGNBGEK)
		{
			output.WriteRawTag(40);
			output.WriteBool(CAJCAGNBGEK);
		}
		hCAFCGKLKFD_.WriteTo(ref output, _repeated_hCAFCGKLKFD_codec);
		if (ADDEMHFJJAH != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(ADDEMHFJJAH);
		}
		if (JLDPAIPAMNB != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(JLDPAIPAMNB);
		}
		if (BMGEBFHHCOD != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(BMGEBFHHCOD);
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
		num += dGLIPLAHMBF_.CalculateSize(_repeated_dGLIPLAHMBF_codec);
		if (CAJCAGNBGEK)
		{
			num += 2;
		}
		num += hCAFCGKLKFD_.CalculateSize(_repeated_hCAFCGKLKFD_codec);
		if (ADDEMHFJJAH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ADDEMHFJJAH);
		}
		if (JLDPAIPAMNB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JLDPAIPAMNB);
		}
		if (BMGEBFHHCOD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BMGEBFHHCOD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PLIEEDKHGNN other)
	{
		if (other != null)
		{
			dGLIPLAHMBF_.Add(other.dGLIPLAHMBF_);
			if (other.CAJCAGNBGEK)
			{
				CAJCAGNBGEK = other.CAJCAGNBGEK;
			}
			hCAFCGKLKFD_.Add(other.hCAFCGKLKFD_);
			if (other.ADDEMHFJJAH != 0)
			{
				ADDEMHFJJAH = other.ADDEMHFJJAH;
			}
			if (other.JLDPAIPAMNB != 0)
			{
				JLDPAIPAMNB = other.JLDPAIPAMNB;
			}
			if (other.BMGEBFHHCOD != 0)
			{
				BMGEBFHHCOD = other.BMGEBFHHCOD;
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
			case 8u:
			case 10u:
				dGLIPLAHMBF_.AddEntriesFrom(ref input, _repeated_dGLIPLAHMBF_codec);
				break;
			case 40u:
				CAJCAGNBGEK = input.ReadBool();
				break;
			case 56u:
			case 58u:
				hCAFCGKLKFD_.AddEntriesFrom(ref input, _repeated_hCAFCGKLKFD_codec);
				break;
			case 72u:
				ADDEMHFJJAH = input.ReadUInt32();
				break;
			case 104u:
				JLDPAIPAMNB = input.ReadUInt32();
				break;
			case 120u:
				BMGEBFHHCOD = input.ReadUInt32();
				break;
			}
		}
	}
}
