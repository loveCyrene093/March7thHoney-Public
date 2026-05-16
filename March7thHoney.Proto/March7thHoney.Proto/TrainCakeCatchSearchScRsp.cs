using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TrainCakeCatchSearchScRsp : IMessage<TrainCakeCatchSearchScRsp>, IMessage, IEquatable<TrainCakeCatchSearchScRsp>, IDeepCloneable<TrainCakeCatchSearchScRsp>, IBufferMessage
{
	private static readonly MessageParser<TrainCakeCatchSearchScRsp> _parser = new MessageParser<TrainCakeCatchSearchScRsp>(() => new TrainCakeCatchSearchScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int OMFCGLJDFPDFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_oMFCGLJDFPD_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> oMFCGLJDFPD_ = new RepeatedField<uint>();

	public const int BLEDIOOJPNLFieldNumber = 12;

	private PKILNDNCAMI bLEDIOOJPNL_;

	public const int HCJPDNDOHAMFieldNumber = 13;

	private uint hCJPDNDOHAM_;

	public const int KALIBGCODNFFieldNumber = 14;

	private static readonly FieldCodec<LGGABHPGPDD> _repeated_kALIBGCODNF_codec = FieldCodec.ForMessage(114u, LGGABHPGPDD.Parser);

	private readonly RepeatedField<LGGABHPGPDD> kALIBGCODNF_ = new RepeatedField<LGGABHPGPDD>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TrainCakeCatchSearchScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TrainCakeCatchSearchScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OMFCGLJDFPD => oMFCGLJDFPD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PKILNDNCAMI BLEDIOOJPNL
	{
		get
		{
			return bLEDIOOJPNL_;
		}
		set
		{
			bLEDIOOJPNL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HCJPDNDOHAM
	{
		get
		{
			return hCJPDNDOHAM_;
		}
		set
		{
			hCJPDNDOHAM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LGGABHPGPDD> KALIBGCODNF => kALIBGCODNF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainCakeCatchSearchScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainCakeCatchSearchScRsp(TrainCakeCatchSearchScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		oMFCGLJDFPD_ = other.oMFCGLJDFPD_.Clone();
		bLEDIOOJPNL_ = ((other.bLEDIOOJPNL_ != null) ? other.bLEDIOOJPNL_.Clone() : null);
		hCJPDNDOHAM_ = other.hCJPDNDOHAM_;
		kALIBGCODNF_ = other.kALIBGCODNF_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainCakeCatchSearchScRsp Clone()
	{
		return new TrainCakeCatchSearchScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TrainCakeCatchSearchScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TrainCakeCatchSearchScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!oMFCGLJDFPD_.Equals(other.oMFCGLJDFPD_))
		{
			return false;
		}
		if (!object.Equals(BLEDIOOJPNL, other.BLEDIOOJPNL))
		{
			return false;
		}
		if (HCJPDNDOHAM != other.HCJPDNDOHAM)
		{
			return false;
		}
		if (!kALIBGCODNF_.Equals(other.kALIBGCODNF_))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= oMFCGLJDFPD_.GetHashCode();
		if (bLEDIOOJPNL_ != null)
		{
			num ^= BLEDIOOJPNL.GetHashCode();
		}
		if (HCJPDNDOHAM != 0)
		{
			num ^= HCJPDNDOHAM.GetHashCode();
		}
		num ^= kALIBGCODNF_.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		oMFCGLJDFPD_.WriteTo(ref output, _repeated_oMFCGLJDFPD_codec);
		if (bLEDIOOJPNL_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(BLEDIOOJPNL);
		}
		if (HCJPDNDOHAM != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(HCJPDNDOHAM);
		}
		kALIBGCODNF_.WriteTo(ref output, _repeated_kALIBGCODNF_codec);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += oMFCGLJDFPD_.CalculateSize(_repeated_oMFCGLJDFPD_codec);
		if (bLEDIOOJPNL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BLEDIOOJPNL);
		}
		if (HCJPDNDOHAM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HCJPDNDOHAM);
		}
		num += kALIBGCODNF_.CalculateSize(_repeated_kALIBGCODNF_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TrainCakeCatchSearchScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		oMFCGLJDFPD_.Add(other.oMFCGLJDFPD_);
		if (other.bLEDIOOJPNL_ != null)
		{
			if (bLEDIOOJPNL_ == null)
			{
				BLEDIOOJPNL = new PKILNDNCAMI();
			}
			BLEDIOOJPNL.MergeFrom(other.BLEDIOOJPNL);
		}
		if (other.HCJPDNDOHAM != 0)
		{
			HCJPDNDOHAM = other.HCJPDNDOHAM;
		}
		kALIBGCODNF_.Add(other.kALIBGCODNF_);
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
			case 8u:
				Retcode = input.ReadUInt32();
				break;
			case 48u:
			case 50u:
				oMFCGLJDFPD_.AddEntriesFrom(ref input, _repeated_oMFCGLJDFPD_codec);
				break;
			case 98u:
				if (bLEDIOOJPNL_ == null)
				{
					BLEDIOOJPNL = new PKILNDNCAMI();
				}
				input.ReadMessage(BLEDIOOJPNL);
				break;
			case 104u:
				HCJPDNDOHAM = input.ReadUInt32();
				break;
			case 114u:
				kALIBGCODNF_.AddEntriesFrom(ref input, _repeated_kALIBGCODNF_codec);
				break;
			}
		}
	}
}
