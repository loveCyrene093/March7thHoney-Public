using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HMEDBGAMMPN : IMessage<HMEDBGAMMPN>, IMessage, IEquatable<HMEDBGAMMPN>, IDeepCloneable<HMEDBGAMMPN>, IBufferMessage
{
	private static readonly MessageParser<HMEDBGAMMPN> _parser = new MessageParser<HMEDBGAMMPN>(() => new HMEDBGAMMPN());

	private UnknownFieldSet _unknownFields;

	public const int BOLEHILKKAOFieldNumber = 6;

	private static readonly MapField<uint, uint>.Codec _map_bOLEHILKKAO_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 50u);

	private readonly MapField<uint, uint> bOLEHILKKAO_ = new MapField<uint, uint>();

	public const int OKONFGOPOOKFieldNumber = 7;

	private uint oKONFGOPOOK_;

	public const int DACOKFCBMBIFieldNumber = 8;

	private uint dACOKFCBMBI_;

	public const int MGCPIPCGILOFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_mGCPIPCGILO_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> mGCPIPCGILO_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HMEDBGAMMPN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HMEDBGAMMPNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> BOLEHILKKAO => bOLEHILKKAO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OKONFGOPOOK
	{
		get
		{
			return oKONFGOPOOK_;
		}
		set
		{
			oKONFGOPOOK_ = value;
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
	public RepeatedField<uint> MGCPIPCGILO => mGCPIPCGILO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMEDBGAMMPN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMEDBGAMMPN(HMEDBGAMMPN other)
		: this()
	{
		bOLEHILKKAO_ = other.bOLEHILKKAO_.Clone();
		oKONFGOPOOK_ = other.oKONFGOPOOK_;
		dACOKFCBMBI_ = other.dACOKFCBMBI_;
		mGCPIPCGILO_ = other.mGCPIPCGILO_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HMEDBGAMMPN Clone()
	{
		return new HMEDBGAMMPN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HMEDBGAMMPN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HMEDBGAMMPN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!BOLEHILKKAO.Equals(other.BOLEHILKKAO))
		{
			return false;
		}
		if (OKONFGOPOOK != other.OKONFGOPOOK)
		{
			return false;
		}
		if (DACOKFCBMBI != other.DACOKFCBMBI)
		{
			return false;
		}
		if (!mGCPIPCGILO_.Equals(other.mGCPIPCGILO_))
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
		num ^= BOLEHILKKAO.GetHashCode();
		if (OKONFGOPOOK != 0)
		{
			num ^= OKONFGOPOOK.GetHashCode();
		}
		if (DACOKFCBMBI != 0)
		{
			num ^= DACOKFCBMBI.GetHashCode();
		}
		num ^= mGCPIPCGILO_.GetHashCode();
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
		bOLEHILKKAO_.WriteTo(ref output, _map_bOLEHILKKAO_codec);
		if (OKONFGOPOOK != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(OKONFGOPOOK);
		}
		if (DACOKFCBMBI != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(DACOKFCBMBI);
		}
		mGCPIPCGILO_.WriteTo(ref output, _repeated_mGCPIPCGILO_codec);
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
		num += bOLEHILKKAO_.CalculateSize(_map_bOLEHILKKAO_codec);
		if (OKONFGOPOOK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OKONFGOPOOK);
		}
		if (DACOKFCBMBI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DACOKFCBMBI);
		}
		num += mGCPIPCGILO_.CalculateSize(_repeated_mGCPIPCGILO_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HMEDBGAMMPN other)
	{
		if (other != null)
		{
			bOLEHILKKAO_.MergeFrom(other.bOLEHILKKAO_);
			if (other.OKONFGOPOOK != 0)
			{
				OKONFGOPOOK = other.OKONFGOPOOK;
			}
			if (other.DACOKFCBMBI != 0)
			{
				DACOKFCBMBI = other.DACOKFCBMBI;
			}
			mGCPIPCGILO_.Add(other.mGCPIPCGILO_);
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
			case 50u:
				bOLEHILKKAO_.AddEntriesFrom(ref input, _map_bOLEHILKKAO_codec);
				break;
			case 56u:
				OKONFGOPOOK = input.ReadUInt32();
				break;
			case 64u:
				DACOKFCBMBI = input.ReadUInt32();
				break;
			case 104u:
			case 106u:
				mGCPIPCGILO_.AddEntriesFrom(ref input, _repeated_mGCPIPCGILO_codec);
				break;
			}
		}
	}
}
