using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesHandleCardPieceApplyCsReq : IMessage<PlanetFesHandleCardPieceApplyCsReq>, IMessage, IEquatable<PlanetFesHandleCardPieceApplyCsReq>, IDeepCloneable<PlanetFesHandleCardPieceApplyCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesHandleCardPieceApplyCsReq> _parser = new MessageParser<PlanetFesHandleCardPieceApplyCsReq>(() => new PlanetFesHandleCardPieceApplyCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ILCOOFLFGFHFieldNumber = 4;

	private bool iLCOOFLFGFH_;

	public const int EPGIKGCADHMFieldNumber = 7;

	private uint ePGIKGCADHM_;

	public const int GIIIGJFMHPOFieldNumber = 11;

	private uint gIIIGJFMHPO_;

	public const int MGAFDDCGJPMFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_mGAFDDCGJPM_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> mGAFDDCGJPM_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesHandleCardPieceApplyCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesHandleCardPieceApplyCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ILCOOFLFGFH
	{
		get
		{
			return iLCOOFLFGFH_;
		}
		set
		{
			iLCOOFLFGFH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EPGIKGCADHM
	{
		get
		{
			return ePGIKGCADHM_;
		}
		set
		{
			ePGIKGCADHM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GIIIGJFMHPO
	{
		get
		{
			return gIIIGJFMHPO_;
		}
		set
		{
			gIIIGJFMHPO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MGAFDDCGJPM => mGAFDDCGJPM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesHandleCardPieceApplyCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesHandleCardPieceApplyCsReq(PlanetFesHandleCardPieceApplyCsReq other)
		: this()
	{
		iLCOOFLFGFH_ = other.iLCOOFLFGFH_;
		ePGIKGCADHM_ = other.ePGIKGCADHM_;
		gIIIGJFMHPO_ = other.gIIIGJFMHPO_;
		mGAFDDCGJPM_ = other.mGAFDDCGJPM_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesHandleCardPieceApplyCsReq Clone()
	{
		return new PlanetFesHandleCardPieceApplyCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesHandleCardPieceApplyCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesHandleCardPieceApplyCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ILCOOFLFGFH != other.ILCOOFLFGFH)
		{
			return false;
		}
		if (EPGIKGCADHM != other.EPGIKGCADHM)
		{
			return false;
		}
		if (GIIIGJFMHPO != other.GIIIGJFMHPO)
		{
			return false;
		}
		if (!mGAFDDCGJPM_.Equals(other.mGAFDDCGJPM_))
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
		if (ILCOOFLFGFH)
		{
			num ^= ILCOOFLFGFH.GetHashCode();
		}
		if (EPGIKGCADHM != 0)
		{
			num ^= EPGIKGCADHM.GetHashCode();
		}
		if (GIIIGJFMHPO != 0)
		{
			num ^= GIIIGJFMHPO.GetHashCode();
		}
		num ^= mGAFDDCGJPM_.GetHashCode();
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
		if (ILCOOFLFGFH)
		{
			output.WriteRawTag(32);
			output.WriteBool(ILCOOFLFGFH);
		}
		if (EPGIKGCADHM != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(EPGIKGCADHM);
		}
		if (GIIIGJFMHPO != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(GIIIGJFMHPO);
		}
		mGAFDDCGJPM_.WriteTo(ref output, _repeated_mGAFDDCGJPM_codec);
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
		if (ILCOOFLFGFH)
		{
			num += 2;
		}
		if (EPGIKGCADHM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EPGIKGCADHM);
		}
		if (GIIIGJFMHPO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GIIIGJFMHPO);
		}
		num += mGAFDDCGJPM_.CalculateSize(_repeated_mGAFDDCGJPM_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesHandleCardPieceApplyCsReq other)
	{
		if (other != null)
		{
			if (other.ILCOOFLFGFH)
			{
				ILCOOFLFGFH = other.ILCOOFLFGFH;
			}
			if (other.EPGIKGCADHM != 0)
			{
				EPGIKGCADHM = other.EPGIKGCADHM;
			}
			if (other.GIIIGJFMHPO != 0)
			{
				GIIIGJFMHPO = other.GIIIGJFMHPO;
			}
			mGAFDDCGJPM_.Add(other.mGAFDDCGJPM_);
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
			case 32u:
				ILCOOFLFGFH = input.ReadBool();
				break;
			case 56u:
				EPGIKGCADHM = input.ReadUInt32();
				break;
			case 88u:
				GIIIGJFMHPO = input.ReadUInt32();
				break;
			case 104u:
			case 106u:
				mGAFDDCGJPM_.AddEntriesFrom(ref input, _repeated_mGAFDDCGJPM_codec);
				break;
			}
		}
	}
}
