using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FHBFFIFIPOA : IMessage<FHBFFIFIPOA>, IMessage, IEquatable<FHBFFIFIPOA>, IDeepCloneable<FHBFFIFIPOA>, IBufferMessage
{
	private static readonly MessageParser<FHBFFIFIPOA> _parser = new MessageParser<FHBFFIFIPOA>(() => new FHBFFIFIPOA());

	private UnknownFieldSet _unknownFields;

	public const int BeginTimeFieldNumber = 1;

	private ulong beginTime_;

	public const int EndTimeFieldNumber = 2;

	private ulong endTime_;

	public const int GEPIMAEONIFFieldNumber = 3;

	private uint gEPIMAEONIF_;

	public const int EOGHMOHBLNNFieldNumber = 10;

	private ulong eOGHMOHBLNN_;

	public const int IMNPFJIBJFEFieldNumber = 13;

	private static readonly FieldCodec<LuckyKoiInfoList> _repeated_iMNPFJIBJFE_codec = FieldCodec.ForMessage(106u, LuckyKoiInfoList.Parser);

	private readonly RepeatedField<LuckyKoiInfoList> iMNPFJIBJFE_ = new RepeatedField<LuckyKoiInfoList>();

	public const int AHBFAAMNKNOFieldNumber = 14;

	private static readonly FieldCodec<AMDMKFGOAPO> _repeated_aHBFAAMNKNO_codec = FieldCodec.ForMessage(114u, AMDMKFGOAPO.Parser);

	private readonly RepeatedField<AMDMKFGOAPO> aHBFAAMNKNO_ = new RepeatedField<AMDMKFGOAPO>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FHBFFIFIPOA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FHBFFIFIPOAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong BeginTime
	{
		get
		{
			return beginTime_;
		}
		set
		{
			beginTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong EndTime
	{
		get
		{
			return endTime_;
		}
		set
		{
			endTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GEPIMAEONIF
	{
		get
		{
			return gEPIMAEONIF_;
		}
		set
		{
			gEPIMAEONIF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong EOGHMOHBLNN
	{
		get
		{
			return eOGHMOHBLNN_;
		}
		set
		{
			eOGHMOHBLNN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LuckyKoiInfoList> IMNPFJIBJFE => iMNPFJIBJFE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<AMDMKFGOAPO> AHBFAAMNKNO => aHBFAAMNKNO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FHBFFIFIPOA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FHBFFIFIPOA(FHBFFIFIPOA other)
		: this()
	{
		beginTime_ = other.beginTime_;
		endTime_ = other.endTime_;
		gEPIMAEONIF_ = other.gEPIMAEONIF_;
		eOGHMOHBLNN_ = other.eOGHMOHBLNN_;
		iMNPFJIBJFE_ = other.iMNPFJIBJFE_.Clone();
		aHBFAAMNKNO_ = other.aHBFAAMNKNO_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FHBFFIFIPOA Clone()
	{
		return new FHBFFIFIPOA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FHBFFIFIPOA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FHBFFIFIPOA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BeginTime != other.BeginTime)
		{
			return false;
		}
		if (EndTime != other.EndTime)
		{
			return false;
		}
		if (GEPIMAEONIF != other.GEPIMAEONIF)
		{
			return false;
		}
		if (EOGHMOHBLNN != other.EOGHMOHBLNN)
		{
			return false;
		}
		if (!iMNPFJIBJFE_.Equals(other.iMNPFJIBJFE_))
		{
			return false;
		}
		if (!aHBFAAMNKNO_.Equals(other.aHBFAAMNKNO_))
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
		if (BeginTime != 0L)
		{
			num ^= BeginTime.GetHashCode();
		}
		if (EndTime != 0L)
		{
			num ^= EndTime.GetHashCode();
		}
		if (GEPIMAEONIF != 0)
		{
			num ^= GEPIMAEONIF.GetHashCode();
		}
		if (EOGHMOHBLNN != 0L)
		{
			num ^= EOGHMOHBLNN.GetHashCode();
		}
		num ^= iMNPFJIBJFE_.GetHashCode();
		num ^= aHBFAAMNKNO_.GetHashCode();
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
		if (BeginTime != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(BeginTime);
		}
		if (EndTime != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(EndTime);
		}
		if (GEPIMAEONIF != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(GEPIMAEONIF);
		}
		if (EOGHMOHBLNN != 0L)
		{
			output.WriteRawTag(80);
			output.WriteUInt64(EOGHMOHBLNN);
		}
		iMNPFJIBJFE_.WriteTo(ref output, _repeated_iMNPFJIBJFE_codec);
		aHBFAAMNKNO_.WriteTo(ref output, _repeated_aHBFAAMNKNO_codec);
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
		if (BeginTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(BeginTime);
		}
		if (EndTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(EndTime);
		}
		if (GEPIMAEONIF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GEPIMAEONIF);
		}
		if (EOGHMOHBLNN != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(EOGHMOHBLNN);
		}
		num += iMNPFJIBJFE_.CalculateSize(_repeated_iMNPFJIBJFE_codec);
		num += aHBFAAMNKNO_.CalculateSize(_repeated_aHBFAAMNKNO_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FHBFFIFIPOA other)
	{
		if (other != null)
		{
			if (other.BeginTime != 0L)
			{
				BeginTime = other.BeginTime;
			}
			if (other.EndTime != 0L)
			{
				EndTime = other.EndTime;
			}
			if (other.GEPIMAEONIF != 0)
			{
				GEPIMAEONIF = other.GEPIMAEONIF;
			}
			if (other.EOGHMOHBLNN != 0L)
			{
				EOGHMOHBLNN = other.EOGHMOHBLNN;
			}
			iMNPFJIBJFE_.Add(other.iMNPFJIBJFE_);
			aHBFAAMNKNO_.Add(other.aHBFAAMNKNO_);
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
				BeginTime = input.ReadUInt64();
				break;
			case 16u:
				EndTime = input.ReadUInt64();
				break;
			case 24u:
				GEPIMAEONIF = input.ReadUInt32();
				break;
			case 80u:
				EOGHMOHBLNN = input.ReadUInt64();
				break;
			case 106u:
				iMNPFJIBJFE_.AddEntriesFrom(ref input, _repeated_iMNPFJIBJFE_codec);
				break;
			case 114u:
				aHBFAAMNKNO_.AddEntriesFrom(ref input, _repeated_aHBFAAMNKNO_codec);
				break;
			}
		}
	}
}
