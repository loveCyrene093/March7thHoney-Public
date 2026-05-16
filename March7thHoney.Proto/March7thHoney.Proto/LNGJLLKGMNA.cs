using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LNGJLLKGMNA : IMessage<LNGJLLKGMNA>, IMessage, IEquatable<LNGJLLKGMNA>, IDeepCloneable<LNGJLLKGMNA>, IBufferMessage
{
	private static readonly MessageParser<LNGJLLKGMNA> _parser = new MessageParser<LNGJLLKGMNA>(() => new LNGJLLKGMNA());

	private UnknownFieldSet _unknownFields;

	public const int MEAJAEBDAOIFieldNumber = 1;

	private uint mEAJAEBDAOI_;

	public const int BLJEBIJEMCHFieldNumber = 3;

	private static readonly MapField<uint, uint>.Codec _map_bLJEBIJEMCH_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 26u);

	private readonly MapField<uint, uint> bLJEBIJEMCH_ = new MapField<uint, uint>();

	public const int KKGIEENCOICFieldNumber = 8;

	private uint kKGIEENCOIC_;

	public const int DACOKFCBMBIFieldNumber = 10;

	private uint dACOKFCBMBI_;

	public const int DOMGLHIKJEDFieldNumber = 13;

	private uint dOMGLHIKJED_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LNGJLLKGMNA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LNGJLLKGMNAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MEAJAEBDAOI
	{
		get
		{
			return mEAJAEBDAOI_;
		}
		set
		{
			mEAJAEBDAOI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> BLJEBIJEMCH => bLJEBIJEMCH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KKGIEENCOIC
	{
		get
		{
			return kKGIEENCOIC_;
		}
		set
		{
			kKGIEENCOIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DACOKFCBMBI
	{
		get
		{
			return dACOKFCBMBI_;
		}
		set
		{
			dACOKFCBMBI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DOMGLHIKJED
	{
		get
		{
			return dOMGLHIKJED_;
		}
		set
		{
			dOMGLHIKJED_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LNGJLLKGMNA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LNGJLLKGMNA(LNGJLLKGMNA other)
		: this()
	{
		mEAJAEBDAOI_ = other.mEAJAEBDAOI_;
		bLJEBIJEMCH_ = other.bLJEBIJEMCH_.Clone();
		kKGIEENCOIC_ = other.kKGIEENCOIC_;
		dACOKFCBMBI_ = other.dACOKFCBMBI_;
		dOMGLHIKJED_ = other.dOMGLHIKJED_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LNGJLLKGMNA Clone()
	{
		return new LNGJLLKGMNA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LNGJLLKGMNA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LNGJLLKGMNA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MEAJAEBDAOI != other.MEAJAEBDAOI)
		{
			return false;
		}
		if (!BLJEBIJEMCH.Equals(other.BLJEBIJEMCH))
		{
			return false;
		}
		if (KKGIEENCOIC != other.KKGIEENCOIC)
		{
			return false;
		}
		if (DACOKFCBMBI != other.DACOKFCBMBI)
		{
			return false;
		}
		if (DOMGLHIKJED != other.DOMGLHIKJED)
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
		if (MEAJAEBDAOI != 0)
		{
			num ^= MEAJAEBDAOI.GetHashCode();
		}
		num ^= BLJEBIJEMCH.GetHashCode();
		if (KKGIEENCOIC != 0)
		{
			num ^= KKGIEENCOIC.GetHashCode();
		}
		if (DACOKFCBMBI != 0)
		{
			num ^= DACOKFCBMBI.GetHashCode();
		}
		if (DOMGLHIKJED != 0)
		{
			num ^= DOMGLHIKJED.GetHashCode();
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
		if (MEAJAEBDAOI != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(MEAJAEBDAOI);
		}
		bLJEBIJEMCH_.WriteTo(ref output, _map_bLJEBIJEMCH_codec);
		if (KKGIEENCOIC != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(KKGIEENCOIC);
		}
		if (DACOKFCBMBI != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(DACOKFCBMBI);
		}
		if (DOMGLHIKJED != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(DOMGLHIKJED);
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
		if (MEAJAEBDAOI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MEAJAEBDAOI);
		}
		num += bLJEBIJEMCH_.CalculateSize(_map_bLJEBIJEMCH_codec);
		if (KKGIEENCOIC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KKGIEENCOIC);
		}
		if (DACOKFCBMBI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DACOKFCBMBI);
		}
		if (DOMGLHIKJED != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DOMGLHIKJED);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LNGJLLKGMNA other)
	{
		if (other != null)
		{
			if (other.MEAJAEBDAOI != 0)
			{
				MEAJAEBDAOI = other.MEAJAEBDAOI;
			}
			bLJEBIJEMCH_.MergeFrom(other.bLJEBIJEMCH_);
			if (other.KKGIEENCOIC != 0)
			{
				KKGIEENCOIC = other.KKGIEENCOIC;
			}
			if (other.DACOKFCBMBI != 0)
			{
				DACOKFCBMBI = other.DACOKFCBMBI;
			}
			if (other.DOMGLHIKJED != 0)
			{
				DOMGLHIKJED = other.DOMGLHIKJED;
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
				MEAJAEBDAOI = input.ReadUInt32();
				break;
			case 26u:
				bLJEBIJEMCH_.AddEntriesFrom(ref input, _map_bLJEBIJEMCH_codec);
				break;
			case 64u:
				KKGIEENCOIC = input.ReadUInt32();
				break;
			case 80u:
				DACOKFCBMBI = input.ReadUInt32();
				break;
			case 104u:
				DOMGLHIKJED = input.ReadUInt32();
				break;
			}
		}
	}
}
