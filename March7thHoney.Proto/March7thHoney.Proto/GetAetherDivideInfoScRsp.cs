using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetAetherDivideInfoScRsp : IMessage<GetAetherDivideInfoScRsp>, IMessage, IEquatable<GetAetherDivideInfoScRsp>, IDeepCloneable<GetAetherDivideInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetAetherDivideInfoScRsp> _parser = new MessageParser<GetAetherDivideInfoScRsp>(() => new GetAetherDivideInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int KBFFBPDDCFFFieldNumber = 1;

	private uint kBFFBPDDCFF_;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int OJPJPOGDLNOFieldNumber = 4;

	private uint oJPJPOGDLNO_;

	public const int GONOOOEHHLOFieldNumber = 5;

	private static readonly FieldCodec<KNHKBHADJGE> _repeated_gONOOOEHHLO_codec = FieldCodec.ForMessage(42u, KNHKBHADJGE.Parser);

	private readonly RepeatedField<KNHKBHADJGE> gONOOOEHHLO_ = new RepeatedField<KNHKBHADJGE>();

	public const int LineupListFieldNumber = 6;

	private static readonly FieldCodec<DLGFPMKPLEO> _repeated_lineupList_codec = FieldCodec.ForMessage(50u, DLGFPMKPLEO.Parser);

	private readonly RepeatedField<DLGFPMKPLEO> lineupList_ = new RepeatedField<DLGFPMKPLEO>();

	public const int FIKLLOCJBGNFieldNumber = 8;

	private uint fIKLLOCJBGN_;

	public const int CFCFCEBNAEFFieldNumber = 11;

	private uint cFCFCEBNAEF_;

	public const int OAMPGNHJIGDFieldNumber = 12;

	private uint oAMPGNHJIGD_;

	public const int PHGLFHDDACMFieldNumber = 13;

	private static readonly FieldCodec<JBJIKJGEBAH> _repeated_pHGLFHDDACM_codec = FieldCodec.ForMessage(106u, JBJIKJGEBAH.Parser);

	private readonly RepeatedField<JBJIKJGEBAH> pHGLFHDDACM_ = new RepeatedField<JBJIKJGEBAH>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetAetherDivideInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetAetherDivideInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KBFFBPDDCFF
	{
		get
		{
			return kBFFBPDDCFF_;
		}
		set
		{
			kBFFBPDDCFF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OJPJPOGDLNO
	{
		get
		{
			return oJPJPOGDLNO_;
		}
		set
		{
			oJPJPOGDLNO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KNHKBHADJGE> GONOOOEHHLO => gONOOOEHHLO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DLGFPMKPLEO> LineupList => lineupList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FIKLLOCJBGN
	{
		get
		{
			return fIKLLOCJBGN_;
		}
		set
		{
			fIKLLOCJBGN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CFCFCEBNAEF
	{
		get
		{
			return cFCFCEBNAEF_;
		}
		set
		{
			cFCFCEBNAEF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OAMPGNHJIGD
	{
		get
		{
			return oAMPGNHJIGD_;
		}
		set
		{
			oAMPGNHJIGD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JBJIKJGEBAH> PHGLFHDDACM => pHGLFHDDACM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAetherDivideInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAetherDivideInfoScRsp(GetAetherDivideInfoScRsp other)
		: this()
	{
		kBFFBPDDCFF_ = other.kBFFBPDDCFF_;
		retcode_ = other.retcode_;
		oJPJPOGDLNO_ = other.oJPJPOGDLNO_;
		gONOOOEHHLO_ = other.gONOOOEHHLO_.Clone();
		lineupList_ = other.lineupList_.Clone();
		fIKLLOCJBGN_ = other.fIKLLOCJBGN_;
		cFCFCEBNAEF_ = other.cFCFCEBNAEF_;
		oAMPGNHJIGD_ = other.oAMPGNHJIGD_;
		pHGLFHDDACM_ = other.pHGLFHDDACM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetAetherDivideInfoScRsp Clone()
	{
		return new GetAetherDivideInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetAetherDivideInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetAetherDivideInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KBFFBPDDCFF != other.KBFFBPDDCFF)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (OJPJPOGDLNO != other.OJPJPOGDLNO)
		{
			return false;
		}
		if (!gONOOOEHHLO_.Equals(other.gONOOOEHHLO_))
		{
			return false;
		}
		if (!lineupList_.Equals(other.lineupList_))
		{
			return false;
		}
		if (FIKLLOCJBGN != other.FIKLLOCJBGN)
		{
			return false;
		}
		if (CFCFCEBNAEF != other.CFCFCEBNAEF)
		{
			return false;
		}
		if (OAMPGNHJIGD != other.OAMPGNHJIGD)
		{
			return false;
		}
		if (!pHGLFHDDACM_.Equals(other.pHGLFHDDACM_))
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
		if (KBFFBPDDCFF != 0)
		{
			num ^= KBFFBPDDCFF.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (OJPJPOGDLNO != 0)
		{
			num ^= OJPJPOGDLNO.GetHashCode();
		}
		num ^= gONOOOEHHLO_.GetHashCode();
		num ^= lineupList_.GetHashCode();
		if (FIKLLOCJBGN != 0)
		{
			num ^= FIKLLOCJBGN.GetHashCode();
		}
		if (CFCFCEBNAEF != 0)
		{
			num ^= CFCFCEBNAEF.GetHashCode();
		}
		if (OAMPGNHJIGD != 0)
		{
			num ^= OAMPGNHJIGD.GetHashCode();
		}
		num ^= pHGLFHDDACM_.GetHashCode();
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
		if (KBFFBPDDCFF != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(KBFFBPDDCFF);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		if (OJPJPOGDLNO != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(OJPJPOGDLNO);
		}
		gONOOOEHHLO_.WriteTo(ref output, _repeated_gONOOOEHHLO_codec);
		lineupList_.WriteTo(ref output, _repeated_lineupList_codec);
		if (FIKLLOCJBGN != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(FIKLLOCJBGN);
		}
		if (CFCFCEBNAEF != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(CFCFCEBNAEF);
		}
		if (OAMPGNHJIGD != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(OAMPGNHJIGD);
		}
		pHGLFHDDACM_.WriteTo(ref output, _repeated_pHGLFHDDACM_codec);
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
		if (KBFFBPDDCFF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KBFFBPDDCFF);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (OJPJPOGDLNO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OJPJPOGDLNO);
		}
		num += gONOOOEHHLO_.CalculateSize(_repeated_gONOOOEHHLO_codec);
		num += lineupList_.CalculateSize(_repeated_lineupList_codec);
		if (FIKLLOCJBGN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FIKLLOCJBGN);
		}
		if (CFCFCEBNAEF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CFCFCEBNAEF);
		}
		if (OAMPGNHJIGD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OAMPGNHJIGD);
		}
		num += pHGLFHDDACM_.CalculateSize(_repeated_pHGLFHDDACM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetAetherDivideInfoScRsp other)
	{
		if (other != null)
		{
			if (other.KBFFBPDDCFF != 0)
			{
				KBFFBPDDCFF = other.KBFFBPDDCFF;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.OJPJPOGDLNO != 0)
			{
				OJPJPOGDLNO = other.OJPJPOGDLNO;
			}
			gONOOOEHHLO_.Add(other.gONOOOEHHLO_);
			lineupList_.Add(other.lineupList_);
			if (other.FIKLLOCJBGN != 0)
			{
				FIKLLOCJBGN = other.FIKLLOCJBGN;
			}
			if (other.CFCFCEBNAEF != 0)
			{
				CFCFCEBNAEF = other.CFCFCEBNAEF;
			}
			if (other.OAMPGNHJIGD != 0)
			{
				OAMPGNHJIGD = other.OAMPGNHJIGD;
			}
			pHGLFHDDACM_.Add(other.pHGLFHDDACM_);
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
				KBFFBPDDCFF = input.ReadUInt32();
				break;
			case 16u:
				Retcode = input.ReadUInt32();
				break;
			case 32u:
				OJPJPOGDLNO = input.ReadUInt32();
				break;
			case 42u:
				gONOOOEHHLO_.AddEntriesFrom(ref input, _repeated_gONOOOEHHLO_codec);
				break;
			case 50u:
				lineupList_.AddEntriesFrom(ref input, _repeated_lineupList_codec);
				break;
			case 64u:
				FIKLLOCJBGN = input.ReadUInt32();
				break;
			case 88u:
				CFCFCEBNAEF = input.ReadUInt32();
				break;
			case 96u:
				OAMPGNHJIGD = input.ReadUInt32();
				break;
			case 106u:
				pHGLFHDDACM_.AddEntriesFrom(ref input, _repeated_pHGLFHDDACM_codec);
				break;
			}
		}
	}
}
