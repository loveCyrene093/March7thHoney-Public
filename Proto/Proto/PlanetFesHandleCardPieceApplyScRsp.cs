using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesHandleCardPieceApplyScRsp : IMessage<PlanetFesHandleCardPieceApplyScRsp>, IMessage, IEquatable<PlanetFesHandleCardPieceApplyScRsp>, IDeepCloneable<PlanetFesHandleCardPieceApplyScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesHandleCardPieceApplyScRsp> _parser = new MessageParser<PlanetFesHandleCardPieceApplyScRsp>(() => new PlanetFesHandleCardPieceApplyScRsp());

	private UnknownFieldSet _unknownFields;

	public const int MGAFDDCGJPMFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_mGAFDDCGJPM_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> mGAFDDCGJPM_ = new RepeatedField<uint>();

	public const int ILCOOFLFGFHFieldNumber = 6;

	private bool iLCOOFLFGFH_;

	public const int EPGIKGCADHMFieldNumber = 8;

	private uint ePGIKGCADHM_;

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	public const int ONBBNACBADFFieldNumber = 15;

	private long oNBBNACBADF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesHandleCardPieceApplyScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesHandleCardPieceApplyScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> MGAFDDCGJPM => mGAFDDCGJPM_;

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
	public long ONBBNACBADF
	{
		get
		{
			return oNBBNACBADF_;
		}
		set
		{
			oNBBNACBADF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesHandleCardPieceApplyScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesHandleCardPieceApplyScRsp(PlanetFesHandleCardPieceApplyScRsp other)
		: this()
	{
		mGAFDDCGJPM_ = other.mGAFDDCGJPM_.Clone();
		iLCOOFLFGFH_ = other.iLCOOFLFGFH_;
		ePGIKGCADHM_ = other.ePGIKGCADHM_;
		retcode_ = other.retcode_;
		oNBBNACBADF_ = other.oNBBNACBADF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesHandleCardPieceApplyScRsp Clone()
	{
		return new PlanetFesHandleCardPieceApplyScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesHandleCardPieceApplyScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesHandleCardPieceApplyScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!mGAFDDCGJPM_.Equals(other.mGAFDDCGJPM_))
		{
			return false;
		}
		if (ILCOOFLFGFH != other.ILCOOFLFGFH)
		{
			return false;
		}
		if (EPGIKGCADHM != other.EPGIKGCADHM)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (ONBBNACBADF != other.ONBBNACBADF)
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
		num ^= mGAFDDCGJPM_.GetHashCode();
		if (ILCOOFLFGFH)
		{
			num ^= ILCOOFLFGFH.GetHashCode();
		}
		if (EPGIKGCADHM != 0)
		{
			num ^= EPGIKGCADHM.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (ONBBNACBADF != 0L)
		{
			num ^= ONBBNACBADF.GetHashCode();
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
		mGAFDDCGJPM_.WriteTo(ref output, _repeated_mGAFDDCGJPM_codec);
		if (ILCOOFLFGFH)
		{
			output.WriteRawTag(48);
			output.WriteBool(ILCOOFLFGFH);
		}
		if (EPGIKGCADHM != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(EPGIKGCADHM);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Retcode);
		}
		if (ONBBNACBADF != 0L)
		{
			output.WriteRawTag(120);
			output.WriteInt64(ONBBNACBADF);
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
		num += mGAFDDCGJPM_.CalculateSize(_repeated_mGAFDDCGJPM_codec);
		if (ILCOOFLFGFH)
		{
			num += 2;
		}
		if (EPGIKGCADHM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EPGIKGCADHM);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (ONBBNACBADF != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(ONBBNACBADF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesHandleCardPieceApplyScRsp other)
	{
		if (other != null)
		{
			mGAFDDCGJPM_.Add(other.mGAFDDCGJPM_);
			if (other.ILCOOFLFGFH)
			{
				ILCOOFLFGFH = other.ILCOOFLFGFH;
			}
			if (other.EPGIKGCADHM != 0)
			{
				EPGIKGCADHM = other.EPGIKGCADHM;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.ONBBNACBADF != 0L)
			{
				ONBBNACBADF = other.ONBBNACBADF;
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
			case 32u:
			case 34u:
				mGAFDDCGJPM_.AddEntriesFrom(ref input, _repeated_mGAFDDCGJPM_codec);
				break;
			case 48u:
				ILCOOFLFGFH = input.ReadBool();
				break;
			case 64u:
				EPGIKGCADHM = input.ReadUInt32();
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			case 120u:
				ONBBNACBADF = input.ReadInt64();
				break;
			}
		}
	}
}
