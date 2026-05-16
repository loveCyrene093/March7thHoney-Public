using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HHIAOANDGAL : IMessage<HHIAOANDGAL>, IMessage, IEquatable<HHIAOANDGAL>, IDeepCloneable<HHIAOANDGAL>, IBufferMessage
{
	private static readonly MessageParser<HHIAOANDGAL> _parser = new MessageParser<HHIAOANDGAL>(() => new HHIAOANDGAL());

	private UnknownFieldSet _unknownFields;

	public const int VisitorIdFieldNumber = 8;

	private uint visitorId_;

	public const int AJLIIMNDPGLFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_aJLIIMNDPGL_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> aJLIIMNDPGL_ = new RepeatedField<uint>();

	public const int StatusFieldNumber = 11;

	private TrainVisitorStatus status_;

	public const int LAMIOKFJMEFFieldNumber = 14;

	private uint lAMIOKFJMEF_;

	public const int OLDMKNAIDELFieldNumber = 15;

	private bool oLDMKNAIDEL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HHIAOANDGAL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HHIAOANDGALReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint VisitorId
	{
		get
		{
			return visitorId_;
		}
		set
		{
			visitorId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> AJLIIMNDPGL => aJLIIMNDPGL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrainVisitorStatus Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LAMIOKFJMEF
	{
		get
		{
			return lAMIOKFJMEF_;
		}
		set
		{
			lAMIOKFJMEF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OLDMKNAIDEL
	{
		get
		{
			return oLDMKNAIDEL_;
		}
		set
		{
			oLDMKNAIDEL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHIAOANDGAL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHIAOANDGAL(HHIAOANDGAL other)
		: this()
	{
		visitorId_ = other.visitorId_;
		aJLIIMNDPGL_ = other.aJLIIMNDPGL_.Clone();
		status_ = other.status_;
		lAMIOKFJMEF_ = other.lAMIOKFJMEF_;
		oLDMKNAIDEL_ = other.oLDMKNAIDEL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HHIAOANDGAL Clone()
	{
		return new HHIAOANDGAL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HHIAOANDGAL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HHIAOANDGAL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (VisitorId != other.VisitorId)
		{
			return false;
		}
		if (!aJLIIMNDPGL_.Equals(other.aJLIIMNDPGL_))
		{
			return false;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (LAMIOKFJMEF != other.LAMIOKFJMEF)
		{
			return false;
		}
		if (OLDMKNAIDEL != other.OLDMKNAIDEL)
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
		if (VisitorId != 0)
		{
			num ^= VisitorId.GetHashCode();
		}
		num ^= aJLIIMNDPGL_.GetHashCode();
		if (Status != TrainVisitorStatus.JdpjhmhomlfPcpdhelpkem)
		{
			num ^= Status.GetHashCode();
		}
		if (LAMIOKFJMEF != 0)
		{
			num ^= LAMIOKFJMEF.GetHashCode();
		}
		if (OLDMKNAIDEL)
		{
			num ^= OLDMKNAIDEL.GetHashCode();
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
		if (VisitorId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(VisitorId);
		}
		aJLIIMNDPGL_.WriteTo(ref output, _repeated_aJLIIMNDPGL_codec);
		if (Status != TrainVisitorStatus.JdpjhmhomlfPcpdhelpkem)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)Status);
		}
		if (LAMIOKFJMEF != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(LAMIOKFJMEF);
		}
		if (OLDMKNAIDEL)
		{
			output.WriteRawTag(120);
			output.WriteBool(OLDMKNAIDEL);
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
		if (VisitorId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(VisitorId);
		}
		num += aJLIIMNDPGL_.CalculateSize(_repeated_aJLIIMNDPGL_codec);
		if (Status != TrainVisitorStatus.JdpjhmhomlfPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (LAMIOKFJMEF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LAMIOKFJMEF);
		}
		if (OLDMKNAIDEL)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HHIAOANDGAL other)
	{
		if (other != null)
		{
			if (other.VisitorId != 0)
			{
				VisitorId = other.VisitorId;
			}
			aJLIIMNDPGL_.Add(other.aJLIIMNDPGL_);
			if (other.Status != TrainVisitorStatus.JdpjhmhomlfPcpdhelpkem)
			{
				Status = other.Status;
			}
			if (other.LAMIOKFJMEF != 0)
			{
				LAMIOKFJMEF = other.LAMIOKFJMEF;
			}
			if (other.OLDMKNAIDEL)
			{
				OLDMKNAIDEL = other.OLDMKNAIDEL;
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
			case 64u:
				VisitorId = input.ReadUInt32();
				break;
			case 80u:
			case 82u:
				aJLIIMNDPGL_.AddEntriesFrom(ref input, _repeated_aJLIIMNDPGL_codec);
				break;
			case 88u:
				Status = (TrainVisitorStatus)input.ReadEnum();
				break;
			case 112u:
				LAMIOKFJMEF = input.ReadUInt32();
				break;
			case 120u:
				OLDMKNAIDEL = input.ReadBool();
				break;
			}
		}
	}
}
