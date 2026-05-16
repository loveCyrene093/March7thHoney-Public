using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DFKGECLBCDK : IMessage<DFKGECLBCDK>, IMessage, IEquatable<DFKGECLBCDK>, IDeepCloneable<DFKGECLBCDK>, IBufferMessage
{
	private static readonly MessageParser<DFKGECLBCDK> _parser = new MessageParser<DFKGECLBCDK>(() => new DFKGECLBCDK());

	private UnknownFieldSet _unknownFields;

	public const int SourceFieldNumber = 1;

	private GridFightEquipTrackSource source_;

	public const int EDGEHIDLDBFFieldNumber = 3;

	private bool eDGEHIDLDBF_;

	public const int BCGCGHEPDEAFieldNumber = 10;

	private uint bCGCGHEPDEA_;

	public const int TrackEquippedIdListFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_trackEquippedIdList_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> trackEquippedIdList_ = new RepeatedField<uint>();

	public const int FANOLNOMHFIFieldNumber = 13;

	private uint fANOLNOMHFI_;

	public const int GridFightItemListFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_gridFightItemList_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> gridFightItemList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DFKGECLBCDK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DFKGECLBCDKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightEquipTrackSource Source
	{
		get
		{
			return source_;
		}
		set
		{
			source_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool EDGEHIDLDBF
	{
		get
		{
			return eDGEHIDLDBF_;
		}
		set
		{
			eDGEHIDLDBF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BCGCGHEPDEA
	{
		get
		{
			return bCGCGHEPDEA_;
		}
		set
		{
			bCGCGHEPDEA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> TrackEquippedIdList => trackEquippedIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FANOLNOMHFI
	{
		get
		{
			return fANOLNOMHFI_;
		}
		set
		{
			fANOLNOMHFI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GridFightItemList => gridFightItemList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFKGECLBCDK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFKGECLBCDK(DFKGECLBCDK other)
		: this()
	{
		source_ = other.source_;
		eDGEHIDLDBF_ = other.eDGEHIDLDBF_;
		bCGCGHEPDEA_ = other.bCGCGHEPDEA_;
		trackEquippedIdList_ = other.trackEquippedIdList_.Clone();
		fANOLNOMHFI_ = other.fANOLNOMHFI_;
		gridFightItemList_ = other.gridFightItemList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFKGECLBCDK Clone()
	{
		return new DFKGECLBCDK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DFKGECLBCDK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DFKGECLBCDK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Source != other.Source)
		{
			return false;
		}
		if (EDGEHIDLDBF != other.EDGEHIDLDBF)
		{
			return false;
		}
		if (BCGCGHEPDEA != other.BCGCGHEPDEA)
		{
			return false;
		}
		if (!trackEquippedIdList_.Equals(other.trackEquippedIdList_))
		{
			return false;
		}
		if (FANOLNOMHFI != other.FANOLNOMHFI)
		{
			return false;
		}
		if (!gridFightItemList_.Equals(other.gridFightItemList_))
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
		if (Source != GridFightEquipTrackSource.HnkkndhlognHlnmmmkheem)
		{
			num ^= Source.GetHashCode();
		}
		if (EDGEHIDLDBF)
		{
			num ^= EDGEHIDLDBF.GetHashCode();
		}
		if (BCGCGHEPDEA != 0)
		{
			num ^= BCGCGHEPDEA.GetHashCode();
		}
		num ^= trackEquippedIdList_.GetHashCode();
		if (FANOLNOMHFI != 0)
		{
			num ^= FANOLNOMHFI.GetHashCode();
		}
		num ^= gridFightItemList_.GetHashCode();
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
		if (Source != GridFightEquipTrackSource.HnkkndhlognHlnmmmkheem)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Source);
		}
		if (EDGEHIDLDBF)
		{
			output.WriteRawTag(24);
			output.WriteBool(EDGEHIDLDBF);
		}
		if (BCGCGHEPDEA != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(BCGCGHEPDEA);
		}
		trackEquippedIdList_.WriteTo(ref output, _repeated_trackEquippedIdList_codec);
		if (FANOLNOMHFI != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(FANOLNOMHFI);
		}
		gridFightItemList_.WriteTo(ref output, _repeated_gridFightItemList_codec);
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
		if (Source != GridFightEquipTrackSource.HnkkndhlognHlnmmmkheem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Source);
		}
		if (EDGEHIDLDBF)
		{
			num += 2;
		}
		if (BCGCGHEPDEA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BCGCGHEPDEA);
		}
		num += trackEquippedIdList_.CalculateSize(_repeated_trackEquippedIdList_codec);
		if (FANOLNOMHFI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FANOLNOMHFI);
		}
		num += gridFightItemList_.CalculateSize(_repeated_gridFightItemList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DFKGECLBCDK other)
	{
		if (other != null)
		{
			if (other.Source != GridFightEquipTrackSource.HnkkndhlognHlnmmmkheem)
			{
				Source = other.Source;
			}
			if (other.EDGEHIDLDBF)
			{
				EDGEHIDLDBF = other.EDGEHIDLDBF;
			}
			if (other.BCGCGHEPDEA != 0)
			{
				BCGCGHEPDEA = other.BCGCGHEPDEA;
			}
			trackEquippedIdList_.Add(other.trackEquippedIdList_);
			if (other.FANOLNOMHFI != 0)
			{
				FANOLNOMHFI = other.FANOLNOMHFI;
			}
			gridFightItemList_.Add(other.gridFightItemList_);
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
				Source = (GridFightEquipTrackSource)input.ReadEnum();
				break;
			case 24u:
				EDGEHIDLDBF = input.ReadBool();
				break;
			case 80u:
				BCGCGHEPDEA = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				trackEquippedIdList_.AddEntriesFrom(ref input, _repeated_trackEquippedIdList_codec);
				break;
			case 104u:
				FANOLNOMHFI = input.ReadUInt32();
				break;
			case 120u:
			case 122u:
				gridFightItemList_.AddEntriesFrom(ref input, _repeated_gridFightItemList_codec);
				break;
			}
		}
	}
}
