using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TravelBrochureApplyPasterListCsReq : IMessage<TravelBrochureApplyPasterListCsReq>, IMessage, IEquatable<TravelBrochureApplyPasterListCsReq>, IDeepCloneable<TravelBrochureApplyPasterListCsReq>, IBufferMessage
{
	private static readonly MessageParser<TravelBrochureApplyPasterListCsReq> _parser = new MessageParser<TravelBrochureApplyPasterListCsReq>(() => new TravelBrochureApplyPasterListCsReq());

	private UnknownFieldSet _unknownFields;

	public const int MLFNLIBCBMOFieldNumber = 13;

	private static readonly FieldCodec<IHLLBHLEGMD> _repeated_mLFNLIBCBMO_codec = FieldCodec.ForMessage(106u, IHLLBHLEGMD.Parser);

	private readonly RepeatedField<IHLLBHLEGMD> mLFNLIBCBMO_ = new RepeatedField<IHLLBHLEGMD>();

	public const int HBCJPCMJPHEFieldNumber = 15;

	private uint hBCJPCMJPHE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TravelBrochureApplyPasterListCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TravelBrochureApplyPasterListCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IHLLBHLEGMD> MLFNLIBCBMO => mLFNLIBCBMO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HBCJPCMJPHE
	{
		get
		{
			return hBCJPCMJPHE_;
		}
		set
		{
			hBCJPCMJPHE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TravelBrochureApplyPasterListCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TravelBrochureApplyPasterListCsReq(TravelBrochureApplyPasterListCsReq other)
		: this()
	{
		mLFNLIBCBMO_ = other.mLFNLIBCBMO_.Clone();
		hBCJPCMJPHE_ = other.hBCJPCMJPHE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TravelBrochureApplyPasterListCsReq Clone()
	{
		return new TravelBrochureApplyPasterListCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TravelBrochureApplyPasterListCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TravelBrochureApplyPasterListCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mLFNLIBCBMO_.Equals(other.mLFNLIBCBMO_))
		{
			return false;
		}
		if (HBCJPCMJPHE != other.HBCJPCMJPHE)
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
		num ^= mLFNLIBCBMO_.GetHashCode();
		if (HBCJPCMJPHE != 0)
		{
			num ^= HBCJPCMJPHE.GetHashCode();
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
		mLFNLIBCBMO_.WriteTo(ref output, _repeated_mLFNLIBCBMO_codec);
		if (HBCJPCMJPHE != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(HBCJPCMJPHE);
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
		num += mLFNLIBCBMO_.CalculateSize(_repeated_mLFNLIBCBMO_codec);
		if (HBCJPCMJPHE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HBCJPCMJPHE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TravelBrochureApplyPasterListCsReq other)
	{
		if (other != null)
		{
			mLFNLIBCBMO_.Add(other.mLFNLIBCBMO_);
			if (other.HBCJPCMJPHE != 0)
			{
				HBCJPCMJPHE = other.HBCJPCMJPHE;
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
			case 106u:
				mLFNLIBCBMO_.AddEntriesFrom(ref input, _repeated_mLFNLIBCBMO_codec);
				break;
			case 120u:
				HBCJPCMJPHE = input.ReadUInt32();
				break;
			}
		}
	}
}
