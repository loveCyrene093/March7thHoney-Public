using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CGDFGMMKJAH : IMessage<CGDFGMMKJAH>, IMessage, IEquatable<CGDFGMMKJAH>, IDeepCloneable<CGDFGMMKJAH>, IBufferMessage
{
	private static readonly MessageParser<CGDFGMMKJAH> _parser = new MessageParser<CGDFGMMKJAH>(() => new CGDFGMMKJAH());

	private UnknownFieldSet _unknownFields;

	public const int JHCMEALPDEBFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_jHCMEALPDEB_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> jHCMEALPDEB_ = new RepeatedField<uint>();

	public const int IdFieldNumber = 4;

	private uint id_;

	public const int INGCDIAFAFGFieldNumber = 6;

	private uint iNGCDIAFAFG_;

	public const int GFGGMLNLGCAFieldNumber = 7;

	private uint gFGGMLNLGCA_;

	public const int LHJEJEPGKFHFieldNumber = 8;

	private uint lHJEJEPGKFH_;

	public const int HKFHEOMPPLJFieldNumber = 10;

	private PLMPLHKEJLL hKFHEOMPPLJ_;

	public const int OCFJLOCIFBNFieldNumber = 11;

	private int oCFJLOCIFBN_;

	public const int KKNNBAGFFGLFieldNumber = 12;

	private int kKNNBAGFFGL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CGDFGMMKJAH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CGDFGMMKJAHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JHCMEALPDEB => jHCMEALPDEB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint INGCDIAFAFG
	{
		get
		{
			return iNGCDIAFAFG_;
		}
		set
		{
			iNGCDIAFAFG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GFGGMLNLGCA
	{
		get
		{
			return gFGGMLNLGCA_;
		}
		set
		{
			gFGGMLNLGCA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LHJEJEPGKFH
	{
		get
		{
			return lHJEJEPGKFH_;
		}
		set
		{
			lHJEJEPGKFH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PLMPLHKEJLL HKFHEOMPPLJ
	{
		get
		{
			return hKFHEOMPPLJ_;
		}
		set
		{
			hKFHEOMPPLJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int OCFJLOCIFBN
	{
		get
		{
			return oCFJLOCIFBN_;
		}
		set
		{
			oCFJLOCIFBN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int KKNNBAGFFGL
	{
		get
		{
			return kKNNBAGFFGL_;
		}
		set
		{
			kKNNBAGFFGL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGDFGMMKJAH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGDFGMMKJAH(CGDFGMMKJAH other)
		: this()
	{
		jHCMEALPDEB_ = other.jHCMEALPDEB_.Clone();
		id_ = other.id_;
		iNGCDIAFAFG_ = other.iNGCDIAFAFG_;
		gFGGMLNLGCA_ = other.gFGGMLNLGCA_;
		lHJEJEPGKFH_ = other.lHJEJEPGKFH_;
		hKFHEOMPPLJ_ = ((other.hKFHEOMPPLJ_ != null) ? other.hKFHEOMPPLJ_.Clone() : null);
		oCFJLOCIFBN_ = other.oCFJLOCIFBN_;
		kKNNBAGFFGL_ = other.kKNNBAGFFGL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGDFGMMKJAH Clone()
	{
		return new CGDFGMMKJAH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CGDFGMMKJAH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CGDFGMMKJAH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jHCMEALPDEB_.Equals(other.jHCMEALPDEB_))
		{
			return false;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (INGCDIAFAFG != other.INGCDIAFAFG)
		{
			return false;
		}
		if (GFGGMLNLGCA != other.GFGGMLNLGCA)
		{
			return false;
		}
		if (LHJEJEPGKFH != other.LHJEJEPGKFH)
		{
			return false;
		}
		if (!object.Equals(HKFHEOMPPLJ, other.HKFHEOMPPLJ))
		{
			return false;
		}
		if (OCFJLOCIFBN != other.OCFJLOCIFBN)
		{
			return false;
		}
		if (KKNNBAGFFGL != other.KKNNBAGFFGL)
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
		num ^= jHCMEALPDEB_.GetHashCode();
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (INGCDIAFAFG != 0)
		{
			num ^= INGCDIAFAFG.GetHashCode();
		}
		if (GFGGMLNLGCA != 0)
		{
			num ^= GFGGMLNLGCA.GetHashCode();
		}
		if (LHJEJEPGKFH != 0)
		{
			num ^= LHJEJEPGKFH.GetHashCode();
		}
		if (hKFHEOMPPLJ_ != null)
		{
			num ^= HKFHEOMPPLJ.GetHashCode();
		}
		if (OCFJLOCIFBN != 0)
		{
			num ^= OCFJLOCIFBN.GetHashCode();
		}
		if (KKNNBAGFFGL != 0)
		{
			num ^= KKNNBAGFFGL.GetHashCode();
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
		jHCMEALPDEB_.WriteTo(ref output, _repeated_jHCMEALPDEB_codec);
		if (Id != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Id);
		}
		if (INGCDIAFAFG != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(INGCDIAFAFG);
		}
		if (GFGGMLNLGCA != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(GFGGMLNLGCA);
		}
		if (LHJEJEPGKFH != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(LHJEJEPGKFH);
		}
		if (hKFHEOMPPLJ_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(HKFHEOMPPLJ);
		}
		if (OCFJLOCIFBN != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(OCFJLOCIFBN);
		}
		if (KKNNBAGFFGL != 0)
		{
			output.WriteRawTag(96);
			output.WriteInt32(KKNNBAGFFGL);
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
		num += jHCMEALPDEB_.CalculateSize(_repeated_jHCMEALPDEB_codec);
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (INGCDIAFAFG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(INGCDIAFAFG);
		}
		if (GFGGMLNLGCA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GFGGMLNLGCA);
		}
		if (LHJEJEPGKFH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LHJEJEPGKFH);
		}
		if (hKFHEOMPPLJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HKFHEOMPPLJ);
		}
		if (OCFJLOCIFBN != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(OCFJLOCIFBN);
		}
		if (KKNNBAGFFGL != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(KKNNBAGFFGL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CGDFGMMKJAH other)
	{
		if (other == null)
		{
			return;
		}
		jHCMEALPDEB_.Add(other.jHCMEALPDEB_);
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.INGCDIAFAFG != 0)
		{
			INGCDIAFAFG = other.INGCDIAFAFG;
		}
		if (other.GFGGMLNLGCA != 0)
		{
			GFGGMLNLGCA = other.GFGGMLNLGCA;
		}
		if (other.LHJEJEPGKFH != 0)
		{
			LHJEJEPGKFH = other.LHJEJEPGKFH;
		}
		if (other.hKFHEOMPPLJ_ != null)
		{
			if (hKFHEOMPPLJ_ == null)
			{
				HKFHEOMPPLJ = new PLMPLHKEJLL();
			}
			HKFHEOMPPLJ.MergeFrom(other.HKFHEOMPPLJ);
		}
		if (other.OCFJLOCIFBN != 0)
		{
			OCFJLOCIFBN = other.OCFJLOCIFBN;
		}
		if (other.KKNNBAGFFGL != 0)
		{
			KKNNBAGFFGL = other.KKNNBAGFFGL;
		}
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
			case 16u:
			case 18u:
				jHCMEALPDEB_.AddEntriesFrom(ref input, _repeated_jHCMEALPDEB_codec);
				break;
			case 32u:
				Id = input.ReadUInt32();
				break;
			case 48u:
				INGCDIAFAFG = input.ReadUInt32();
				break;
			case 56u:
				GFGGMLNLGCA = input.ReadUInt32();
				break;
			case 64u:
				LHJEJEPGKFH = input.ReadUInt32();
				break;
			case 82u:
				if (hKFHEOMPPLJ_ == null)
				{
					HKFHEOMPPLJ = new PLMPLHKEJLL();
				}
				input.ReadMessage(HKFHEOMPPLJ);
				break;
			case 88u:
				OCFJLOCIFBN = input.ReadInt32();
				break;
			case 96u:
				KKNNBAGFFGL = input.ReadInt32();
				break;
			}
		}
	}
}
