using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IENNMHMOONM : IMessage<IENNMHMOONM>, IMessage, IEquatable<IENNMHMOONM>, IDeepCloneable<IENNMHMOONM>, IBufferMessage
{
	private static readonly MessageParser<IENNMHMOONM> _parser = new MessageParser<IENNMHMOONM>(() => new IENNMHMOONM());

	private UnknownFieldSet _unknownFields;

	public const int TraitIdFieldNumber = 1;

	private uint traitId_;

	public const int NKFDBEHPNLGFieldNumber = 2;

	private uint nKFDBEHPNLG_;

	public const int TraitEffectListFieldNumber = 3;

	private static readonly FieldCodec<BattleGridFightTraitEffectInfo> _repeated_traitEffectList_codec = FieldCodec.ForMessage(26u, BattleGridFightTraitEffectInfo.Parser);

	private readonly RepeatedField<BattleGridFightTraitEffectInfo> traitEffectList_ = new RepeatedField<BattleGridFightTraitEffectInfo>();

	public const int MEEPFKLLIJBFieldNumber = 5;

	private static readonly FieldCodec<BGNGLHHBGMI> _repeated_mEEPFKLLIJB_codec = FieldCodec.ForMessage(42u, BGNGLHHBGMI.Parser);

	private readonly RepeatedField<BGNGLHHBGMI> mEEPFKLLIJB_ = new RepeatedField<BGNGLHHBGMI>();

	public const int JJFNMAIPDEBFieldNumber = 6;

	private uint jJFNMAIPDEB_;

	public const int KINIKFCKGDFFieldNumber = 7;

	private uint kINIKFCKGDF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IENNMHMOONM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IENNMHMOONMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TraitId
	{
		get
		{
			return traitId_;
		}
		set
		{
			traitId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NKFDBEHPNLG
	{
		get
		{
			return nKFDBEHPNLG_;
		}
		set
		{
			nKFDBEHPNLG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BattleGridFightTraitEffectInfo> TraitEffectList => traitEffectList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BGNGLHHBGMI> MEEPFKLLIJB => mEEPFKLLIJB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JJFNMAIPDEB
	{
		get
		{
			return jJFNMAIPDEB_;
		}
		set
		{
			jJFNMAIPDEB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KINIKFCKGDF
	{
		get
		{
			return kINIKFCKGDF_;
		}
		set
		{
			kINIKFCKGDF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IENNMHMOONM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IENNMHMOONM(IENNMHMOONM other)
		: this()
	{
		traitId_ = other.traitId_;
		nKFDBEHPNLG_ = other.nKFDBEHPNLG_;
		traitEffectList_ = other.traitEffectList_.Clone();
		mEEPFKLLIJB_ = other.mEEPFKLLIJB_.Clone();
		jJFNMAIPDEB_ = other.jJFNMAIPDEB_;
		kINIKFCKGDF_ = other.kINIKFCKGDF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IENNMHMOONM Clone()
	{
		return new IENNMHMOONM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IENNMHMOONM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IENNMHMOONM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TraitId != other.TraitId)
		{
			return false;
		}
		if (NKFDBEHPNLG != other.NKFDBEHPNLG)
		{
			return false;
		}
		if (!traitEffectList_.Equals(other.traitEffectList_))
		{
			return false;
		}
		if (!mEEPFKLLIJB_.Equals(other.mEEPFKLLIJB_))
		{
			return false;
		}
		if (JJFNMAIPDEB != other.JJFNMAIPDEB)
		{
			return false;
		}
		if (KINIKFCKGDF != other.KINIKFCKGDF)
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
		if (TraitId != 0)
		{
			num ^= TraitId.GetHashCode();
		}
		if (NKFDBEHPNLG != 0)
		{
			num ^= NKFDBEHPNLG.GetHashCode();
		}
		num ^= traitEffectList_.GetHashCode();
		num ^= mEEPFKLLIJB_.GetHashCode();
		if (JJFNMAIPDEB != 0)
		{
			num ^= JJFNMAIPDEB.GetHashCode();
		}
		if (KINIKFCKGDF != 0)
		{
			num ^= KINIKFCKGDF.GetHashCode();
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
		if (TraitId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(TraitId);
		}
		if (NKFDBEHPNLG != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(NKFDBEHPNLG);
		}
		traitEffectList_.WriteTo(ref output, _repeated_traitEffectList_codec);
		mEEPFKLLIJB_.WriteTo(ref output, _repeated_mEEPFKLLIJB_codec);
		if (JJFNMAIPDEB != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(JJFNMAIPDEB);
		}
		if (KINIKFCKGDF != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(KINIKFCKGDF);
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
		if (TraitId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TraitId);
		}
		if (NKFDBEHPNLG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NKFDBEHPNLG);
		}
		num += traitEffectList_.CalculateSize(_repeated_traitEffectList_codec);
		num += mEEPFKLLIJB_.CalculateSize(_repeated_mEEPFKLLIJB_codec);
		if (JJFNMAIPDEB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JJFNMAIPDEB);
		}
		if (KINIKFCKGDF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KINIKFCKGDF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IENNMHMOONM other)
	{
		if (other != null)
		{
			if (other.TraitId != 0)
			{
				TraitId = other.TraitId;
			}
			if (other.NKFDBEHPNLG != 0)
			{
				NKFDBEHPNLG = other.NKFDBEHPNLG;
			}
			traitEffectList_.Add(other.traitEffectList_);
			mEEPFKLLIJB_.Add(other.mEEPFKLLIJB_);
			if (other.JJFNMAIPDEB != 0)
			{
				JJFNMAIPDEB = other.JJFNMAIPDEB;
			}
			if (other.KINIKFCKGDF != 0)
			{
				KINIKFCKGDF = other.KINIKFCKGDF;
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
				TraitId = input.ReadUInt32();
				break;
			case 16u:
				NKFDBEHPNLG = input.ReadUInt32();
				break;
			case 26u:
				traitEffectList_.AddEntriesFrom(ref input, _repeated_traitEffectList_codec);
				break;
			case 42u:
				mEEPFKLLIJB_.AddEntriesFrom(ref input, _repeated_mEEPFKLLIJB_codec);
				break;
			case 48u:
				JJFNMAIPDEB = input.ReadUInt32();
				break;
			case 56u:
				KINIKFCKGDF = input.ReadUInt32();
				break;
			}
		}
	}
}
