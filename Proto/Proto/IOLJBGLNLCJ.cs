using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IOLJBGLNLCJ : IMessage<IOLJBGLNLCJ>, IMessage, IEquatable<IOLJBGLNLCJ>, IDeepCloneable<IOLJBGLNLCJ>, IBufferMessage
{
	private static readonly MessageParser<IOLJBGLNLCJ> _parser = new MessageParser<IOLJBGLNLCJ>(() => new IOLJBGLNLCJ());

	private UnknownFieldSet _unknownFields;

	public const int LOLCBFCJPAMFieldNumber = 3;

	private uint lOLCBFCJPAM_;

	public const int HEOLGEPGIHLFieldNumber = 6;

	private bool hEOLGEPGIHL_;

	public const int BICPNKOCHGNFieldNumber = 7;

	private static readonly FieldCodec<KHHHFHEODED> _repeated_bICPNKOCHGN_codec = FieldCodec.ForMessage(58u, KHHHFHEODED.Parser);

	private readonly RepeatedField<KHHHFHEODED> bICPNKOCHGN_ = new RepeatedField<KHHHFHEODED>();

	public const int EBKDJHLFOGNFieldNumber = 12;

	private static readonly FieldCodec<DOGGIDNINJP> _repeated_eBKDJHLFOGN_codec = FieldCodec.ForMessage(98u, DOGGIDNINJP.Parser);

	private readonly RepeatedField<DOGGIDNINJP> eBKDJHLFOGN_ = new RepeatedField<DOGGIDNINJP>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IOLJBGLNLCJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IOLJBGLNLCJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LOLCBFCJPAM
	{
		get
		{
			return lOLCBFCJPAM_;
		}
		set
		{
			lOLCBFCJPAM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HEOLGEPGIHL
	{
		get
		{
			return hEOLGEPGIHL_;
		}
		set
		{
			hEOLGEPGIHL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KHHHFHEODED> BICPNKOCHGN => bICPNKOCHGN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DOGGIDNINJP> EBKDJHLFOGN => eBKDJHLFOGN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IOLJBGLNLCJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IOLJBGLNLCJ(IOLJBGLNLCJ other)
		: this()
	{
		lOLCBFCJPAM_ = other.lOLCBFCJPAM_;
		hEOLGEPGIHL_ = other.hEOLGEPGIHL_;
		bICPNKOCHGN_ = other.bICPNKOCHGN_.Clone();
		eBKDJHLFOGN_ = other.eBKDJHLFOGN_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IOLJBGLNLCJ Clone()
	{
		return new IOLJBGLNLCJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IOLJBGLNLCJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IOLJBGLNLCJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LOLCBFCJPAM != other.LOLCBFCJPAM)
		{
			return false;
		}
		if (HEOLGEPGIHL != other.HEOLGEPGIHL)
		{
			return false;
		}
		if (!bICPNKOCHGN_.Equals(other.bICPNKOCHGN_))
		{
			return false;
		}
		if (!eBKDJHLFOGN_.Equals(other.eBKDJHLFOGN_))
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
		if (LOLCBFCJPAM != 0)
		{
			num ^= LOLCBFCJPAM.GetHashCode();
		}
		if (HEOLGEPGIHL)
		{
			num ^= HEOLGEPGIHL.GetHashCode();
		}
		num ^= bICPNKOCHGN_.GetHashCode();
		num ^= eBKDJHLFOGN_.GetHashCode();
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
		if (LOLCBFCJPAM != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(LOLCBFCJPAM);
		}
		if (HEOLGEPGIHL)
		{
			output.WriteRawTag(48);
			output.WriteBool(HEOLGEPGIHL);
		}
		bICPNKOCHGN_.WriteTo(ref output, _repeated_bICPNKOCHGN_codec);
		eBKDJHLFOGN_.WriteTo(ref output, _repeated_eBKDJHLFOGN_codec);
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
		if (LOLCBFCJPAM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LOLCBFCJPAM);
		}
		if (HEOLGEPGIHL)
		{
			num += 2;
		}
		num += bICPNKOCHGN_.CalculateSize(_repeated_bICPNKOCHGN_codec);
		num += eBKDJHLFOGN_.CalculateSize(_repeated_eBKDJHLFOGN_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IOLJBGLNLCJ other)
	{
		if (other != null)
		{
			if (other.LOLCBFCJPAM != 0)
			{
				LOLCBFCJPAM = other.LOLCBFCJPAM;
			}
			if (other.HEOLGEPGIHL)
			{
				HEOLGEPGIHL = other.HEOLGEPGIHL;
			}
			bICPNKOCHGN_.Add(other.bICPNKOCHGN_);
			eBKDJHLFOGN_.Add(other.eBKDJHLFOGN_);
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
			case 24u:
				LOLCBFCJPAM = input.ReadUInt32();
				break;
			case 48u:
				HEOLGEPGIHL = input.ReadBool();
				break;
			case 58u:
				bICPNKOCHGN_.AddEntriesFrom(ref input, _repeated_bICPNKOCHGN_codec);
				break;
			case 98u:
				eBKDJHLFOGN_.AddEntriesFrom(ref input, _repeated_eBKDJHLFOGN_codec);
				break;
			}
		}
	}
}
