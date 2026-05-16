using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AIMHLKDEMGF : IMessage<AIMHLKDEMGF>, IMessage, IEquatable<AIMHLKDEMGF>, IDeepCloneable<AIMHLKDEMGF>, IBufferMessage
{
	private static readonly MessageParser<AIMHLKDEMGF> _parser = new MessageParser<AIMHLKDEMGF>(() => new AIMHLKDEMGF());

	private UnknownFieldSet _unknownFields;

	public const int DBDOIHPLAFMFieldNumber = 1;

	private static readonly MapField<uint, ItemList>.Codec _map_dBDOIHPLAFM_codec = new MapField<uint, ItemList>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForMessage(18u, ItemList.Parser), 10u);

	private readonly MapField<uint, ItemList> dBDOIHPLAFM_ = new MapField<uint, ItemList>();

	public const int JAFNCOMGABGFieldNumber = 3;

	private uint jAFNCOMGABG_;

	public const int EIIAGABAFECFieldNumber = 8;

	private uint eIIAGABAFEC_;

	public const int MJANOKEODIBFieldNumber = 13;

	private ItemList mJANOKEODIB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AIMHLKDEMGF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AIMHLKDEMGFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, ItemList> DBDOIHPLAFM => dBDOIHPLAFM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JAFNCOMGABG
	{
		get
		{
			return jAFNCOMGABG_;
		}
		set
		{
			jAFNCOMGABG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EIIAGABAFEC
	{
		get
		{
			return eIIAGABAFEC_;
		}
		set
		{
			eIIAGABAFEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList MJANOKEODIB
	{
		get
		{
			return mJANOKEODIB_;
		}
		set
		{
			mJANOKEODIB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AIMHLKDEMGF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AIMHLKDEMGF(AIMHLKDEMGF other)
		: this()
	{
		dBDOIHPLAFM_ = other.dBDOIHPLAFM_.Clone();
		jAFNCOMGABG_ = other.jAFNCOMGABG_;
		eIIAGABAFEC_ = other.eIIAGABAFEC_;
		mJANOKEODIB_ = ((other.mJANOKEODIB_ != null) ? other.mJANOKEODIB_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AIMHLKDEMGF Clone()
	{
		return new AIMHLKDEMGF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AIMHLKDEMGF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AIMHLKDEMGF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!DBDOIHPLAFM.Equals(other.DBDOIHPLAFM))
		{
			return false;
		}
		if (JAFNCOMGABG != other.JAFNCOMGABG)
		{
			return false;
		}
		if (EIIAGABAFEC != other.EIIAGABAFEC)
		{
			return false;
		}
		if (!object.Equals(MJANOKEODIB, other.MJANOKEODIB))
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
		num ^= DBDOIHPLAFM.GetHashCode();
		if (JAFNCOMGABG != 0)
		{
			num ^= JAFNCOMGABG.GetHashCode();
		}
		if (EIIAGABAFEC != 0)
		{
			num ^= EIIAGABAFEC.GetHashCode();
		}
		if (mJANOKEODIB_ != null)
		{
			num ^= MJANOKEODIB.GetHashCode();
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
		dBDOIHPLAFM_.WriteTo(ref output, _map_dBDOIHPLAFM_codec);
		if (JAFNCOMGABG != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(JAFNCOMGABG);
		}
		if (EIIAGABAFEC != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(EIIAGABAFEC);
		}
		if (mJANOKEODIB_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(MJANOKEODIB);
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
		num += dBDOIHPLAFM_.CalculateSize(_map_dBDOIHPLAFM_codec);
		if (JAFNCOMGABG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JAFNCOMGABG);
		}
		if (EIIAGABAFEC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EIIAGABAFEC);
		}
		if (mJANOKEODIB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MJANOKEODIB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AIMHLKDEMGF other)
	{
		if (other == null)
		{
			return;
		}
		dBDOIHPLAFM_.MergeFrom(other.dBDOIHPLAFM_);
		if (other.JAFNCOMGABG != 0)
		{
			JAFNCOMGABG = other.JAFNCOMGABG;
		}
		if (other.EIIAGABAFEC != 0)
		{
			EIIAGABAFEC = other.EIIAGABAFEC;
		}
		if (other.mJANOKEODIB_ != null)
		{
			if (mJANOKEODIB_ == null)
			{
				MJANOKEODIB = new ItemList();
			}
			MJANOKEODIB.MergeFrom(other.MJANOKEODIB);
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
			case 10u:
				dBDOIHPLAFM_.AddEntriesFrom(ref input, _map_dBDOIHPLAFM_codec);
				break;
			case 24u:
				JAFNCOMGABG = input.ReadUInt32();
				break;
			case 64u:
				EIIAGABAFEC = input.ReadUInt32();
				break;
			case 106u:
				if (mJANOKEODIB_ == null)
				{
					MJANOKEODIB = new ItemList();
				}
				input.ReadMessage(MJANOKEODIB);
				break;
			}
		}
	}
}
