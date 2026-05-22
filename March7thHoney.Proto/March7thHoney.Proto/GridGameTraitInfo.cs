using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridGameTraitInfo : IMessage<GridGameTraitInfo>, IMessage, IEquatable<GridGameTraitInfo>, IDeepCloneable<GridGameTraitInfo>, IBufferMessage
{
	private static readonly MessageParser<GridGameTraitInfo> _parser = new MessageParser<GridGameTraitInfo>(() => new GridGameTraitInfo());

	private UnknownFieldSet _unknownFields;

	public const int KINIKFCKGDFFieldNumber = 1;

	private uint kINIKFCKGDF_;

	public const int TraitEffectListFieldNumber = 4;

	private static readonly FieldCodec<GridFightTraitEffectInfo> _repeated_traitEffectList_codec = FieldCodec.ForMessage(34u, GridFightTraitEffectInfo.Parser);

	private readonly RepeatedField<GridFightTraitEffectInfo> traitEffectList_ = new RepeatedField<GridFightTraitEffectInfo>();

	public const int DFNCFOKPMCJFieldNumber = 6;

	private uint dFNCFOKPMCJ_;

	public const int NKFDBEHPNLGFieldNumber = 12;

	private uint nKFDBEHPNLG_;

	public const int TraitIdFieldNumber = 13;

	private uint traitId_;

	public const int GridFightTraitMemberUniqueIdListFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_gridFightTraitMemberUniqueIdList_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> gridFightTraitMemberUniqueIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridGameTraitInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridGameTraitInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<GridFightTraitEffectInfo> TraitEffectList => traitEffectList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DFNCFOKPMCJ
	{
		get
		{
			return dFNCFOKPMCJ_;
		}
		set
		{
			dFNCFOKPMCJ_ = value;
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
	public RepeatedField<uint> GridFightTraitMemberUniqueIdList => gridFightTraitMemberUniqueIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridGameTraitInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridGameTraitInfo(GridGameTraitInfo other)
		: this()
	{
		kINIKFCKGDF_ = other.kINIKFCKGDF_;
		traitEffectList_ = other.traitEffectList_.Clone();
		dFNCFOKPMCJ_ = other.dFNCFOKPMCJ_;
		nKFDBEHPNLG_ = other.nKFDBEHPNLG_;
		traitId_ = other.traitId_;
		gridFightTraitMemberUniqueIdList_ = other.gridFightTraitMemberUniqueIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridGameTraitInfo Clone()
	{
		return new GridGameTraitInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridGameTraitInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridGameTraitInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KINIKFCKGDF != other.KINIKFCKGDF)
		{
			return false;
		}
		if (!traitEffectList_.Equals(other.traitEffectList_))
		{
			return false;
		}
		if (DFNCFOKPMCJ != other.DFNCFOKPMCJ)
		{
			return false;
		}
		if (NKFDBEHPNLG != other.NKFDBEHPNLG)
		{
			return false;
		}
		if (TraitId != other.TraitId)
		{
			return false;
		}
		if (!gridFightTraitMemberUniqueIdList_.Equals(other.gridFightTraitMemberUniqueIdList_))
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
		if (KINIKFCKGDF != 0)
		{
			num ^= KINIKFCKGDF.GetHashCode();
		}
		num ^= traitEffectList_.GetHashCode();
		if (DFNCFOKPMCJ != 0)
		{
			num ^= DFNCFOKPMCJ.GetHashCode();
		}
		if (NKFDBEHPNLG != 0)
		{
			num ^= NKFDBEHPNLG.GetHashCode();
		}
		if (TraitId != 0)
		{
			num ^= TraitId.GetHashCode();
		}
		num ^= gridFightTraitMemberUniqueIdList_.GetHashCode();
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
		if (KINIKFCKGDF != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(KINIKFCKGDF);
		}
		traitEffectList_.WriteTo(ref output, _repeated_traitEffectList_codec);
		if (DFNCFOKPMCJ != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(DFNCFOKPMCJ);
		}
		if (NKFDBEHPNLG != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(NKFDBEHPNLG);
		}
		if (TraitId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(TraitId);
		}
		gridFightTraitMemberUniqueIdList_.WriteTo(ref output, _repeated_gridFightTraitMemberUniqueIdList_codec);
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
		if (KINIKFCKGDF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KINIKFCKGDF);
		}
		num += traitEffectList_.CalculateSize(_repeated_traitEffectList_codec);
		if (DFNCFOKPMCJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DFNCFOKPMCJ);
		}
		if (NKFDBEHPNLG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NKFDBEHPNLG);
		}
		if (TraitId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TraitId);
		}
		num += gridFightTraitMemberUniqueIdList_.CalculateSize(_repeated_gridFightTraitMemberUniqueIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridGameTraitInfo other)
	{
		if (other != null)
		{
			if (other.KINIKFCKGDF != 0)
			{
				KINIKFCKGDF = other.KINIKFCKGDF;
			}
			traitEffectList_.Add(other.traitEffectList_);
			if (other.DFNCFOKPMCJ != 0)
			{
				DFNCFOKPMCJ = other.DFNCFOKPMCJ;
			}
			if (other.NKFDBEHPNLG != 0)
			{
				NKFDBEHPNLG = other.NKFDBEHPNLG;
			}
			if (other.TraitId != 0)
			{
				TraitId = other.TraitId;
			}
			gridFightTraitMemberUniqueIdList_.Add(other.gridFightTraitMemberUniqueIdList_);
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
				KINIKFCKGDF = input.ReadUInt32();
				break;
			case 34u:
				traitEffectList_.AddEntriesFrom(ref input, _repeated_traitEffectList_codec);
				break;
			case 48u:
				DFNCFOKPMCJ = input.ReadUInt32();
				break;
			case 96u:
				NKFDBEHPNLG = input.ReadUInt32();
				break;
			case 104u:
				TraitId = input.ReadUInt32();
				break;
			case 112u:
			case 114u:
				gridFightTraitMemberUniqueIdList_.AddEntriesFrom(ref input, _repeated_gridFightTraitMemberUniqueIdList_codec);
				break;
			}
		}
	}
}
