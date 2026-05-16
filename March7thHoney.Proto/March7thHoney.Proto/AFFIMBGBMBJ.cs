using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AFFIMBGBMBJ : IMessage<AFFIMBGBMBJ>, IMessage, IEquatable<AFFIMBGBMBJ>, IDeepCloneable<AFFIMBGBMBJ>, IBufferMessage
{
	private static readonly MessageParser<AFFIMBGBMBJ> _parser = new MessageParser<AFFIMBGBMBJ>(() => new AFFIMBGBMBJ());

	private UnknownFieldSet _unknownFields;

	public const int StateFieldNumber = 1;

	private MuseumRandomEventState state_;

	public const int ILHABFJKEGDFieldNumber = 2;

	private uint iLHABFJKEGD_;

	public const int HBDCHIMFKDKFieldNumber = 3;

	private uint hBDCHIMFKDK_;

	public const int ODIACLIKIFPFieldNumber = 8;

	private uint oDIACLIKIFP_;

	public const int GFHKBMLDKDPFieldNumber = 10;

	private uint gFHKBMLDKDP_;

	public const int DAODPGDDFCAFieldNumber = 11;

	private static readonly FieldCodec<uint> _repeated_dAODPGDDFCA_codec = FieldCodec.ForUInt32(90u);

	private readonly RepeatedField<uint> dAODPGDDFCA_ = new RepeatedField<uint>();

	public const int EventIdFieldNumber = 14;

	private uint eventId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AFFIMBGBMBJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AFFIMBGBMBJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MuseumRandomEventState State
	{
		get
		{
			return state_;
		}
		set
		{
			state_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ILHABFJKEGD
	{
		get
		{
			return iLHABFJKEGD_;
		}
		set
		{
			iLHABFJKEGD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HBDCHIMFKDK
	{
		get
		{
			return hBDCHIMFKDK_;
		}
		set
		{
			hBDCHIMFKDK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ODIACLIKIFP
	{
		get
		{
			return oDIACLIKIFP_;
		}
		set
		{
			oDIACLIKIFP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GFHKBMLDKDP
	{
		get
		{
			return gFHKBMLDKDP_;
		}
		set
		{
			gFHKBMLDKDP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DAODPGDDFCA => dAODPGDDFCA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EventId
	{
		get
		{
			return eventId_;
		}
		set
		{
			eventId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AFFIMBGBMBJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AFFIMBGBMBJ(AFFIMBGBMBJ other)
		: this()
	{
		state_ = other.state_;
		iLHABFJKEGD_ = other.iLHABFJKEGD_;
		hBDCHIMFKDK_ = other.hBDCHIMFKDK_;
		oDIACLIKIFP_ = other.oDIACLIKIFP_;
		gFHKBMLDKDP_ = other.gFHKBMLDKDP_;
		dAODPGDDFCA_ = other.dAODPGDDFCA_.Clone();
		eventId_ = other.eventId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AFFIMBGBMBJ Clone()
	{
		return new AFFIMBGBMBJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AFFIMBGBMBJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AFFIMBGBMBJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (State != other.State)
		{
			return false;
		}
		if (ILHABFJKEGD != other.ILHABFJKEGD)
		{
			return false;
		}
		if (HBDCHIMFKDK != other.HBDCHIMFKDK)
		{
			return false;
		}
		if (ODIACLIKIFP != other.ODIACLIKIFP)
		{
			return false;
		}
		if (GFHKBMLDKDP != other.GFHKBMLDKDP)
		{
			return false;
		}
		if (!dAODPGDDFCA_.Equals(other.dAODPGDDFCA_))
		{
			return false;
		}
		if (EventId != other.EventId)
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
		if (State != MuseumRandomEventState.JkeknddbdmcPcpdhelpkem)
		{
			num ^= State.GetHashCode();
		}
		if (ILHABFJKEGD != 0)
		{
			num ^= ILHABFJKEGD.GetHashCode();
		}
		if (HBDCHIMFKDK != 0)
		{
			num ^= HBDCHIMFKDK.GetHashCode();
		}
		if (ODIACLIKIFP != 0)
		{
			num ^= ODIACLIKIFP.GetHashCode();
		}
		if (GFHKBMLDKDP != 0)
		{
			num ^= GFHKBMLDKDP.GetHashCode();
		}
		num ^= dAODPGDDFCA_.GetHashCode();
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
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
		if (State != MuseumRandomEventState.JkeknddbdmcPcpdhelpkem)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)State);
		}
		if (ILHABFJKEGD != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(ILHABFJKEGD);
		}
		if (HBDCHIMFKDK != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(HBDCHIMFKDK);
		}
		if (ODIACLIKIFP != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(ODIACLIKIFP);
		}
		if (GFHKBMLDKDP != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(GFHKBMLDKDP);
		}
		dAODPGDDFCA_.WriteTo(ref output, _repeated_dAODPGDDFCA_codec);
		if (EventId != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(EventId);
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
		if (State != MuseumRandomEventState.JkeknddbdmcPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)State);
		}
		if (ILHABFJKEGD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ILHABFJKEGD);
		}
		if (HBDCHIMFKDK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HBDCHIMFKDK);
		}
		if (ODIACLIKIFP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ODIACLIKIFP);
		}
		if (GFHKBMLDKDP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GFHKBMLDKDP);
		}
		num += dAODPGDDFCA_.CalculateSize(_repeated_dAODPGDDFCA_codec);
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EventId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AFFIMBGBMBJ other)
	{
		if (other != null)
		{
			if (other.State != MuseumRandomEventState.JkeknddbdmcPcpdhelpkem)
			{
				State = other.State;
			}
			if (other.ILHABFJKEGD != 0)
			{
				ILHABFJKEGD = other.ILHABFJKEGD;
			}
			if (other.HBDCHIMFKDK != 0)
			{
				HBDCHIMFKDK = other.HBDCHIMFKDK;
			}
			if (other.ODIACLIKIFP != 0)
			{
				ODIACLIKIFP = other.ODIACLIKIFP;
			}
			if (other.GFHKBMLDKDP != 0)
			{
				GFHKBMLDKDP = other.GFHKBMLDKDP;
			}
			dAODPGDDFCA_.Add(other.dAODPGDDFCA_);
			if (other.EventId != 0)
			{
				EventId = other.EventId;
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
				State = (MuseumRandomEventState)input.ReadEnum();
				break;
			case 16u:
				ILHABFJKEGD = input.ReadUInt32();
				break;
			case 24u:
				HBDCHIMFKDK = input.ReadUInt32();
				break;
			case 64u:
				ODIACLIKIFP = input.ReadUInt32();
				break;
			case 80u:
				GFHKBMLDKDP = input.ReadUInt32();
				break;
			case 88u:
			case 90u:
				dAODPGDDFCA_.AddEntriesFrom(ref input, _repeated_dAODPGDDFCA_codec);
				break;
			case 112u:
				EventId = input.ReadUInt32();
				break;
			}
		}
	}
}
