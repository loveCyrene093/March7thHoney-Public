using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RoleTrackEquipmentInfo : IMessage<RoleTrackEquipmentInfo>, IMessage, IEquatable<RoleTrackEquipmentInfo>, IDeepCloneable<RoleTrackEquipmentInfo>, IBufferMessage
{
	private static readonly MessageParser<RoleTrackEquipmentInfo> _parser = new MessageParser<RoleTrackEquipmentInfo>(() => new RoleTrackEquipmentInfo());

	private UnknownFieldSet _unknownFields;

	public const int SourceFieldNumber = 5;

	private GridFightEquipTrackSource source_;

	public const int GridFightItemListFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_gridFightItemList_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> gridFightItemList_ = new RepeatedField<uint>();

	public const int FANOLNOMHFIFieldNumber = 7;

	private uint fANOLNOMHFI_;

	public const int TrackEquippedIdListFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_trackEquippedIdList_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> trackEquippedIdList_ = new RepeatedField<uint>();

	public const int BCGCGHEPDEAFieldNumber = 15;

	private uint bCGCGHEPDEA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RoleTrackEquipmentInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RoleTrackEquipmentInfoReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<uint> GridFightItemList => gridFightItemList_;

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
	public RepeatedField<uint> TrackEquippedIdList => trackEquippedIdList_;

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
	public RoleTrackEquipmentInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RoleTrackEquipmentInfo(RoleTrackEquipmentInfo other)
		: this()
	{
		source_ = other.source_;
		gridFightItemList_ = other.gridFightItemList_.Clone();
		fANOLNOMHFI_ = other.fANOLNOMHFI_;
		trackEquippedIdList_ = other.trackEquippedIdList_.Clone();
		bCGCGHEPDEA_ = other.bCGCGHEPDEA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RoleTrackEquipmentInfo Clone()
	{
		return new RoleTrackEquipmentInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RoleTrackEquipmentInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RoleTrackEquipmentInfo other)
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
		if (!gridFightItemList_.Equals(other.gridFightItemList_))
		{
			return false;
		}
		if (FANOLNOMHFI != other.FANOLNOMHFI)
		{
			return false;
		}
		if (!trackEquippedIdList_.Equals(other.trackEquippedIdList_))
		{
			return false;
		}
		if (BCGCGHEPDEA != other.BCGCGHEPDEA)
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
		num ^= gridFightItemList_.GetHashCode();
		if (FANOLNOMHFI != 0)
		{
			num ^= FANOLNOMHFI.GetHashCode();
		}
		num ^= trackEquippedIdList_.GetHashCode();
		if (BCGCGHEPDEA != 0)
		{
			num ^= BCGCGHEPDEA.GetHashCode();
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
		if (Source != GridFightEquipTrackSource.HnkkndhlognHlnmmmkheem)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)Source);
		}
		gridFightItemList_.WriteTo(ref output, _repeated_gridFightItemList_codec);
		if (FANOLNOMHFI != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(FANOLNOMHFI);
		}
		trackEquippedIdList_.WriteTo(ref output, _repeated_trackEquippedIdList_codec);
		if (BCGCGHEPDEA != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(BCGCGHEPDEA);
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
		if (Source != GridFightEquipTrackSource.HnkkndhlognHlnmmmkheem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Source);
		}
		num += gridFightItemList_.CalculateSize(_repeated_gridFightItemList_codec);
		if (FANOLNOMHFI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FANOLNOMHFI);
		}
		num += trackEquippedIdList_.CalculateSize(_repeated_trackEquippedIdList_codec);
		if (BCGCGHEPDEA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BCGCGHEPDEA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RoleTrackEquipmentInfo other)
	{
		if (other != null)
		{
			if (other.Source != GridFightEquipTrackSource.HnkkndhlognHlnmmmkheem)
			{
				Source = other.Source;
			}
			gridFightItemList_.Add(other.gridFightItemList_);
			if (other.FANOLNOMHFI != 0)
			{
				FANOLNOMHFI = other.FANOLNOMHFI;
			}
			trackEquippedIdList_.Add(other.trackEquippedIdList_);
			if (other.BCGCGHEPDEA != 0)
			{
				BCGCGHEPDEA = other.BCGCGHEPDEA;
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
			case 40u:
				Source = (GridFightEquipTrackSource)input.ReadEnum();
				break;
			case 48u:
			case 50u:
				gridFightItemList_.AddEntriesFrom(ref input, _repeated_gridFightItemList_codec);
				break;
			case 56u:
				FANOLNOMHFI = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				trackEquippedIdList_.AddEntriesFrom(ref input, _repeated_trackEquippedIdList_codec);
				break;
			case 120u:
				BCGCGHEPDEA = input.ReadUInt32();
				break;
			}
		}
	}
}
