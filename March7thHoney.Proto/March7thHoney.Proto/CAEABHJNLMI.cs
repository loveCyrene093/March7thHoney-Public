using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CAEABHJNLMI : IMessage<CAEABHJNLMI>, IMessage, IEquatable<CAEABHJNLMI>, IDeepCloneable<CAEABHJNLMI>, IBufferMessage
{
	private static readonly MessageParser<CAEABHJNLMI> _parser = new MessageParser<CAEABHJNLMI>(() => new CAEABHJNLMI());

	private UnknownFieldSet _unknownFields;

	public const int DACOKFCBMBIFieldNumber = 1;

	private uint dACOKFCBMBI_;

	public const int BLJEBIJEMCHFieldNumber = 7;

	private static readonly MapField<uint, uint>.Codec _map_bLJEBIJEMCH_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 58u);

	private readonly MapField<uint, uint> bLJEBIJEMCH_ = new MapField<uint, uint>();

	public const int MEAJAEBDAOIFieldNumber = 10;

	private uint mEAJAEBDAOI_;

	public const int DOMGLHIKJEDFieldNumber = 11;

	private uint dOMGLHIKJED_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CAEABHJNLMI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CAEABHJNLMIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public MapField<uint, uint> BLJEBIJEMCH => bLJEBIJEMCH_;

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
	public CAEABHJNLMI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CAEABHJNLMI(CAEABHJNLMI other)
		: this()
	{
		dACOKFCBMBI_ = other.dACOKFCBMBI_;
		bLJEBIJEMCH_ = other.bLJEBIJEMCH_.Clone();
		mEAJAEBDAOI_ = other.mEAJAEBDAOI_;
		dOMGLHIKJED_ = other.dOMGLHIKJED_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CAEABHJNLMI Clone()
	{
		return new CAEABHJNLMI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CAEABHJNLMI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CAEABHJNLMI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DACOKFCBMBI != other.DACOKFCBMBI)
		{
			return false;
		}
		if (!BLJEBIJEMCH.Equals(other.BLJEBIJEMCH))
		{
			return false;
		}
		if (MEAJAEBDAOI != other.MEAJAEBDAOI)
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
		if (DACOKFCBMBI != 0)
		{
			num ^= DACOKFCBMBI.GetHashCode();
		}
		num ^= BLJEBIJEMCH.GetHashCode();
		if (MEAJAEBDAOI != 0)
		{
			num ^= MEAJAEBDAOI.GetHashCode();
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
		if (DACOKFCBMBI != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(DACOKFCBMBI);
		}
		bLJEBIJEMCH_.WriteTo(ref output, _map_bLJEBIJEMCH_codec);
		if (MEAJAEBDAOI != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(MEAJAEBDAOI);
		}
		if (DOMGLHIKJED != 0)
		{
			output.WriteRawTag(88);
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
		if (DACOKFCBMBI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DACOKFCBMBI);
		}
		num += bLJEBIJEMCH_.CalculateSize(_map_bLJEBIJEMCH_codec);
		if (MEAJAEBDAOI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MEAJAEBDAOI);
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
	public void MergeFrom(CAEABHJNLMI other)
	{
		if (other != null)
		{
			if (other.DACOKFCBMBI != 0)
			{
				DACOKFCBMBI = other.DACOKFCBMBI;
			}
			bLJEBIJEMCH_.MergeFrom(other.bLJEBIJEMCH_);
			if (other.MEAJAEBDAOI != 0)
			{
				MEAJAEBDAOI = other.MEAJAEBDAOI;
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
				DACOKFCBMBI = input.ReadUInt32();
				break;
			case 58u:
				bLJEBIJEMCH_.AddEntriesFrom(ref input, _map_bLJEBIJEMCH_codec);
				break;
			case 80u:
				MEAJAEBDAOI = input.ReadUInt32();
				break;
			case 88u:
				DOMGLHIKJED = input.ReadUInt32();
				break;
			}
		}
	}
}
