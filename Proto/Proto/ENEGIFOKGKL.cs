using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ENEGIFOKGKL : IMessage<ENEGIFOKGKL>, IMessage, IEquatable<ENEGIFOKGKL>, IDeepCloneable<ENEGIFOKGKL>, IBufferMessage
{
	private static readonly MessageParser<ENEGIFOKGKL> _parser = new MessageParser<ENEGIFOKGKL>(() => new ENEGIFOKGKL());

	private UnknownFieldSet _unknownFields;

	public const int HEIONPDIFNMFieldNumber = 1;

	private uint hEIONPDIFNM_;

	public const int MapIdFieldNumber = 2;

	private uint mapId_;

	public const int AreaIdFieldNumber = 3;

	private uint areaId_;

	public const int HFDIFFBCOGJFieldNumber = 6;

	private static readonly FieldCodec<IJKNDKJLMEN> _repeated_hFDIFFBCOGJ_codec = FieldCodec.ForMessage(50u, IJKNDKJLMEN.Parser);

	private readonly RepeatedField<IJKNDKJLMEN> hFDIFFBCOGJ_ = new RepeatedField<IJKNDKJLMEN>();

	public const int IGECGPFLGBAFieldNumber = 14;

	private uint iGECGPFLGBA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ENEGIFOKGKL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ENEGIFOKGKLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HEIONPDIFNM
	{
		get
		{
			return hEIONPDIFNM_;
		}
		set
		{
			hEIONPDIFNM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MapId
	{
		get
		{
			return mapId_;
		}
		set
		{
			mapId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AreaId
	{
		get
		{
			return areaId_;
		}
		set
		{
			areaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IJKNDKJLMEN> HFDIFFBCOGJ => hFDIFFBCOGJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IGECGPFLGBA
	{
		get
		{
			return iGECGPFLGBA_;
		}
		set
		{
			iGECGPFLGBA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ENEGIFOKGKL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ENEGIFOKGKL(ENEGIFOKGKL other)
		: this()
	{
		hEIONPDIFNM_ = other.hEIONPDIFNM_;
		mapId_ = other.mapId_;
		areaId_ = other.areaId_;
		hFDIFFBCOGJ_ = other.hFDIFFBCOGJ_.Clone();
		iGECGPFLGBA_ = other.iGECGPFLGBA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ENEGIFOKGKL Clone()
	{
		return new ENEGIFOKGKL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ENEGIFOKGKL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ENEGIFOKGKL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HEIONPDIFNM != other.HEIONPDIFNM)
		{
			return false;
		}
		if (MapId != other.MapId)
		{
			return false;
		}
		if (AreaId != other.AreaId)
		{
			return false;
		}
		if (!hFDIFFBCOGJ_.Equals(other.hFDIFFBCOGJ_))
		{
			return false;
		}
		if (IGECGPFLGBA != other.IGECGPFLGBA)
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
		if (HEIONPDIFNM != 0)
		{
			num ^= HEIONPDIFNM.GetHashCode();
		}
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
		}
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
		}
		num ^= hFDIFFBCOGJ_.GetHashCode();
		if (IGECGPFLGBA != 0)
		{
			num ^= IGECGPFLGBA.GetHashCode();
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
		if (HEIONPDIFNM != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(HEIONPDIFNM);
		}
		if (MapId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MapId);
		}
		if (AreaId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(AreaId);
		}
		hFDIFFBCOGJ_.WriteTo(ref output, _repeated_hFDIFFBCOGJ_codec);
		if (IGECGPFLGBA != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(IGECGPFLGBA);
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
		if (HEIONPDIFNM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HEIONPDIFNM);
		}
		if (MapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MapId);
		}
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		num += hFDIFFBCOGJ_.CalculateSize(_repeated_hFDIFFBCOGJ_codec);
		if (IGECGPFLGBA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IGECGPFLGBA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ENEGIFOKGKL other)
	{
		if (other != null)
		{
			if (other.HEIONPDIFNM != 0)
			{
				HEIONPDIFNM = other.HEIONPDIFNM;
			}
			if (other.MapId != 0)
			{
				MapId = other.MapId;
			}
			if (other.AreaId != 0)
			{
				AreaId = other.AreaId;
			}
			hFDIFFBCOGJ_.Add(other.hFDIFFBCOGJ_);
			if (other.IGECGPFLGBA != 0)
			{
				IGECGPFLGBA = other.IGECGPFLGBA;
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
				HEIONPDIFNM = input.ReadUInt32();
				break;
			case 16u:
				MapId = input.ReadUInt32();
				break;
			case 24u:
				AreaId = input.ReadUInt32();
				break;
			case 50u:
				hFDIFFBCOGJ_.AddEntriesFrom(ref input, _repeated_hFDIFFBCOGJ_codec);
				break;
			case 112u:
				IGECGPFLGBA = input.ReadUInt32();
				break;
			}
		}
	}
}
