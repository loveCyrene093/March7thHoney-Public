using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MJMPDGNFIKN : IMessage<MJMPDGNFIKN>, IMessage, IEquatable<MJMPDGNFIKN>, IDeepCloneable<MJMPDGNFIKN>, IBufferMessage
{
	private static readonly MessageParser<MJMPDGNFIKN> _parser = new MessageParser<MJMPDGNFIKN>(() => new MJMPDGNFIKN());

	private UnknownFieldSet _unknownFields;

	public const int BLFPPFCADBBFieldNumber = 2;

	private static readonly FieldCodec<FOCHGPGGNCL> _repeated_bLFPPFCADBB_codec = FieldCodec.ForMessage(18u, FOCHGPGGNCL.Parser);

	private readonly RepeatedField<FOCHGPGGNCL> bLFPPFCADBB_ = new RepeatedField<FOCHGPGGNCL>();

	public const int LCEHDGBBDJLFieldNumber = 3;

	private static readonly FieldCodec<HAGKBFPNPPH> _repeated_lCEHDGBBDJL_codec = FieldCodec.ForMessage(26u, HAGKBFPNPPH.Parser);

	private readonly RepeatedField<HAGKBFPNPPH> lCEHDGBBDJL_ = new RepeatedField<HAGKBFPNPPH>();

	public const int KPIDJMBNCNHFieldNumber = 6;

	private static readonly MapField<uint, uint>.Codec _map_kPIDJMBNCNH_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 50u);

	private readonly MapField<uint, uint> kPIDJMBNCNH_ = new MapField<uint, uint>();

	public const int KIBGNJNADDHFieldNumber = 15;

	private static readonly MapField<uint, uint>.Codec _map_kIBGNJNADDH_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 122u);

	private readonly MapField<uint, uint> kIBGNJNADDH_ = new MapField<uint, uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MJMPDGNFIKN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MJMPDGNFIKNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FOCHGPGGNCL> BLFPPFCADBB => bLFPPFCADBB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HAGKBFPNPPH> LCEHDGBBDJL => lCEHDGBBDJL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> KPIDJMBNCNH => kPIDJMBNCNH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> KIBGNJNADDH => kIBGNJNADDH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJMPDGNFIKN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJMPDGNFIKN(MJMPDGNFIKN other)
		: this()
	{
		bLFPPFCADBB_ = other.bLFPPFCADBB_.Clone();
		lCEHDGBBDJL_ = other.lCEHDGBBDJL_.Clone();
		kPIDJMBNCNH_ = other.kPIDJMBNCNH_.Clone();
		kIBGNJNADDH_ = other.kIBGNJNADDH_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MJMPDGNFIKN Clone()
	{
		return new MJMPDGNFIKN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MJMPDGNFIKN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MJMPDGNFIKN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bLFPPFCADBB_.Equals(other.bLFPPFCADBB_))
		{
			return false;
		}
		if (!lCEHDGBBDJL_.Equals(other.lCEHDGBBDJL_))
		{
			return false;
		}
		if (!KPIDJMBNCNH.Equals(other.KPIDJMBNCNH))
		{
			return false;
		}
		if (!KIBGNJNADDH.Equals(other.KIBGNJNADDH))
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
		num ^= bLFPPFCADBB_.GetHashCode();
		num ^= lCEHDGBBDJL_.GetHashCode();
		num ^= KPIDJMBNCNH.GetHashCode();
		num ^= KIBGNJNADDH.GetHashCode();
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
		bLFPPFCADBB_.WriteTo(ref output, _repeated_bLFPPFCADBB_codec);
		lCEHDGBBDJL_.WriteTo(ref output, _repeated_lCEHDGBBDJL_codec);
		kPIDJMBNCNH_.WriteTo(ref output, _map_kPIDJMBNCNH_codec);
		kIBGNJNADDH_.WriteTo(ref output, _map_kIBGNJNADDH_codec);
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
		num += bLFPPFCADBB_.CalculateSize(_repeated_bLFPPFCADBB_codec);
		num += lCEHDGBBDJL_.CalculateSize(_repeated_lCEHDGBBDJL_codec);
		num += kPIDJMBNCNH_.CalculateSize(_map_kPIDJMBNCNH_codec);
		num += kIBGNJNADDH_.CalculateSize(_map_kIBGNJNADDH_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MJMPDGNFIKN other)
	{
		if (other != null)
		{
			bLFPPFCADBB_.Add(other.bLFPPFCADBB_);
			lCEHDGBBDJL_.Add(other.lCEHDGBBDJL_);
			kPIDJMBNCNH_.MergeFrom(other.kPIDJMBNCNH_);
			kIBGNJNADDH_.MergeFrom(other.kIBGNJNADDH_);
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
			case 18u:
				bLFPPFCADBB_.AddEntriesFrom(ref input, _repeated_bLFPPFCADBB_codec);
				break;
			case 26u:
				lCEHDGBBDJL_.AddEntriesFrom(ref input, _repeated_lCEHDGBBDJL_codec);
				break;
			case 50u:
				kPIDJMBNCNH_.AddEntriesFrom(ref input, _map_kPIDJMBNCNH_codec);
				break;
			case 122u:
				kIBGNJNADDH_.AddEntriesFrom(ref input, _map_kIBGNJNADDH_codec);
				break;
			}
		}
	}
}
