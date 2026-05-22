using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OOADALEMDGL : IMessage<OOADALEMDGL>, IMessage, IEquatable<OOADALEMDGL>, IDeepCloneable<OOADALEMDGL>, IBufferMessage
{
	private static readonly MessageParser<OOADALEMDGL> _parser = new MessageParser<OOADALEMDGL>(() => new OOADALEMDGL());

	private UnknownFieldSet _unknownFields;

	public const int AreaIdFieldNumber = 1;

	private uint areaId_;

	public const int LPJDEMOMDIEFieldNumber = 2;

	private static readonly FieldCodec<IDHNJFPAEGP> _repeated_lPJDEMOMDIE_codec = FieldCodec.ForMessage(18u, IDHNJFPAEGP.Parser);

	private readonly RepeatedField<IDHNJFPAEGP> lPJDEMOMDIE_ = new RepeatedField<IDHNJFPAEGP>();

	public const int ProgressFieldNumber = 7;

	private uint progress_;

	public const int OIGHBOMFGGDFieldNumber = 15;

	private uint oIGHBOMFGGD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OOADALEMDGL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OOADALEMDGLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AreaId
	{
		get
		{
			return areaId_;
		}
		set
		{
			areaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IDHNJFPAEGP> LPJDEMOMDIE => lPJDEMOMDIE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Progress
	{
		get
		{
			return progress_;
		}
		set
		{
			progress_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OIGHBOMFGGD
	{
		get
		{
			return oIGHBOMFGGD_;
		}
		set
		{
			oIGHBOMFGGD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOADALEMDGL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOADALEMDGL(OOADALEMDGL other)
		: this()
	{
		areaId_ = other.areaId_;
		lPJDEMOMDIE_ = other.lPJDEMOMDIE_.Clone();
		progress_ = other.progress_;
		oIGHBOMFGGD_ = other.oIGHBOMFGGD_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOADALEMDGL Clone()
	{
		return new OOADALEMDGL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OOADALEMDGL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OOADALEMDGL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AreaId != other.AreaId)
		{
			return false;
		}
		if (!lPJDEMOMDIE_.Equals(other.lPJDEMOMDIE_))
		{
			return false;
		}
		if (Progress != other.Progress)
		{
			return false;
		}
		if (OIGHBOMFGGD != other.OIGHBOMFGGD)
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
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
		}
		num ^= lPJDEMOMDIE_.GetHashCode();
		if (Progress != 0)
		{
			num ^= Progress.GetHashCode();
		}
		if (OIGHBOMFGGD != 0)
		{
			num ^= OIGHBOMFGGD.GetHashCode();
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
		if (AreaId != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(AreaId);
		}
		lPJDEMOMDIE_.WriteTo(ref output, _repeated_lPJDEMOMDIE_codec);
		if (Progress != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Progress);
		}
		if (OIGHBOMFGGD != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(OIGHBOMFGGD);
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
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		num += lPJDEMOMDIE_.CalculateSize(_repeated_lPJDEMOMDIE_codec);
		if (Progress != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Progress);
		}
		if (OIGHBOMFGGD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OIGHBOMFGGD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OOADALEMDGL other)
	{
		if (other != null)
		{
			if (other.AreaId != 0)
			{
				AreaId = other.AreaId;
			}
			lPJDEMOMDIE_.Add(other.lPJDEMOMDIE_);
			if (other.Progress != 0)
			{
				Progress = other.Progress;
			}
			if (other.OIGHBOMFGGD != 0)
			{
				OIGHBOMFGGD = other.OIGHBOMFGGD;
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
				AreaId = input.ReadUInt32();
				break;
			case 18u:
				lPJDEMOMDIE_.AddEntriesFrom(ref input, _repeated_lPJDEMOMDIE_codec);
				break;
			case 56u:
				Progress = input.ReadUInt32();
				break;
			case 120u:
				OIGHBOMFGGD = input.ReadUInt32();
				break;
			}
		}
	}
}
